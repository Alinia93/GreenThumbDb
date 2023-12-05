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
    }
}
