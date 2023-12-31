using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.ViewModel
{
    internal class EmployeViewModel : INotifyPropertyChanged
    {
        private int numberOfEmployees;

        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set
            {
                if (value != numberOfEmployees)
                {
                    numberOfEmployees = value;
                    OnPropertyChanged(nameof(NumberOfEmployees));
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
