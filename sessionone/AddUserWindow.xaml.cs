using System;
using System.Linq;
using System.Windows;

namespace exam
{
    public partial class AddUserWindow : Window
    {
        DBSettings DB_Session21;
        public AddUserWindow()
        {
            DB_Session21 = DBSettings.getInstance();
            InitializeComponent();
            officeComboBox.ItemsSource = DB_Session21.Offices.ToList();
            officeComboBox.SelectedIndex = 0;
        }
        public int AgeTaker(DateTime Birthdate)
        {
            TimeSpan span = DateTime.Now - Birthdate;
            int years = (new DateTime(1, 1, 1) + span).Year - 1;
            return years;
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            ErrorWindow exceptionWindow = null;
            if (lastNameTextBox.Text.Trim().Length == 0)
            {
                exceptionWindow = new ErrorWindow("Error occured while adding", "Last name must be not empty", false);
            }
            if (firstNameTextBox.Text.Trim().Length == 0)
            {
                exceptionWindow = new ErrorWindow("Error occured while adding", "First name must be not empty", false);

            }
            if (passwordBox.Password.Trim().Length == 0)
            {
                exceptionWindow = new ErrorWindow("Error occured while adding", "Password must be not empty", false);

            }
            if (birthDayPicker.SelectedDate == null || AgeTaker(birthDayPicker.SelectedDate.Value) < 18)
            {
                exceptionWindow = new ErrorWindow("Error occured while adding", "Birthady date incorrect for adult person", false);

            }
            if (emailTextBox.Text.Trim().Length == 0)
            {
                exceptionWindow = new ErrorWindow("Error occured while adding", "Email must be not empty", false);


            }
            if (DB_Session21.Users.Where((element) => element.Email == emailTextBox.Text).Count() != 0)
            {
                exceptionWindow = new ErrorWindow("Error occured while adding", "Email addres already taken by another account", false);

            }
            if (exceptionWindow != null)
            {
                exceptionWindow.Owner = Window.GetWindow(this);
                exceptionWindow.ShowDialog();
                return;
            }

            var currentUser = new Users();
            currentUser.Email = emailTextBox.Text;
            currentUser.Lastname = lastNameTextBox.Text;
            currentUser.Firstname = firstNameTextBox.Text;
            currentUser.Birthdate = DateTime.Parse(birthDayPicker.Text);
            currentUser.Password = PasswordHasherHelper.hashToMD5(passwordBox.Password);
            currentUser.RoleID = 2;
            currentUser.Active = true;
            currentUser.Offices = officeComboBox.SelectedItem as Offices;
            DB_Session21.Users.Add(currentUser);
            DB_Session21.SaveChanges();
            this.Close();
        }

        private void Btn_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
