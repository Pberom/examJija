using System.Linq;
using System.Windows;
using exam.assets;

namespace exam
{
    public partial class MainWindow : Window //Главное окно авторизации компании
    {
        private DBSettings DB_Session21;
        int TryCounter = 0;

        public MainWindow()
        {
            DB_Session21 = DBSettings.getInstance();
            InitializeComponent();
        }

        private void Btn_Login(object sender, RoutedEventArgs e)
        {
            var hash = PasswordHasherHelper.hashToMD5(passwordField.Password);
            ErrorWindow errorWindow;
            try
            {
                var user = DB_Session21.Users.First((element) => element.Password.Trim() == hash && element.Email == loginField.Text.Trim());
                if (!user.Active)
                {
                    errorWindow = (new ErrorWindow("Ошибка авторизации", "Вы заблокированы, обратитесь к администратору.", false));
                    errorWindow.Owner = Window.GetWindow(this);
                    errorWindow.Show();
                }
                else
                {
                    if (user.Roles.Title == "Administrator")
                    {
                        AdminMenuWindow admin = new AdminMenuWindow();
                        admin.Show();
                    }
                    else
                    {
                        new UserMenuWindow(user).Show();
                    }
                    this.Close();
                }
            }
            catch
            {
                TryCounter++;
                if (TryCounter == 3)
                {
                    TryCounter = 0;
                    errorWindow = (new ErrorWindow("Ошибка авторизации", "10", true));
                }
                else
                {
                    errorWindow = (new ErrorWindow("Ошибка авторизации", "Введенные данные некорректны, повторите попытку.", false));
                }
                errorWindow.Owner = Window.GetWindow(this);
                errorWindow.ShowDialog();
            }
        }

        private void Btn_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
