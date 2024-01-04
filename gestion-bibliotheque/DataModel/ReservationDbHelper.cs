using System;
using System.Collections.Generic;
using MySqlConnector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_bibliotheque.DataModel
{
    class ReservationDbHelper
    {
        private const string ConnectionString = "server=localhost;database=biblio;uid=root;password=;";

        public List<Reservation> GetReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"SELECT 
                            r.ReservationID,
                            r.AdherentID,
                            r.LivreID,
                            r.DateReservation,
                            r.DateRetour,
                            r.Prolonge,
                           r.MontantAmende,
                            l.Titre,
                            a.Nom
                        FROM 
                            Reservations r
                        JOIN 
                            Livres l ON r.LivreID = l.LivreID
                        JOIN 
                            Adherents a ON r.AdherentID = a.AdherentID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reservation reservation = new Reservation
                            {
                                ReservationID = Convert.ToInt32(reader["ReservationID"]),
                                AdherentID = Convert.ToInt32(reader["AdherentID"]),
                                LivreID = Convert.ToInt32(reader["LivreID"]),
                                DateReservation = Convert.ToDateTime(reader["DateReservation"]),
                                DateRetour = reader["DateRetour"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["DateRetour"]),
                                Prolonge = Convert.ToBoolean(reader["Prolonge"]),
                                MontantAmende = Convert.ToDecimal(reader["MontantAmende"]),
                                Livre = new Livre
                                {
                                    LivreID = Convert.ToInt32(reader["LivreID"]),
                                    Titre = reader["Titre"].ToString()
                                },
                                Adherent = new Adherent
                                {
                                    AdherentID = Convert.ToInt32(reader["AdherentID"]),
                                    Nom = reader["Nom"].ToString()
                                }

                            };

                            reservations.Add(reservation);
                        }
                    }
                }
            }

            return reservations;
        }

    }
}
