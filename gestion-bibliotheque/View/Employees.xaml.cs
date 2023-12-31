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
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098AD"), Name = "John Doe", Position = "Coach", Email = "john.doe@gmail.com", Phone = "415-954-1475" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), Name = "Reza Alavi", Position = "Administrator", Email = "reza110@hotmail.com", Phone = "254-451-7893" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), Name = "Dennis Castillo", Position = "Coach", Email = "deny.cast@gmail.com", Phone = "125-520-0141" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), Name = "Gabriel Cox", Position = "Coach", Email = "coxcox@gmail.com", Phone = "808-635-1221" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0CA678"), Name = "Lena Jones", Position = "Manager", Email = "lena.offi@hotmail.com", Phone = "320-658-9174" });
            membersDataGrid.ItemsSource = members;
        }
        private void membersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void employees_form(object sender, RoutedEventArgs e)
        {
            // Open a new window (replace 'MainWindow' with the name of your target window)
            AjouterAdherent ajouterAdherent = new AjouterAdherent();

            ajouterAdherent.ShowDialog();
        }
        private void closeFormUpdate(object sender, RoutedEventArgs e)
        {
            // Open a new window (replace 'MainWindow' with the name of your target window)
            /*AdherentFormUpdate adherentFormUpdate = new AdherentFormUpdate();

            adherentFormUpdate.ShowDialog();*/
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            //AherentConfirmationDialog aherentConfirmationDialog = new AherentConfirmationDialog();
            AherentConfirmationDialog aherentConfirmationDialog = new AherentConfirmationDialog();
            aherentConfirmationDialog.ShowDialog();
        }
    }
}

