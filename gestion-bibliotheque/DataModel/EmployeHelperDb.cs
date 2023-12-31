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
    }
}
