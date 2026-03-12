using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TamaGagyi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitButtonEvent(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void UserPasswordInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void RegButtonClick(object sender, RoutedEventArgs e)
        {
            RegWindow registerWindow = new RegWindow();

            registerWindow.Show();
            this.Close();
        }

        private void UserNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserNameInput_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}