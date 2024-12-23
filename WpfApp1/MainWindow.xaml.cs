﻿
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            { Filter = "Image Files| *.jpg; *.jpeg; *.jpg;" };
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage =
                new BitmapImage(new Uri(openFileDialog.FileName));
                DisplayImageForm.Source = bitmapImage;
            }
            else
            {
                MessageBox.Show("Не выбрана картинка");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Combobox sh = new Combobox();
            sh.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 windowz = new Window3();
            windowz.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Stack_panale stack = new Stack_panale();
            stack.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SimpleTimerApp SimpleTimerWindow = new SimpleTimerApp();
            SimpleTimerWindow.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DataPicker DataPickerWindow = new DataPicker();
            DataPickerWindow.Show();
            this.Close();
        }
    }

}
