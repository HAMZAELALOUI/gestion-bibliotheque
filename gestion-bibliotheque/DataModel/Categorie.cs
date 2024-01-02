using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.DataModel
{
    
    public class Categorie
    {
        
        public int CategorieID { get; set; }

        public string Name { get; set; }

        public string DisplayMember => Name;
        public int GetCategorieID => CategorieID;
    }

}
