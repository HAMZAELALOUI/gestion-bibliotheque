using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using gestion_bibliotheque.View;
using MySqlConnector;
// Your DatabaseHelper.cs file
using gestion_bibliotheque.View.InputForm.UserControls;
using System.ComponentModel; // Add the correct namespace


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



        public void DeleteAdherentById(int adherentId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // First, delete reservations associated with the adherent
                    string deleteReservationsQuery = $"DELETE FROM Reservations WHERE AdherentID = {adherentId}";
                    using (MySqlCommand deleteReservationsCommand = new MySqlCommand(deleteReservationsQuery, connection))
                    {
                        deleteReservationsCommand.ExecuteNonQuery();
                    }

                    // Then, delete the adherent itself
                    string deleteAdherentQuery = $"DELETE FROM Adherents WHERE AdherentID = {adherentId}";
                    using (MySqlCommand deleteAdherentCommand = new MySqlCommand(deleteAdherentQuery, connection))
                    {
                        deleteAdherentCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        public void InsertAdherentData(string prenom, string nom, string email, string numeroTelephone, string adresse, string motDePasse, string autresDetailsAdherent)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Your SQL query to insert data
                    string sqlQuery = "INSERT INTO Adherents (Prenom, Nom, Email, NumeroTelephone, Adresse, MotDePasse, DateInscription, AutresDetailsAdherent) " +
                                      "VALUES (@Prenom, @Nom, @Email, @NumeroTelephone, @Adresse, @MotDePasse, NOW(), @AutresDetailsAdherent)";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Set parameters
                        command.Parameters.AddWithValue("@Prenom", prenom);
                        command.Parameters.AddWithValue("@Nom", nom);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@NumeroTelephone", numeroTelephone);
                        command.Parameters.AddWithValue("@Adresse", adresse);
                        command.Parameters.AddWithValue("@MotDePasse", motDePasse);
                        command.Parameters.AddWithValue("@AutresDetailsAdherent", autresDetailsAdherent);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        public static int GetNumberOfAdherents()
        {
            int numberOfAdherents = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Your SQL query to get the number of adherents
                    string sqlQuery = "SELECT COUNT(*) FROM Adherents";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Execute the query and get the result
                        numberOfAdherents = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return numberOfAdherents;
        }


        public List<Adherent> SearchAdherents(string searchText)
        {
            List<Adherent> adherents = new List<Adherent>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                // Adjust your SQL query to include a WHERE clause for searching
                string query = $"SELECT AdherentID, Prenom, Nom, Email, NumeroTelephone, Adresse, MotDePasse, DateInscription, AutresDetailsAdherent FROM adherents WHERE Nom LIKE '%{searchText}%' OR Prenom LIKE '%{searchText}%' OR Email LIKE '%{searchText}%' OR NumeroTelephone LIKE '%{searchText}%'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Adherent adherent = new Adherent
                            {
                                AdherentID = Convert.ToInt32(reader["AdherentID"]),
                                Prenom = reader["Prenom"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Email = reader["Email"].ToString(),
                                NumeroTelephone = reader["NumeroTelephone"].ToString(),
                                Adresse = reader["Adresse"].ToString(),
                                MotDePasse = reader["MotDePasse"].ToString(),
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






