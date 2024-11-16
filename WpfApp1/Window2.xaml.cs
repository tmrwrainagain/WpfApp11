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
    /// Логика взаимодействия для Wi
    /// ndow2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string _pass = "12345678";
        private string _inputpass = ""; 
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _inputpass = pswdTxt.Password;
            if (_inputpass == _pass)
            {
                txtDisplay.Text = "Welcome!";

            }
            else
            {
                MessageBox.Show("Wrong pass!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
