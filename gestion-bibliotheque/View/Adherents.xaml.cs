using gestion_bibliotheque.DataModel;
using gestion_bibliotheque.View.InputForm;
using gestion_bibliotheque.ViewModel;
using MahApps.Metro.Controls;
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
    /// Interaction logic for Adherents.xaml
    /// </summary>
    public partial class Adherents : UserControl
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private ObservableCollection<Adherent> adherentsCollection;
        public Adherents()
        {
            InitializeComponent();

            // Assuming you create an instance of your ViewModel here
            AherentsViewModel aherentsViewModel = new AherentsViewModel();
            DataContext = aherentsViewModel;
            // Set the initial value (replace this with your actual logic)
            aherentsViewModel.NumberOfAdherents = DatabaseHelper.GetNumberOfAdherents();
            LoadData();

        }

        public void LoadData()
        {
            List<Adherent> adherents = dbHelper.GetAdherents();
            adherentsCollection = new ObservableCollection<Adherent>(adherents);
            adherentsDataGrid.ItemsSource = adherents;

        }


        private void membersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void adherent_form(object sender, RoutedEventArgs e)
        {

            // Open a new window (replace 'MainWindow' with the name of your target window)
            InputFormAdherentAdd inputFormAdherentAdd = new InputFormAdherentAdd();
            inputFormAdherentAdd.ShowDialog();  
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            /* AherentConfirmationDialog aherentConfirmationDialog = new AherentConfirmationDialog();
             aherentConfirmationDialog.Show();*/
               DatabaseHelper dbHelper = new DatabaseHelper();
            int adherentIdToDelete = GetSelectedAdherentId(); // Implement this method based on your UI

            if (adherentIdToDelete > 0) {
                dbHelper.DeleteAdherentById(adherentIdToDelete);
                // Assuming you create an instance of your ViewModel here
                AherentsViewModel aherentsViewModel = new AherentsViewModel();
                DataContext = aherentsViewModel;
                // Set the initial value
                aherentsViewModel.NumberOfAdherents = DatabaseHelper.GetNumberOfAdherents();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select an adherent to delete.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public int GetSelectedAdherentId()
        {
            // Check if any item is selected
            if (adherentsDataGrid.SelectedItem != null)
            {
                // Assuming Adherent has an AdherentID property
                if (adherentsDataGrid.SelectedItem is Adherent selectedAdherent)
                {
                    return selectedAdherent.AdherentID;
                }
            }

            return 0; // Return 0 or another value to indicate no selection
        }

    }
}
