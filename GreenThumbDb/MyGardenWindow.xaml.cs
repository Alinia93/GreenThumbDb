using GreenThumbDb.DataBase;
using GreenThumbDb.Managers;
using GreenThumbDb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbDb
{
    /// <summary>
    /// Interaction logic for MyGardenWindow.xaml
    /// </summary>
    public partial class MyGardenWindow : Window
    {
        public MyGardenWindow()
        {
            InitializeComponent();
            UpdateUi();
        }


        public void UpdateUi()
        {
            using (AppDbContext context = new())
            {
                User user = UserManager.SignedInUser;

                Garden garden = context.Gardens
                    .Include(g => g.GardenPlants)
                    .ThenInclude(gp => gp.Plant)
                    .ThenInclude(p => p.Instructions)
                    .First(gp => gp.UserId == user.Id);

                List<Plant> plants = garden.GardenPlants.Select(gp => gp.Plant).ToList();

                if (plants != null)
                {

                    foreach (Plant plant in plants)
                    {
                        ListViewItem item = new();
                        item.Content = PlantManager.GetInfoPlant(plant);
                        lstPlantsInstructions.Items.Add(item);

                    }
                }
                else
                {
                    MessageBox.Show("Hej");
                }
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();
        }
    }


}
