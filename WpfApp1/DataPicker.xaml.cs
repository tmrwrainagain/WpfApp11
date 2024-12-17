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
    public partial class DataPicker : Window
    {
        public DataPicker()
        {
            InitializeComponent();
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            
            string name = NameTextBox.Text;
            string position = PositionTextBox.Text;
            DateTime? birthDate = BirthDatePicker.SelectedDate;

            
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(position) || birthDate == null)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            string employeeInfo = $"Имя: {name}, Должность: {position}, Дата рождения: {birthDate.Value.ToShortDateString()}";

            
            EmployeeListBox.Items.Add(employeeInfo);

            
            NameTextBox.Clear();
            PositionTextBox.Clear();
            BirthDatePicker.SelectedDate = null;
        }
    }
}
