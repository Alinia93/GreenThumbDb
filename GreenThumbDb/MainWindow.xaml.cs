using GreenThumbDb.Managers;
using System.Windows;

namespace GreenThumbDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateSignInButton();


        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Password;
            if (UserManager.SignInUser(userName, password))
            {
                PlantWindow plantWindow = new();
                plantWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("User name or password is incorrect.");
                txtPassword.Password = "";
            }

        }

        private void txtUserName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            UpdateSignInButton();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UpdateSignInButton();
        }

        private void UpdateSignInButton()
        {
            bool hasPassword = !string.IsNullOrEmpty(txtPassword.Password);
            bool hasUserName = !string.IsNullOrEmpty(txtUserName.Text);

            btnSignIn.IsEnabled = hasPassword && hasUserName;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new();
            registerWindow.Show();
            Close();
        }
    }
}
