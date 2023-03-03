using System.Windows;
using System.Windows.Documents;


namespace exam
{
    public partial class TrafficErrorWindow : Window
    {
        TrafficViewer trafficException;
        DBSettings DB_Session21;
        public TrafficErrorWindow(TrafficViewer trafficException, DBSettings DB_Session21)
        {
            this.DB_Session21 = DB_Session21;
            this.trafficException = trafficException;
            InitializeComponent();
            
            titleTextBlock.Text = "No logout detected for your last login on " + trafficException.dateFormated + " at " + trafficException.enterFormatedTime;

        }

        private void Btn_Confim(object sender, RoutedEventArgs e)
        {
            var contextTraffic = DB_Session21.TrafficViewer.Find(trafficException.ID);
            contextTraffic.ExitCause = new TextRange(errorDescriptionTextBox.Document.ContentStart, errorDescriptionTextBox.Document.ContentEnd).Text;
            contextTraffic.CauseID = (bool)systemCrashRadio.IsChecked ? 1 : 2;
            DB_Session21.SaveChanges();
            this.Close();
        }
    }
}
