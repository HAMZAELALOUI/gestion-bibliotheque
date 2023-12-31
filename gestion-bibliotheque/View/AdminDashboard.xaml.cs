using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace gestion_bibliotheque.View
{
    /// <summary>
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {
        public AdminDashboard()
        {
            InitializeComponent();

        }

        private bool IsMaximize = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximize)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximize = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximize = true;
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

      

        private void show_Adherents(object sender, RoutedEventArgs e)
        {
            dynamicContent.Content = new Adherents();

        }
        private void show_reservations(object sender, RoutedEventArgs e)
        {
            dynamicContent.Content = new Reservation();

        }
        private void show_books(object sender, RoutedEventArgs e)
        {
            dynamicContent.Content = new Books();

        }
        private void show_employees(object sender, RoutedEventArgs e)
        {
            dynamicContent.Content = new Employees();

        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public Brush BgColor { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

