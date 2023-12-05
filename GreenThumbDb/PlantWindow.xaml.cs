using GreenThumbDb.DataBase;
using GreenThumbDb.Managers;
using GreenThumbDb.Models;
using GreenThumbDb.Repository;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbDb
{
    /// <summary>
    /// Interaction logic for PlantWindow.xaml
    /// </summary>
    public partial class PlantWindow : Window
    {
        List<Plant> plants = new();
        public PlantWindow()
        {
            InitializeComponent();

            using (AppDbContext context = new())
            {
                UnitOfWorkRepository uow = new(context);
                plants = uow.PlantRepository.GetAll();

            }
            foreach (Plant plant in plants)
            {
                ComboBoxItem item = new();
                item.Tag = plant;
                item.Content = plant.EnglishName;
                cmbPlants.Items.Add(item);
            }
        }

        private void btnSearchForPlant_Click(object sender, RoutedEventArgs e)
        {
            string plantName = txtSearchPlant.Text;

            var foundPlant = PlantManager.SearchForPlant(plantName);
            if (foundPlant != null)
            {

                foreach (ComboBoxItem item in cmbPlants.Items)
                {
                    if (foundPlant.Id == ((Plant)item.Tag).Id)
                    {
                        cmbPlants.SelectedItem = item;
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("We could not find that plant. Try again", "Warning");
            }
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
