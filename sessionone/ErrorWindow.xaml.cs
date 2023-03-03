using System;
using System.Windows;
using System.Windows.Threading;

namespace exam
{
    public partial class ErrorWindow : Window
    {
        String subtitle;
        bool isCountDown;
        DispatcherTimer dispatherTimer;
        TimeSpan timeSpan;

        public ErrorWindow(String title, String subtitle, bool isCountDown)
        {
            this.subtitle = subtitle;
            this.isCountDown = isCountDown;
        
            InitializeComponent();
            this.titleText.Text = title;
            if (!isCountDown)
            {
               this.desriptionText.Text = subtitle;
            }
            if (isCountDown)
            {
                this.closeButton.IsEnabled = false;
                InitTimerCheck(int.Parse(subtitle));
            }
        }
        
        private void InitTimerCheck(int defaultValue)
        {
            timeSpan = TimeSpan.FromSeconds(defaultValue);
            desriptionText.Text = "Превышено колличество попыток входа. \n" +
            "Времени осталось: " + timeSpan.ToString("c");
            dispatherTimer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                desriptionText.Text = "Превышено колличество попыток входа. \n" +
                "Времени осталось: " + timeSpan.ToString("c");
                if (timeSpan == TimeSpan.Zero)
                {
                    dispatherTimer.Stop();
                    this.closeButton.IsEnabled = true;
                    this.Close();
                }                
                timeSpan = timeSpan.Add(TimeSpan.FromSeconds(-1));
            }, 
            Application.Current.Dispatcher);

            dispatherTimer.Start();
        }

        private void Btn_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
