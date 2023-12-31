using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.DataModel
{
    public class Employe
    {
        // Propriétés de l'employé
        public int EmployeID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }
        public string AutresDetailsEmploye { get; set; }
    }

}
