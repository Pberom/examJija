using System.Linq;
using System.Windows;

namespace exam
{
    public partial class ChangeUserWindow : Window
    {
        DBSettings DB_Session21;
        Users currentUser;

        public ChangeUserWindow(Users currentUser)
        {
            DB_Session21 = DBSettings.getInstance();
            this.currentUser = currentUser;
            InitializeComponent();
            lastNameTextBox.Text = currentUser.Lastname;
            firstNameTextBox.Text = currentUser.Firstname;
            emailTextBox.Text = currentUser.Email;
            officeComboBox.ItemsSource = DB_Session21.Offices.ToList();
            officeComboBox.SelectedItem = currentUser.Offices;

            if (currentUser.RoleID == 1)
            {
                radioAdmin.IsChecked = true;
            }
            else
            {
                radioUser.IsChecked = true;
            }
        }

        private void Btn_Apply(object sender, RoutedEventArgs e)
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
            currentUser.Lastname = lastNameTextBox.Text;
            currentUser.Firstname = firstNameTextBox.Text;
            currentUser.Email = emailTextBox.Text;
            currentUser.Offices = officeComboBox.SelectedItem as Offices;
            if ((bool)radioAdmin.IsChecked)
            {
                currentUser.RoleID = 1;
            }
            else
            {
                currentUser.RoleID = 2;
            }
            DB_Session21.SaveChanges();
            this.Close();
        }

        private void Btn_Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
