using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace gestion_bibliotheque.DataModel
{
    internal class EmployeHelperDb
    {
        private const string ConnectionString = "server=localhost;database=biblio;uid=root;password=;";


        public List<Employe> GetEmploye()
        {
            List<Employe> employes = new List<Employe>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT EmployeID,Prenom,Nom,Role,AutresDetailsEmploye FROM employes";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employe employe = new Employe
                            {
                                EmployeID = int.Parse(reader["EmployeID"].ToString()),
                                Prenom = reader["Prenom"].ToString(),
                                Nom = reader["Nom"].ToString(),
                                Role = reader["Role"].ToString(),
                                AutresDetailsEmploye = reader["AutresDetailsEmploye"].ToString(),
                            };

                            employes.Add(employe);
                        }
                    }
                }
            }

            return employes;
        }


        public void DeleteEmployeById(int employeID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Construct the SQL command
                    string sql = "DELETE FROM employes WHERE EmployeID = @EmployeID";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@EmployeID", employeID);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Employe with ID {employeID} deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show($"No Employe found with ID {employeID}.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static int GetNumberOfEmployees()
        {
            int numberOfEmployees = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Your SQL query to get the number of adherents
                    string sqlQuery = "SELECT COUNT(*) FROM employes";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Execute the query and get the result
                        numberOfEmployees = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return numberOfEmployees;
        }
        public void InsertEmploye(string Nom, string Prenom, string Role, string AutresDetailsEmploye)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // SQL query with parameters
                    string sqlQuery = "INSERT INTO employes (Nom, Prenom, Role, AutresDetailsEmploye) " +
                                      "VALUES (@Nom, @Prenom, @Role, @AutresDetailsEmploye)";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@Nom", Nom);
                        command.Parameters.AddWithValue("@Prenom", Prenom);
                        command.Parameters.AddWithValue("@Role", Role);
                        command.Parameters.AddWithValue("@AutresDetailsEmploye",AutresDetailsEmploye);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void UpdateEmploye(int employeID, string newNom, string newPrenom, string newRole, string newAutresDetailsEmploye)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    // SQL query with parameters for update
                    string sqlQuery = "UPDATE employes SET Nom = @Nom, Prenom = @Prenom, Role = @Role, AutresDetailsEmploye = @AutresDetailsEmploye " +
                                      "WHERE EmployeID = @EmployeID";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@EmployeID", employeID);
                        command.Parameters.AddWithValue("@Nom", newNom);
                        command.Parameters.AddWithValue("@Prenom", newPrenom);
                        command.Parameters.AddWithValue("@Role", newRole);
                        command.Parameters.AddWithValue("@AutresDetailsEmploye", newAutresDetailsEmploye);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }





        public List<Employe> SearchEmployes(string searchText)
        {
            List<Employe> employes = new List<Employe>();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                // Adjust your SQL query to include a WHERE clause for searching
                string query = $"SELECT EmployeID, Nom, Prenom, Role, AutresDetailsEmploye FROM employes WHERE Nom LIKE '%{searchText}%' OR Prenom LIKE '%{searchText}%' OR Role LIKE '%{searchText}%'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employe employe = new Employe
                            {
                                EmployeID = Convert.ToInt32(reader["EmployeID"]),
                                Nom = reader["Nom"].ToString(),
                                Prenom = reader["Prenom"].ToString(),
                                Role = reader["Role"].ToString(),
                                AutresDetailsEmploye = reader["AutresDetailsEmploye"].ToString()
                            };

                            employes.Add(employe);
                        }
                    }
                }
            }

            return employes;
        }

    }
}

