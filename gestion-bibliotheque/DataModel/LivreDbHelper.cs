using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace gestion_bibliotheque.DataModel
{
    class LivreDbHelper
    {
        private const string ConnectionString = "server=localhost;database=biblio;uid=root;password=;";

        public void InsertLivreData(string Titre, string Auteur, int CategorieID, bool EstDisponible, DateTime ReleaseDate, double Prix, string AutresDetailsLivre)
        {


            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Livres (Titre, Auteur, CategorieID, EstDisponible, ReleaseDate, Prix, AutresDetailsLivre) " +
                      "VALUES (@Titre, @Auteur, @CategorieID, @EstDisponible, @ReleaseDate, @Prix, @AutresDetailsLivre)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        // Set parameter values based on your Livre model properties
                        command.Parameters.AddWithValue("@Titre", Titre);
                        command.Parameters.AddWithValue("@Auteur", Auteur);
                        command.Parameters.AddWithValue("@CategorieID", CategorieID);
                        command.Parameters.AddWithValue("@EstDisponible", EstDisponible ? 1 : 0);
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                        command.Parameters.AddWithValue("@Prix", Prix);
                        command.Parameters.AddWithValue("@AutresDetailsLivre", AutresDetailsLivre);

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


        public List<Livre> GetLivres()
        {
            List<Livre> livres = new List<Livre>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Livres.LivreID, Livres.Titre, Livres.Auteur, Categories.CategorieID, Categories.Name AS CategoryName, Livres.EstDisponible, Livres.ReleaseDate, Livres.Prix, Livres.AutresDetailsLivre " +
                       "FROM Livres INNER JOIN Categories ON Livres.CategorieID = Categories.CategorieID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livre livre = new Livre
                            {
                                LivreID = Convert.ToInt32(reader["LivreID"]),
                                Titre = reader["Titre"].ToString(),
                                Auteur = reader["Auteur"].ToString(),
                                EstDisponible = Convert.ToBoolean(reader["EstDisponible"]),
                                ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]),
                                Prix = Convert.ToDouble(reader["Prix"]),
                                AutresDetailsLivre = reader["AutresDetailsLivre"].ToString(),
                                Categorie = new Categorie
                                {
                                    Name = reader["CategoryName"].ToString(),
                                    CategorieID = Convert.ToInt32(reader["CategorieID"]) // Include CategorieID if needed
                                }
                            };

                            livres.Add(livre);
                        }
                    }
                }
            }

            return livres;
        }



        public void DeleteLivreId(int LivreID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // First, delete reservations associated with the livre
                    string deleteReservationsQuery = $"DELETE FROM Reservations WHERE LivreID = {LivreID}";
                    using (MySqlCommand deleteReservationsCommand = new MySqlCommand(deleteReservationsQuery, connection))
                    {
                        deleteReservationsCommand.ExecuteNonQuery();
                    }

                    // Then, delete the livre itself
                    string deleteLivreQuery = $"DELETE FROM Livres WHERE LivreID = {LivreID}";
                    using (MySqlCommand deleteLivreCommand = new MySqlCommand(deleteLivreQuery, connection))
                    {
                        deleteLivreCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static int GetNumberOfLivres()
        {
            int numberOfLivres = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Your SQL query to get the number of adherents
                    string sqlQuery = "SELECT COUNT(*) FROM Livres";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Execute the query and get the result
                        numberOfLivres = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return numberOfLivres;
        }


        public List<Livre> SearchLivres(string searchText)
        {
            List<Livre> livres = new List<Livre>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = $"SELECT Livres.LivreID, Livres.Titre, Livres.Auteur, Categories.CategorieID, Categories.Name AS CategoryName, Livres.EstDisponible, Livres.ReleaseDate, Livres.Prix, Livres.AutresDetailsLivre " +
                               $"FROM Livres INNER JOIN Categories ON Livres.CategorieID = Categories.CategorieID " +
                               $"WHERE Livres.Titre LIKE '%{searchText}%' OR " +
                               $"Livres.Auteur LIKE '%{searchText}%' OR " +
                               $"Categories.Name LIKE '%{searchText}%' OR " +
                               $"Livres.EstDisponible LIKE '%{searchText}%' OR " +
                               $"Livres.ReleaseDate LIKE '%{searchText}%' OR " +
                               $"Livres.Prix LIKE '%{searchText}%' OR " +
                               $"Livres.AutresDetailsLivre LIKE '%{searchText}%' OR " +
                               $"Categories.Name LIKE '%{searchText}%'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livre livre = new Livre
                            {
                                LivreID = Convert.ToInt32(reader["LivreID"]),
                                Titre = reader["Titre"].ToString(),
                                Auteur = reader["Auteur"].ToString(),
                                EstDisponible = Convert.ToBoolean(reader["EstDisponible"]),
                                ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]),
                                Prix = Convert.ToDouble(reader["Prix"]),
                                AutresDetailsLivre = reader["AutresDetailsLivre"].ToString(),
                                Categorie = new Categorie
                                {
                                    Name = reader["CategoryName"].ToString(),
                                    CategorieID = Convert.ToInt32(reader["CategorieID"]) // Include CategorieID if needed
                                }
                            };

                            livres.Add(livre);
                        }
                    }
                }
            }

            return livres;
        }



    }
}
