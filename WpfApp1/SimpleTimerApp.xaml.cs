using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp1
{
    public partial class SimpleTimerApp : Window
    {
        private DispatcherTimer timer; 
        private int remainingMinutes;  

        public SimpleTimerApp() 
        {
            InitializeComponent();

            remainingMinutes = 60;

            
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(5); 
            timer.Tick += Timer_Tick; 

            StartTimer();
        }

        private void StartTimer()
        {
            UpdateText();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingMinutes -= 5; 

            if (remainingMinutes > 0)
                UpdateText(); 
            else
            {
                timer.Stop(); 
                TimerText.Text = "Занятие завершено";
            }
        }

        private void UpdateText()
        {
            TimerText.Text = $"До конца занятия осталось: {remainingMinutes} минут";
        }
    }
}
