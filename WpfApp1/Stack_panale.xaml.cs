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
            string selected_data = cal.SelectedDate.Value.ToShortDateString();
            send(selected_data);
        


        }
        List<string> data = new List<string>();
        List<string> note = new List<string>();
        int a = 0;
        int temp;

        bool b = true;
        public void send(string selected_data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == selected_data)
                {
                    NoteBox.Text = note[i];
                    temp = i;
                    b = false;
                }
            }
            if (b == true)
            {
                data.Add(selected_data);
                note.Add(InputNote.Text);
                InputNote.Text = "";
                NoteBox.Text = note[a];
                a++;
            }
            else
            {
                b = true;
            }
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            note[temp] = InputNote.Text;
            NoteBox.Text = note[temp];
            InputNote.Text = "";
        }
    }
}
