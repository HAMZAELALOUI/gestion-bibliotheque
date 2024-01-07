using gestion_bibliotheque.DataModel;
using gestion_bibliotheque.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace gestion_bibliotheque.View
{
    /// <summary>
    /// Interaction logic for Employees.xaml
    /// </summary>
    /// 


    
    public partial class Employees : UserControl
    {

        private EmployeHelperDb employeHelper = new EmployeHelperDb();
        private ObservableCollection<Employe> employeCollection;

        public Employees()
        {
            InitializeComponent();
            LoadData();
          
        }

        public void LoadData()
        {
            List<Employe> employe = employeHelper.GetEmploye();
            employeCollection = new ObservableCollection<Employe>(employe);
            employeeDataGrid.ItemsSource = employe;

        }


        private void membersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void employees_form(object sender, RoutedEventArgs e)
        {
            // Open a new window (replace 'MainWindow' with the name of your target window)
           AjouterEmployee ajouterEmployee = new AjouterEmployee();
            ajouterEmployee.ShowDialog();
        }
        private void closeFormUpdate(object sender, RoutedEventArgs e)
        {
            // Open a new window (replace 'MainWindow' with the name of your target window)
            /*AdherentFormUpdate adherentFormUpdate = new AdherentFormUpdate();

            adherentFormUpdate.ShowDialog();*/
        }
        private void Delete(object sender, RoutedEventArgs e)
        {

           
            int employeIdToDelete = GetSelectedEmployeID(); // Implement this method based on your UI

            if (employeIdToDelete > 0)
            {
                employeHelper.DeleteEmployeById(employeIdToDelete);
                // Assuming you create an instance of your ViewModel here
                EmployeViewModel employeViewModel = new EmployeViewModel();
                DataContext = employeViewModel;
                // Set the initial value
                employeViewModel.NumberOfEmployees = EmployeHelperDb.GetNumberOfEmployees();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select an adherent to delete.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        public int GetSelectedEmployeID()
        {
            // Check if any item is selected
            if (employeeDataGrid.SelectedItem != null)
            {
                // Assuming Adherent has an AdherentID property
                if (employeeDataGrid.SelectedItem is Employe selectedEmploye)
                {
                    return selectedEmploye.EmployeID;
                }
            }

            return 0; // Return 0 or another value to indicate no selection
        }
    }
}

