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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gestion_bibliotheque.View
{
    /// <summary>
    /// Interaction logic for Reservation.xaml
    /// </summary>
    public partial class Reservation : UserControl
    {
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
        public void Delete(object sender, RoutedEventArgs e) { }



    }
}