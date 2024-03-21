using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
namespace QuickHost
{

    public partial class User_SignUp : System.Web.UI.Page
    {
        protected void SignupButton_Click(object sender, EventArgs e)
        {
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            //string confirmPassword = Request.Form["confirm-password"];
            int age = Convert.ToInt32(Request.Form["age"]);
            string address = Request.Form["address"];
            string city = Request.Form["city"];
            string state = Request.Form["state"];

            // Hash the password (you should use a proper hashing algorithm)
            string hashedPassword = HashPassword(password);

            // Save user data to the database
            bool success = SaveUserData(name, email, hashedPassword, age, address, city, state);

            if (success)
            {
                // Show success message in popup
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Sign up successful. You can now log in.'); window.location.href = 'userlogin.aspx';", true);
            }
            else
            {
                // Show error message in popup
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('An error occurred. Please try again later.');", true);
            }
        }

        private bool SaveUserData(string name, string email, string password, int age, string address, string city, string state)
        {
           // string connectionString = ConfigurationManager.ConnectionStrings["server=localhost;port=3306;database=quickhost;uid=root;pwd=suraj"].ConnectionString;
            string connectionString = "server=localhost;port=3306;database=quickhost;uid=root;pwd=suraj";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Name, Email, Password, Age, Address, City, State) VALUES (@Name, @Email, @Password, @Age, @Address, @City, @State)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@City", city);
                    command.Parameters.AddWithValue("@State", state);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
        }



        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute hash from the password bytes
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert hashed bytes to string representation
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}