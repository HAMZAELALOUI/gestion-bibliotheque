using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.ViewModel
{
    internal class AherentsViewModel :INotifyPropertyChanged
    {
         private int numberOfAdherents;

    public int NumberOfAdherents
    {
        get { return numberOfAdherents; }
        set
        {
            if (value != numberOfAdherents)
            {
                numberOfAdherents = value;
                OnPropertyChanged(nameof(NumberOfAdherents));
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
