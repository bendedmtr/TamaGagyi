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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {

        public MainMenu()
        {
            InitializeComponent();
        }
        private void exitButtonEvent(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AnimalSelectedClick(object sender, RoutedEventArgs e)
        {
            Button animalButton = sender as Button;
            MessageBox.Show($"{animalButton.Tag} állat kiválasztva");
            if (sender is Button button)
            {
                string tagValue = button.Tag?.ToString();

                var window = new SelectedAnimal(tagValue);
                window.Show();
                this.Close();
            }
        }

        private void UserNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
