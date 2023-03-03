using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace exam.assets
{
    public partial class AdminMenuWindow : Window
    {
        private DBSettings DB_Session21;

        public AdminMenuWindow()
        {
            DB_Session21 = DBSettings.getInstance();
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            var addMenu = new AddUserWindow();
            addMenu.Owner = Window.GetWindow(this);
            addMenu.Closing += ChangeMenu_Closing;
            addMenu.ShowDialog();
        }


        private void usersGrid_Loaded(object sender, RoutedEventArgs e)
        {
            InitTable();
        }
        void InitTable()
        {
            List<ModelsShow> users = new List<ModelsShow>();
            foreach (var user in DB_Session21.Users.ToList())
            {
                users.Add(new ModelsShow(user.ID, user.getAge(), user.Email, user.Firstname, user.Lastname, user.Offices, user.Active, user.Roles));
            }
            usersGrid.ItemsSource = users;
        }

        private void comboBoxOffices_Loaded(object sender, RoutedEventArgs e)
        {
            var currentComboBox = (sender as ComboBox);
            var actualOffices = DB_Session21.Offices.ToList();
            var mockOffice = new Offices();
            mockOffice.Title = "All offices";
            actualOffices.Add(mockOffice);
            currentComboBox.ItemsSource = actualOffices;
            currentComboBox.SelectedItem = mockOffice;
        }

        void changeSelection()
        {
            var pickedOffice = comboBoxOffices.SelectedItem as Offices;
            List<ModelsShow> users = new List<ModelsShow>();

            if (pickedOffice.Title == "All offices")
            {
                foreach (var user in DB_Session21.Users.ToList())
                {
                    users.Add(
                        new ModelsShow(
                        user.ID,
                        user.getAge(),
                        user.Email, 
                        user.Firstname, 
                        user.Lastname,
                        user.Offices,
                        user.Active, 
                        user.Roles));
                }
            }
            else
            {
                foreach (var user in DB_Session21.Users.Where((element) => element.OfficeID == pickedOffice.ID).ToList())
                {
                    users.Add(
                        new ModelsShow(
                        user.ID, 
                        user.getAge(), 
                        user.Email, 
                        user.Firstname, 
                        user.Lastname, 
                        user.Offices, 
                        user.Active, 
                        user.Roles));
                }
            }
            
            usersGrid.ItemsSource = users;
        }

        private void comboBoxOffices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            changeSelection();
        }

        private void ChangeMenu_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            changeSelection();
        }

        private void Btn_ChangeRole(object sender, RoutedEventArgs e)
        {
            var loadedUp = usersGrid.SelectedItem as ModelsShow;
            if (loadedUp == null)
                return;
            var selectedUser = DB_Session21.Users.First((element) => element.ID == loadedUp.id);
            var changeMenu = new ChangeUserWindow(selectedUser);
            changeMenu.Owner = Window.GetWindow(this);
            changeMenu.Closing += ChangeMenu_Closing;
            changeMenu.ShowDialog();
        }

        private void Btn_EbableDisableLogin(object sender, RoutedEventArgs e)
        {
            var loadedUp = usersGrid.SelectedItem as ModelsShow;
            DB_Session21.Users.First((element) => element.ID == loadedUp.id).Active = !loadedUp.isActive;
            DB_Session21.SaveChanges();
            changeSelection();
        }
    }
}
