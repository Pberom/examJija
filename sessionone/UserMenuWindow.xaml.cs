using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using System.ComponentModel;
namespace exam
{
    public partial class UserMenuWindow : Window
    {
        private DBSettings DB_Session21;

        DispatcherTimer _timer;
        TimeSpan _time;
        TrafficViewer currentTraffic;
        public UserMenuWindow(Users user)
        {
            currentTraffic = new TrafficViewer();
            currentTraffic.EnterTime = DateTime.Now;
            currentTraffic.UserID = user.ID;
            DB_Session21 = DBSettings.getInstance();
            
            InitializeComponent();
            helloTextBlock.Text = "Hi " + user.Lastname + ", Welcome to AMONIC Airlaince";
            var loadedEvents = user.TrafficViewer.ToList();
            foreach (var errorEvent in loadedEvents.Where((element) => element.ExitTime == null && element.ExitCauses == null).ToList())
            {
                var exceptionWindow = new TrafficErrorWindow(errorEvent, DB_Session21);
                exceptionWindow.ShowDialog();
            }
            DB_Session21.TrafficViewer.Add(currentTraffic);
            DB_Session21.SaveChangesAsync();
            double spendedSeconds = 0;
            foreach(var errorEvent in loadedEvents.Where((element) => DateTime.Now.Subtract(element.EnterTime.Date).Days <= 30))
            {
                spendedSeconds += errorEvent.timeSpendDuration.TotalSeconds;
            }
            initTimer((int)spendedSeconds);
            Closing += OnWindowClosing;
            logGrid.ItemsSource = loadedEvents;
        }
        private void initTimer(int startTime)
        {
            _time = TimeSpan.FromSeconds(0);
            tickTextBlock.Text = "Time spent on system: "  + _time.ToString("c");
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tickTextBlock.Text = "Time spent on system: " + _time.ToString("c");
                _time = _time.Add(TimeSpan.FromSeconds(+1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            currentTraffic.ExitTime = DateTime.Now;
            DB_Session21.SaveChangesAsync();
        }

        private void Btn_Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
