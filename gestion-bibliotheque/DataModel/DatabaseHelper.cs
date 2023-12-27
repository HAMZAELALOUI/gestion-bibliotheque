using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace gestion_bibliotheque.DataModel
{
    public class DatabaseHelper
    {
        private const string ConnectionString = "server=localhost;database=biblio;uid=root;password=;";

        public List<Adherent> GetAdherents()
        {
            List<Adherent> adherents = new List<Adherent>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT AdherentID,Prenom,Nom,Email,NumeroTelephone,NumeroTelephone,Adresse,DateInscription,AutresDetailsAdherent FROM adherents";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Adherent adherent = new Adherent
                            {
                                AdherentID = int.Parse(reader["AdherentID"].ToString()),
                                Prenom = reader["Prenom"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Email = reader["Email"].ToString(),
                                NumeroTelephone = reader["NumeroTelephone"].ToString(),
                                Adresse = reader["Adresse"].ToString(),
                                DateInscription = Convert.ToDateTime(reader["DateInscription"]),
                                AutresDetailsAdherent = reader["AutresDetailsAdherent"].ToString()
                            };

                            adherents.Add(adherent);
                        }
                    }
                }
            }

            return adherents;
        }
    }
}

