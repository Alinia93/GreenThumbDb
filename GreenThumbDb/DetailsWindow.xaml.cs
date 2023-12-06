using GreenThumbDb.DataBase;
using GreenThumbDb.Managers;
using GreenThumbDb.Models;
using GreenThumbDb.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

                foreach (Instruction instruction in instructions)
                {
                    ListViewItem item = new();
                    item.Tag = instruction;
                    item.Content = $"Name: {instruction.Name}. Description: {instruction.Description}";
                    lstInstructions.Items.Add(item);
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
            User signedInUser = UserManager.SignedInUser!;
            Garden garden = signedInUser.Garden!;


            GardenPlants gardenPlants = new()
            {
                GardenId = garden.Id,
                PlantId = plant.Id
            };

            using (AppDbContext context = new())
            {
                UnitOfWorkRepository uow = new(context);
                uow.GardenPlantsRepository.Add(gardenPlants);
                uow.Complete();
            }

            MessageBox.Show("The plant is added to your garden!", "Congratulations!");



        }
    }
}



