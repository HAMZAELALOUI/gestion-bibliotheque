using gestion_bibliotheque.DataModel;
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
    /// Interaction logic for UpdateEmployeeForm.xaml
    /// </summary>
    public partial class UpdateEmployeeForm : Window
    {
        public int SelectedID { get; }

        public UpdateEmployeeForm(int selectedID)
        {
            InitializeComponent();
            this.SelectedID = selectedID;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void close_form(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Modifier(object sender, RoutedEventArgs e)
        {
            EmployeHelperDb employeHelperDb = new EmployeHelperDb();
            try
            {
                // Collect data from input fields
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string role = txtMetier.Text;
                string autresDetailsEmploye = txtDescription.Text;

                // Use the SelectedID passed through the constructor
                int employeeId = SelectedID;

                // Update employe data in the database
                employeHelperDb.UpdateEmploye(employeeId, nom, prenom, role, autresDetailsEmploye);

                // Optionally, show a success message
                MessageBox.Show("Employe Modifie avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

                Employees employees=new Employees();
                employees.LoadData();

                // Close the window or perform other actions as needed
                Close();
            }
            catch (Exception ex)
            {
                // Handle the exception, e.g., show an error message
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.Close();
        }





    }
}
