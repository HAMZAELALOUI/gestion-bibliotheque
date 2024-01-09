using gestion_bibliotheque.DataModel;
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
using System.Windows.Shapes;

namespace gestion_bibliotheque.View.InputForm
{
    /// <summary>
    /// Interaction logic for InputUpdateLivreForm.xaml
    /// </summary>
    public partial class InputUpdateLivreForm : Window
    {

        private ObservableCollection<Categorie> categoriesCollection;

        public InputUpdateLivreForm()
        {
            InitializeComponent();
            this.Window_Loaded();
            this.DataContext = this;

        }



        private void Window_Loaded()
        {
            CategoriesHelperDB categoriesHelperDB = new CategoriesHelperDB();
            List<Categorie> categories = categoriesHelperDB.GetCategories();

            categoriesCollection = new ObservableCollection<Categorie>(categories);
            txtcategories.ItemsSource = categoriesCollection;
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

        private void closeForm(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnAjouterButtonClick(object sender, RoutedEventArgs e)
        {


            DateTime releaseDate = txtPublication.SelectedDate ?? DateTime.Now;
            double prix = double.Parse(txtPrix.Text);
            int categorieID = txtcategories.SelectedItemId;
            // Cast to int
            bool estDisponible = IsAvailable;

            MessageBox.Show(categorieID.ToString());

            // Call the InsertLivreData method from LivreDbHelper
            LivreDbHelper dbHelper = new LivreDbHelper();
            dbHelper.InsertLivreData(txtTitre.Text, txtAuteur.Text, categorieID, estDisponible, releaseDate, prix, txtDescription.Text);
        }



        public bool IsAvailable
        {
            get
            {
                return Equals(txtDisponiblite.SelectedValue, "yes");
            }
            set
            {
                txtDisponiblite.SelectedValue = value ? "yes" : "no";
            }
        }

        private void OnCategoryCustomSelectionChanged(object sender, RoutedEventArgs e)
        {



        }


    }
}

