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
        private Button _selectedAnimalButton;

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
            if (sender is not Button button)
                return;

            // FIRST CLICK -> only show MessageBox
            if (_selectedAnimalButton != button)
            {
                _selectedAnimalButton = button;
                if (button.Content is TextBlock tb)
                {
                    animalNameLabel.Content = tb.Text;
                }
                MessageBox.Show($"{button.Tag} állat kiválasztva");

                return;
            }

            // SECOND CLICK -> run original function
            string tagValue = button.Tag?.ToString();

            var window = new SelectedAnimal(tagValue);
            window.Show();
            this.Close();
        }

        private void UserNameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void battleButtonEvent(object sender, RoutedEventArgs e)
        {
            Arena arena = new Arena();
            arena.Show();
            this.Close();
        }
    }
}
