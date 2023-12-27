using ControlzEx.Standard;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace gestion_bibliotheque.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {

        public LoginView()
        {
            InitializeComponent();
           

        }
        private void Window_MouseDown(object sender,MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void pswd_PasswordChanged(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnMinimize_Click(Object sender ,RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text;
            string password = pswd.Password;

            if (IsValidUser(username, password))
            {
                // Open a new window (replace 'MainWindow' with the name of your target window)
                AdminDashboard adminDashboard = new AdminDashboard();
                this.Close();
                adminDashboard.Show();
            } else
            {
                // Failed login, show error message or perform other actions
                MessageBox.Show("Invalid username or password!");
            }
        }
        private bool IsValidUser(string Nom, string MotDePasse)
        {
            string connectionString = $"server=localhost;database=biblio;uid=root;password=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM Administrateurs WHERE Nom = @username AND MotDePasse = @password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", Nom);
                command.Parameters.AddWithValue("@password", MotDePasse);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        private void txtUser_TextChanged(object sender, object e)
        {

        }
    }
}
