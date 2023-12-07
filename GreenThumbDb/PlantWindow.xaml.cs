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
        public PlantWindow()
        {
            InitializeComponent();
            UpdateUi();
        }
        private void UpdateUi()
        {
            cmbPlants.Items.Clear();
            txtSearchPlant.Text = "";
            cmbPlants.SelectedItem = null;

            using (AppDbContext context = new())
            {
                UnitOfWorkRepository uow = new(context);
                List<Plant> plants = uow.PlantRepository.GetAll();


                foreach (Plant plant in plants)
                {
                    ComboBoxItem item = new();
                    item.Tag = plant;
                    item.Content = plant.EnglishName;
                    cmbPlants.Items.Add(item);
                }
            }
        }
        private void btnSearchForPlant_Click(object sender, RoutedEventArgs e)
        {
            if (txtSearchPlant.Text == "")
            {
                MessageBox.Show("You have not written anything in the search box.", "Warning");
                return;
            }
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
            if (cmbPlants.SelectedItem == null)
            {
                MessageBox.Show("You have to choose a plant to see details.", "Warning");
                return;
            }

            ComboBoxItem selectedItem = (ComboBoxItem)cmbPlants.SelectedItem;
            Plant selectedPlant = (Plant)selectedItem.Tag;

            DetailsWindow detailsWindow = new(selectedPlant);
            detailsWindow.Show();
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (cmbPlants.SelectedItem == null)
            {
                MessageBox.Show("You have to select a plant to be able to remove it.", "Warning");
                return;
            }
            ComboBoxItem selectedItem = (ComboBoxItem)cmbPlants.SelectedItem;
            Plant plant = (Plant)selectedItem.Tag;
            using (AppDbContext context = new())
            {
                UnitOfWorkRepository uow = new(context);
                uow.PlantRepository.Delete(plant);
                uow.Complete();
                MessageBox.Show("The plant is removed", "Removed");

                UpdateUi();
            }
        }
        private void btnGoBack_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }
        private void btnAddNewPlant_Click(object sender, RoutedEventArgs e)
        {
            AddPlantWindow addPlantWindow = new();
            addPlantWindow.Show();
            Close();
        }

        private void btnGoToYourGarden_Click_1(object sender, RoutedEventArgs e)
        {
            MyGardenWindow myGardenWindow = new();
            myGardenWindow.Show();
            Close();

        }
    }
}
