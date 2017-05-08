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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DoctorsHelper
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string _host = "localhost";
        string _user = "root";
        string _pass = "mikolaj";
        string _database = "clinic";
        string _connectionString;

        string _name;
        string _surname;
        string _dateOfBirth;
        string _password;

        
        public MainWindow()
        {
            InitializeComponent();
            if(checkDatabase(_database, _name, _surname, _dateOfBirth, _password) == true){
                
            }
        }

        private bool checkDatabase(string _database, string _name, string _surname, string _dateOfBirth, string _password)
        {
            _connectionString = "SERVER=" + _host + ";DATABASE=" + _database + ";UID=" + _user + ";PASSWORD=" + _pass + ";";
            try{
                MySqlConnection connection = new MySqlConnection(_connectionString);
                connection.Open();
                connection.Close();
                return true;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
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
