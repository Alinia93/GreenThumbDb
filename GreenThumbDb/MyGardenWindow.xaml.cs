using GreenThumbDb.DataBase;
using GreenThumbDb.Managers;
using GreenThumbDb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace GreenThumbDb
{
    /// <summary>
    /// Interaction logic for MyGardenWindow.xaml
    /// </summary>
    public partial class MyGardenWindow : Window
    {
        List<Plant> plants = new();
        public MyGardenWindow()
        {
            InitializeComponent();
            UpdateUi();
        }


        public void UpdateUi()
        {
            using (AppDbContext context = new())
            {
                User user = UserManager.SignedInUser!;

                Garden garden = context.Gardens
                    .Include(g => g.GardenPlants)
                    .ThenInclude(gp => gp.Plant)
                    .ThenInclude(p => p.Instructions)
                    .First(gp => gp.UserId == user.Id);

                plants = garden.GardenPlants.Select(gp => gp.Plant).ToList();

                if (plants != null)
                {

                    foreach (Plant plant in plants)
                    {
                        ListViewItem item = new();
                        item.Tag = plant;
                        item.Content = plant.EnglishName;
                        lstYourPlants.Items.Add(item);

                    }
                }

            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();
        }

        private void lstYourPlants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstInstructions.Items.Clear();
            ListViewItem selectedItem = (ListViewItem)lstYourPlants.SelectedItem;
            Plant selectedPlant = (Plant)selectedItem.Tag;

            txtBotanicalName.Text = selectedPlant.BotanicalName;
            txtColor.Text = selectedPlant.Color;
            txtFamily.Text = selectedPlant.Family;

            List<Instruction> instructions = selectedPlant.Instructions.ToList();
            int number = 1;
            foreach (Instruction instruction in instructions)
            {
                TextBlock txtBlock = new();

                Run newRun = new($"{number}. ");
                txtBlock.Inlines.Add(newRun);

                Run newRun1 = new(instruction.Name);
                newRun1.FontWeight = FontWeights.Bold;
                txtBlock.Inlines.Add(newRun1);

                Run newRun2 = new(". Description: ");
                newRun2.FontWeight = FontWeights.Bold;
                txtBlock.Inlines.Add(newRun2);

                Run newRun3 = new(instruction.Description);
                txtBlock.Inlines.Add(newRun3);
                ListViewItem item = new();

                item.Content = txtBlock;
                lstInstructions.Items.Add(item);
            }
        }
    }


}
