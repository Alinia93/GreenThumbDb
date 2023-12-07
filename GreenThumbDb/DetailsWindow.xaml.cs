using GreenThumbDb.DataBase;
using GreenThumbDb.Managers;
using GreenThumbDb.Models;
using GreenThumbDb.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace GreenThumbDb
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    /// 

    public partial class DetailsWindow : Window
    {
        Plant plant = new();
        public DetailsWindow(Plant selectedPlant)
        {
            plant = selectedPlant;
            InitializeComponent();
            UpdateUi();
        }




        public void UpdateUi()
        {
            txtPlantName.Text = plant.EnglishName;
            txtBotanicalName.Text = plant.EnglishName;
            txtFamily.Text = plant.Family;
            txtColor.Text = plant.Color;


            using (AppDbContext context = new())
            {
                List<Instruction> instructions = context.Instructions.Where(i => i.PlantId == plant.Id).ToList();
                int number = 1;

                foreach (Instruction instruction in instructions)
                {
                    //För att göra vissa delar av strängen fet-stil
                    TextBlock txtBlock = new();
                    Run newRun = new($"{number}. ");
                    txtBlock.Inlines.Add(newRun);

                    Run newRun1 = new("Instruction name: ");
                    newRun1.FontWeight = FontWeights.Bold;
                    txtBlock.Inlines.Add(newRun1);

                    Run newRun2 = new(instruction.Name);
                    txtBlock.Inlines.Add(newRun2);

                    Run newRun3 = new(". Description: ");
                    newRun3.FontWeight = FontWeights.Bold;
                    txtBlock.Inlines.Add(newRun3);

                    Run newRun4 = new(instruction.Description);
                    txtBlock.Inlines.Add(newRun4);

                    ListViewItem item = new();
                    item.Tag = instruction;
                    item.Content = txtBlock;
                    lstInstructions.Items.Add(item);
                    number++;
                }
            }

        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();
        }

        private void btnAddToYourGarden_Click(object sender, RoutedEventArgs e)
        {
            using (AppDbContext context = new())
            {
                User signedInUser = UserManager.SignedInUser!;
                Garden garden = signedInUser.Garden!;

                //Kollar om blomman redan finns i userns trädgård
                var gardenPlant = context.GardenPlants.FirstOrDefault(gp => gp.GardenId == garden.Id && gp.PlantId == plant.Id);
                if (gardenPlant != null)
                {
                    MessageBox.Show("You already have this plant in your garden.", "Warning");
                    return;
                }


                GardenPlants gardenPlants = new()
                {
                    GardenId = garden.Id,
                    PlantId = plant.Id
                };



                UnitOfWorkRepository uow = new(context);
                uow.GardenPlantsRepository.Add(gardenPlants);
                uow.Complete();
            }

            MessageBox.Show("The plant is added to your garden!", "Congratulations!");
            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();

        }
    }
}



