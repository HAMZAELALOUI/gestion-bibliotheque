using System;
using System.Collections.Generic;
using MySqlConnector;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public List<Reservation> SearchReservations(string searchText)
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $@"SELECT 
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
                    Adherents a ON r.AdherentID = a.AdherentID
                WHERE 
                    r.ReservationID LIKE '%{searchText}%' OR
                    r.AdherentID LIKE '%{searchText}%' OR
                    r.LivreID LIKE '%{searchText}%' OR
                    r.DateReservation LIKE '%{searchText}%' OR
                    r.DateRetour LIKE '%{searchText}%' OR
                    r.Prolonge LIKE '%{searchText}%' OR
                    r.MontantAmende LIKE '%{searchText}%' OR
                    l.Titre LIKE '%{searchText}%' OR
                    a.Nom LIKE '%{searchText}%'";

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

        public bool DeleteReservation(int reservationID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Your SQL query to delete a reservation by ID
                    string sqlQuery = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", reservationID);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation deleted successfully.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Reservation not found or deletion failed.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static int GetNumberOfReservation()
        {
            int numberOfReservations = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Your SQL query to get the number of reservation
                    string sqlQuery = "SELECT COUNT(*) FROM reservations";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Execute the query and get the result
                        numberOfReservations = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return numberOfReservations;
        }
    }
}

    

