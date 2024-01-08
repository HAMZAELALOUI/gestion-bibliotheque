using gestion_bibliotheque.DataModel;
using gestion_bibliotheque.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gestion_bibliotheque.View
{
    /// <summary>
    /// Interaction logic for DashboardContent.xaml
    /// </summary>
    public partial class DashboardContent : UserControl
    {
        public DashboardContent()
        {

            InitializeComponent();
            SetDashboardData();
        }

        private void SetDashboardData()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            DataContext = dashboardViewModel;
            // Set data for individual ViewModels
            dashboardViewModel.ReservationViewModel.NumberOfReservations = ReservationDbHelper.GetNumberOfReservation();
            dashboardViewModel.AherentsViewModel.NumberOfAdherents = DatabaseHelper.GetNumberOfAdherents();
            dashboardViewModel.LivreViewModel.NumberOfLivre = LivreDbHelper.GetNumberOfLivres();


        }
    }
}
