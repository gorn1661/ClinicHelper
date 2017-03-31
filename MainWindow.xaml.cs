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

namespace DoctorsHelper
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string _database = "";
        string _name;
        string _surname;
        string _dateOfBirth;
        string _password;

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool checkDatabase(string _database, string _name, string _surname, string _dateOfBirth, string _password)
        {
            return false;
        }

        private void logInB_Click(object sender, RoutedEventArgs e)
        {
            _name = nameTB.Text;
            _surname = surnameTB.Text;
            _dateOfBirth = dateTB.Text;
            _password = passTB.Password;

            if (checkDatabase(_database, _name, _surname, _dateOfBirth, _password) == true)
            {

            }
            else
            {

            }
        }

        private void LogOut()
        {

        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (LogIn.IsVisible == false)
                LogIn.Visibility = Visibility.Visible;
            else
                LogIn.Visibility = Visibility.Hidden;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

}
