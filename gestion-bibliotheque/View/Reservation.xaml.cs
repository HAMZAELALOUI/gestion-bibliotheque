using gestion_bibliotheque.DataModel;
using gestion_bibliotheque.ViewModel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// Interaction logic for Reservation.xaml
    /// </summary>
    public partial class Reservation : UserControl
    {

        static Reservation()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        ReservationDbHelper reservationDbHelper = new ReservationDbHelper();
        private ObservableCollection<DataModel.Reservation> resevationCollection;
        public Reservation()
        {
            InitializeComponent();

            LoadData();
        }


        public void LoadData()
        {
            List<DataModel.Reservation> reservations = reservationDbHelper.GetReservations();
            resevationCollection = new ObservableCollection<DataModel.Reservation>(reservations);
            ReservationsDataGrid.ItemsSource = reservations;

        }

        public void membersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        public void editeReservation(object sender, RoutedEventArgs e) { }


        private void Delete(object sender, RoutedEventArgs e)
        {
            ReservationDbHelper reservationDbHelper = new ReservationDbHelper();
            int reservationIdToDelete = GetSelectedReservationId(); // Implement this method based on your UI

            if (reservationIdToDelete > 0)
            {
                reservationDbHelper.DeleteReservation(reservationIdToDelete);
                ReservationViewModel reservationViewModel = new ReservationViewModel();
                DataContext = reservationViewModel;
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select reservation to delete.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public int GetSelectedReservationId()
        {
            // Check if any item is selected
            if (ReservationsDataGrid.SelectedItem != null)
            {
                // Assuming Adherent has an AdherentID property
                if (ReservationsDataGrid.SelectedItem is DataModel.Reservation selectedReservation)
                {
                    return selectedReservation.ReservationID;
                }
            }

            return 0; // Return 0 or another value to indicate no selection
        }




        private void OnTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // Handle the Enter key press
                PerformSearch();
            }
        }

        private void PerformSearch()
        {
            // Get the text from the TextBox and use it to search in the database
            string searchText = textBoxSearch.Text;

            // Call your database search function with the searchText
            ReservationDbHelper dbHelper = new ReservationDbHelper();
            List<DataModel.Reservation> searchResults = dbHelper.SearchReservations(searchText);
            UpdateDataGrid(searchResults);

        }
        private void UpdateDataGrid(List<DataModel.Reservation> searchResults)
        {
            // Update the DataGrid with the search results
            ReservationsDataGrid.ItemsSource = searchResults;
        }


        private void ExportToExcel(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create a new ExcelPackage
                using (var package = new ExcelPackage())
                {
                    // Add a new worksheet to the package
                    var worksheet = package.Workbook.Worksheets.Add("ResrvationData");

                    // Write header row
                    for (int i = 1; i <= ReservationsDataGrid.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = ReservationsDataGrid.Columns[i - 1].Header;
                    }

                    // Write data rows
                    var Reservations = (List<DataModel.Reservation>)ReservationsDataGrid.ItemsSource;

                    for (int row = 0; row < Reservations.Count; row++)
                    {
                        for (int col = 1; col <= ReservationsDataGrid.Columns.Count; col++)
                        {
                            var column = ReservationsDataGrid.Columns[col - 1];

                            if (column is DataGridBoundColumn)
                            {
                                var binding = (column as DataGridBoundColumn)?.Binding as System.Windows.Data.Binding;

                                if (binding != null)
                                {
                                    var property = binding?.Path?.Path;

                                    if (property != null)
                                    {
                                        var value = Reservations[row]?.GetType()?.GetProperty(property)?.GetValue(Reservations[row], null);

                                        worksheet.Cells[row + 2, col].Value = value;
                                    }
                                }
                            }
                        }
                    }


                    // Save the Excel package to a file
                    var saveFileDialog = new Microsoft.Win32.SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                        Title = "Export Livres Data",
                        FileName = "ReservationDataExport"
                    };

                    if (saveFileDialog.ShowDialog() == true)
                    {
                        package.SaveAs(new FileInfo(saveFileDialog.FileName));
                        MessageBox.Show("Data exported successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }

    
    }
}