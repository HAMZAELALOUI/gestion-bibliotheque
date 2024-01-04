using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.DataModel
{
   public class Reservation
    {
        public int ReservationID { get; set; }

        public int AdherentID { get; set; }

        public int LivreID { get; set; }

        public DateTime DateReservation { get; set; }

        public DateTime? DateRetour { get; set; }

        public bool Prolonge { get; set; }
        public Livre Livre { get; set; }
        public Adherent Adherent { get; set; }
        public decimal MontantAmende { get; set; }


        public string LivreTitre
        {
            get { return Livre.Titre; }
        }

        public string AdherntName
        {
            get { return Adherent.Nom; }
        }

        public String ProlongState
        {
            get { return Prolonge ? "en Cour" : "terminée";}
        }

    }
}