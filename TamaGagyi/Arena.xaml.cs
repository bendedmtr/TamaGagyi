using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TamaGagyi
{
    /// <summary>
    /// Interaction logic for Arena.xaml
    /// </summary>
    public partial class Arena : Window
    {
        public Arena()
        {
            InitializeComponent();
        }

        private void exitButtonEvent(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BackButtonEvent(object sender, RoutedEventArgs e)
        {
            MainMenu mainWindow = new MainMenu();
            mainWindow.Show();
            this.Close();
        }
    }
}
