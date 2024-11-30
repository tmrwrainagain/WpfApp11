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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Combobox.xaml
    /// </summary>
    public partial class Combobox : Window
    {
        public Combobox()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            imgg.Source = new BitmapImage(new Uri("C:/Users/tmrwrainagain/source/repos/WpfApp1/WpfApp1/Image/1.jpg"));

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            imgg.Source = new BitmapImage(new Uri("C:/Users/tmrwrainagain/source/repos/WpfApp1/WpfApp1/Image/2.jpg"));
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            imgg.Source = new BitmapImage(new Uri("C:/Users/tmrwrainagain/source/repos/WpfApp1/WpfApp1/Image/3.jpg"));
        }
    }
}
