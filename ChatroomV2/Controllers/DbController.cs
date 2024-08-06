using System.Configuration;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

public class DbController 
{
    static readonly string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

    internal static async Task<bool> Login(string username, string password)
    {
        // Login logic
        try
        {
            // convert the password into its hashed version to verify it with DB
            string hashedPassword = await HashPassword(password);

            
            const string query = "SELECT * FROM users WHERE username = @username AND password = @password";

            using (var connection = new MySqlConnection(CONNECTIONSTRING))
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    // Open the connection asynchronously
                    await connection.OpenAsync();

                    // Add the parameters to the command
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", hashedPassword);

                    // Execute the command asynchronously and assign the outcome to the result variable
                    int result = Convert.ToInt32(await command.ExecuteScalarAsync());

                    // Check if the result was successful (1) or not (0)
                    if (result > 0)
                    {
                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else 
                    {
                        MessageBox.Show($"Username / Password Incorrect", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return false;
    }

    internal static async Task Register(string username, string password, byte[] profilePicData) 
    {
        // Register logic
        try
        {
            // convert the password into its hashed version to store it in the DB
            string hashedPassword = await HashPassword(password);

            const string query = "INSERT INTO users (username, password, profilePicture) VALUES (@username, @password, @profilePicture)";

            using (var connection = new MySqlConnection(CONNECTIONSTRING)) 
            {
                using (var command = new MySqlCommand(query, connection)) 
                {
                    await connection.OpenAsync();

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.Parameters.AddWithValue("@profilePicture", profilePicData);

                    int result = await command.ExecuteNonQueryAsync();

                    if (result > 0)
                    {
                        MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }
    }

    internal static async Task<Image> GetProfilePicture(string user) 
    {
        try 
        {
            // Query to get the profile picture from the DB
            const string query = "SELECT profilePicture FROM users WHERE username = @username";

            // Create a new connection object
            using (var connection = new MySqlConnection(CONNECTIONSTRING)) 
            {
                // Create a new command object
                using (var command = new MySqlCommand(query, connection)) 
                {
                    // Open the connection asynchronously
                    await connection.OpenAsync();

                    //Add the username parameter to the command
                    command.Parameters.AddWithValue("@username", user);

                    // Execute the command asynchronously and assign the outcome to the reader variable
                    using (var reader = await command.ExecuteReaderAsync()) 
                    {
                        // Read the data from the reader
                        while (await reader.ReadAsync()) 
                        {
                            // Get the profile picture data from the reader
                            byte[] imageData = reader["profilePicture"] as byte[];

                            // Check if the data is not null
                            if (imageData != null) 
                            {
                                // Create a new memory stream object
                                using(MemoryStream ms = new MemoryStream(imageData)) 
                                {
                                    // Create a new image object from the memory stream
                                    Image profilePic = Image.FromStream(ms);
                                    return profilePic;
                                }
                            }
                        }
                    }
                }
            }
        }
        catch(Exception ex) 
        {
            MessageBox.Show($"An Error Occurred: {ex.Message}");
        }

        return null;
    }

    internal static async Task<string> HashPassword(string password)
    {
        // create temp sha256 object
        using (var sha256 = SHA256.Create())
        {
            // Hash the password
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder sb = new StringBuilder();

            // Convert the bytes to a string
            foreach (var b in bytes) 
            {
                // Append the byte to the string
                sb.Append(b.ToString("x2"));
            }

            // return the hashed password
            return sb.ToString();
        }
    }
}