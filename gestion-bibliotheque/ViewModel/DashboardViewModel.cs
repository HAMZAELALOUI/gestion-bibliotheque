using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace gestion_bibliotheque.ViewModel
{
    internal class DashboardViewModel : ViewBase
    {
        public ReservationViewModel ReservationViewModel { get; set; }
        public AherentsViewModel AherentsViewModel { get; set; }
        public LivreViewModel LivreViewModel { get; set; }
        public DashboardViewModel()
        {
            ReservationViewModel = new ReservationViewModel();
            AherentsViewModel = new AherentsViewModel();
            LivreViewModel  = new LivreViewModel();

        }
    }
}
