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
    /// Логика взаимодействия для Stack_panale.xaml
    /// </summary>
    public partial class Stack_panale : Window
    {

        public Stack_panale()
        {
            InitializeComponent();

        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tree = (TreeViewItem)sender;
            MessageBox.Show("Вы выбрали: " + tree.Header.ToString(), "Выбор *", MessageBoxButton.OK, MessageBoxImage.Hand);

        }

        private void Date_picker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker date = (DatePicker)sender;
            MessageBox.Show("В " + date.SelectedDate.Value.ToShortDateString() + " А");
        }

        public void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            Calendar cal = (Calendar)sender;
            string now_data = cal.SelectedDate.Value.ToShortDateString();
            sent(now_data);
            //MessageBox.Show("Концерт лил пипа " + cal.SelectedDate.Value.ToShortDateString() + " недоступен(((");


        }
        List<string> data = new List<string>();
        List<string> text = new List<string>();
        int a = 0;
        int vrem_a;

        bool b = true;
        public void sent(string now_data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == now_data)
                {
                    text_box.Text = text[i];
                    vrem_a = i;
                    b = false;
                }
            }
            if (b == true)
            {
                data.Add(now_data);
                text.Add(input_box.Text);
                input_box.Text = "";
                text_box.Text = text[a];
                a++;
            }
            else
            {
                b = true;
            }
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            text[vrem_a] = input_box.Text;
            text_box.Text = text[vrem_a];
            input_box.Text = "";
        }
    }
}
