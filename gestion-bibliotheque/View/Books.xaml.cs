
using gestion_bibliotheque.DataModel;
using gestion_bibliotheque.View.InputForm;
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
    /// Interaction logic for Books.xaml
    /// </summary>
    public partial class Books : UserControl
    {

        static Books()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private ObservableCollection<Livre> LivresCollection;

        public Books()
        {

            InitializeComponent();
            this.LoadData();
        }

        private void membersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }




        private void Delete(object sender, RoutedEventArgs e)
        {
            
           LivreDbHelper livreDbHelper = new LivreDbHelper();
            int LivreIdToDelete = GetSelectedLivreId(); // Implement this method based on your UI

            if (LivreIdToDelete > 0)
            {
                livreDbHelper.DeleteLivreId(LivreIdToDelete);
                // Assuming you create an instance of your ViewModel here
               LivreViewModel viewModel = new LivreViewModel();
                DataContext = viewModel;
                // Set the initial value
                viewModel.NmberOfLivre= LivreDbHelper.GetNumberOfLivres();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select an adherent to delete.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public int GetSelectedLivreId()
        {
            // Check if any item is selected
            if (LivreDataGrid.SelectedItem != null)
            {
                // Assuming Adherent has an LivreID property
                if (LivreDataGrid.SelectedItem is Livre selectedLivre)
                {
                    return selectedLivre.LivreID;
                }
            }

            return 0; // Return 0 or another value to indicate no selection
        }
        private void UpdateLivre(object sender, RoutedEventArgs e) { }

        private void ShowLivre(object sender,RoutedEventArgs e)
        {
            LivreInputFormAdd livreInputFormAdd = new LivreInputFormAdd();
            livreInputFormAdd.ShowDialog();
        }


        private void textBoxFilter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void LoadData()
        {
            LivreDbHelper dbHelper = new LivreDbHelper();
            List<Livre> livres = dbHelper.GetLivres();
            LivresCollection = new ObservableCollection<Livre>(livres);
            LivreDataGrid.ItemsSource = livres;

        }
        private void ExportToExcel(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create a new ExcelPackage
                using (var package = new ExcelPackage())
                {
                    // Add a new worksheet to the package
                    var worksheet = package.Workbook.Worksheets.Add("LivresData");

                    // Write header row
                    for (int i = 1; i <= LivreDataGrid.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = LivreDataGrid.Columns[i - 1].Header;
                    }

                    // Write data rows
                    var livres = (List<Livre>)LivreDataGrid.ItemsSource;
                    for (int row = 0; row < livres.Count; row++)
                    {
                        for (int col = 1; col <= LivreDataGrid.Columns.Count; col++)
                        {
                            var column = LivreDataGrid.Columns[col - 1];

                            if (column is DataGridBoundColumn)
                            {
                                var binding = (column as DataGridBoundColumn)?.Binding as System.Windows.Data.Binding;

                                if (binding != null)
                                {
                                    var property = binding?.Path?.Path;

                                    if (property != null)
                                    {
                                        var value = livres[row]?.GetType()?.GetProperty(property)?.GetValue(livres[row], null);

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
                        FileName = "LivresDataExport"
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
