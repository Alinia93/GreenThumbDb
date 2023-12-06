using GreenThumbDb.DataBase;
using GreenThumbDb.Managers;
using GreenThumbDb.Models;
using GreenThumbDb.Repository;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbDb
{
    /// <summary>
    /// Interaction logic for AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        Plant newPlant = new();
        public AddPlantWindow()
        {
            InitializeComponent();
        }

        private void btnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            if (txtPlantName.Text == "")
            {
                MessageBox.Show("You have to write the name of the plant!", "Warning");
                return;

            }

            txtAddInstructionsFor.Text = txtPlantName.Text;
            txtAddInstructionsFor.IsEnabled = true;
            txtInstructionName.IsEnabled = true;
            txtDescription.IsEnabled = true;

            var plant = PlantManager.SearchForPlant(txtPlantName.Text);
            if (plant == null)
            {


                newPlant.EnglishName = txtPlantName.Text;
                newPlant.BotanicalName = txtBotanicalName.Text;
                newPlant.Family = txtPlantFamily.Text;
                newPlant.Color = txtColor.Text;
                MessageBox.Show("Plant is added.Now you can give your plant instructions! Then press save.");

            }
            else
            {
                MessageBox.Show("This plant already exist in our database. Try with a new one!", "Warning");
            }

        }

        private void btnAddInsctructions_Click(object sender, RoutedEventArgs e)

        {

            if (txtInstructionName.Text == "" && txtDescription.Text == "")
            {
                MessageBox.Show("You have to fill in the instructions name and the instruction description!", "Warning");
                return;
            }
            txtInstructionName.Text = "";
            txtDescription.Text = "";

            string instructionName = txtInstructionName.Text;
            string description = txtDescription.Text;
            Instruction newInstruction = new()
            {
                Name = instructionName,
                Description = description,
            };

            ListViewItem item = new();
            item.Tag = newInstruction;
            item.Content = newInstruction.Name;
            lstPlantInstructions.Items.Add(item);

        }

        private void btnSavePlant_Click(object sender, RoutedEventArgs e)
        {
            foreach (ListViewItem item in lstPlantInstructions.Items)
            {
                Instruction instruction = (Instruction)item.Tag;
                newPlant.Instructions.Add(instruction);

            }

            using (AppDbContext context = new())
            {
                UnitOfWorkRepository uow = new(context);
                uow.PlantRepository.Add(newPlant);
                uow.Complete();
            }
            MessageBox.Show("Your plant is saved!", "Saved");

            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            PlantWindow plantWindow = new();
            plantWindow.Show();
            Close();
        }
    }
}
