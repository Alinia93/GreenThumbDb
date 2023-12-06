using GreenThumbDb.Managers;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumbDb
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        public RegisterWindow()
        {
            InitializeComponent();
            UpdateRegisterButton();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password != txtComfirmPassword.Password)
            {
                MessageBox.Show("Your password doesn't match with \"Comfirm password\"");
                txtComfirmPassword.Password = "";
                return;
            }
            if (txtPassword.Password.Length < 4)
            {
                MessageBox.Show("Your password must be at least 3 signs");
                return;
            }

            if (UserManager.CheckUserName(txtUserName.Text))
            {
                UserManager.AddUser(txtUserName.Text, txtPassword.Password);

                MessageBox.Show("You are now registred! ENJOY", "Congratulations");

                OpenMainWindow();
            }
            else
            {
                MessageBox.Show("Your user name is already occupied. Try again!", "Opps!");

            }




        }

        public void OpenMainWindow()
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }



        public void UpdateRegisterButton()
        {
            bool isUserName = !string.IsNullOrEmpty(txtUserName.Text);
            bool isPassword = !string.IsNullOrEmpty(txtPassword.Password);
            bool isComfirmPassword = !string.IsNullOrEmpty(txtComfirmPassword.Password);

            btnRegister.IsEnabled = isUserName && isPassword && isComfirmPassword;
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateRegisterButton();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UpdateRegisterButton();
        }

        private void txtComfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UpdateRegisterButton();
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            OpenMainWindow();
        }
    }
}
