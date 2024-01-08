using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.ViewModel
{
    internal class ReservationViewModel
    {
        private int numberOfReservations;

        public int NumberOfReservations
        {
            get { return numberOfReservations; }
            set
            {
                if (value != numberOfReservations)
                {
                    numberOfReservations = value;
                    OnPropertyChanged(nameof(NumberOfReservations));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
