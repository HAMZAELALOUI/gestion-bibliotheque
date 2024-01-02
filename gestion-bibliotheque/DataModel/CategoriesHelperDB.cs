using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.DataModel
{
    class CategoriesHelperDB
    {
        private const string ConnectionString = "server=localhost;database=biblio;uid=root;password=;";

        public List<Categorie> GetCategories()
        {
            List<Categorie> categories = new List<Categorie>();
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM categories";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categorie category = new Categorie
                            {
                                CategorieID = (int)reader["CategorieID"],
                                Name = reader["Name"].ToString()
                            };

                            categories.Add(category);
                        }
                    }
                }
            }

            return categories;
        }

    }
}
