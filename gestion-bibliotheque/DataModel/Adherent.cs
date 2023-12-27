using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.DataModel
{
    public class Adherent
    {
        public int AdherentID {  get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string NumeroTelephone { get; set; }
        public string Adresse { get; set; }
        public string MotDePasse { get; set; }
        public DateTime DateInscription { get; set; }
        public string AutresDetailsAdherent { get; set; }
    }
}
