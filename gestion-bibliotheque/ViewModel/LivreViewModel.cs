using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.ViewModel
{
    internal class LivreViewModel : INotifyPropertyChanged
    {
        private int numberOfLivre;

        public int NmberOfLivre
        {
            get { return numberOfLivre; }
            set
            {
                if (value != numberOfLivre)
                {
                    numberOfLivre = value;
                    OnPropertyChanged(nameof(NmberOfLivre));
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
