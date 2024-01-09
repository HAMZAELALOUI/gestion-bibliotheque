using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.DataModel
{
  
    public class Livre
    {
       
        public int LivreID { get; set; }

        public string Titre { get; set; }

        public string Auteur { get; set; }

        public int CategorieID { get; set; }

        public Categorie Categorie { get; set; }

        public bool EstDisponible { get; set; }
      
        public DateTime ReleaseDate { get; set; }

        public double Prix { get; set; }

        public string AutresDetailsLivre { get; set; }


        public string EstDisponibleDisplay
        {
            get { return EstDisponible  ? "Disponible" : "n'est pas disponible"; }
        }

        public string GetCategoryName
        {
            get { return Categorie.Name; }
        }

        public int GetCategoryId
        {
            get { return Categorie.CategorieID; }
        }



    }

}
