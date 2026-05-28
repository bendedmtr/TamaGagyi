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
        private Brush _defaultButtonBackground;

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

            // Save default background once
            if (_defaultButtonBackground == null)
                _defaultButtonBackground = button.Background;

            // FIRST CLICK on a different button
            if (_selectedAnimalButton != button)
            {
                // Reset previous button color
                if (_selectedAnimalButton != null)
                {
                    _selectedAnimalButton.Background = _defaultButtonBackground;
                }

                // Store new selected button
                _selectedAnimalButton = button;

                // Change current button color
                button.Background = (SolidColorBrush)new BrushConverter()
                    .ConvertFrom("#96887a");

                // Update label
                if (button.Content is Image img)
                {
                    animalNameLabel.Content = img.Tag;
                }

                return;
            }

            // SECOND CLICK on same button
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
