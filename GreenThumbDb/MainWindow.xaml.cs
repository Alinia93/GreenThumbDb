using GreenThumbDb.DataBase;
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

            using (AppDbContext context = new()) ;

        }
    }
}
