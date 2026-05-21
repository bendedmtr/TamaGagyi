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
    /// Interaction logic for SelectedAnimal.xaml
    /// </summary>
    public partial class SelectedAnimal : Window
    {
        private string selectedAnimal;
        public readonly List<(string animalName, int pictureCount)> animalInfo;
        
        


        public SelectedAnimal(string animal)
        {
            InitializeComponent();
            selectedAnimal = animal;
            MessageBox.Show($"Selected animal: {selectedAnimal}");

            

            if (selectedAnimal.Trim() == "cage")
            {
                backgroundImage.ImageSource = new BitmapImage(
    new Uri("pack://application:,,,/assets/img/background_cage.png", UriKind.Absolute));
            }
            else if (selectedAnimal.Trim() == "aquarium")
            {
                backgroundImage.ImageSource = new BitmapImage(
    new Uri("pack://application:,,,/assets/img/background_aquarium.png", UriKind.Absolute));
            }
            else if (selectedAnimal.Trim() == "terrarium")
            {
                backgroundImage.ImageSource = new BitmapImage(
    new Uri("pack://application:,,,/assets/img/background_terrarium.png", UriKind.Absolute));
            }
            else
            {
                backgroundImage.ImageSource = new BitmapImage(
    new Uri("pack://application:,,,/assets/img/background.png", UriKind.Absolute));
            }
        }
        public SelectedAnimal()
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
