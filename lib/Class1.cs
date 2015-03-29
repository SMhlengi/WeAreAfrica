using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace lib
{
    public class library
    {
        private const string SQL_GET_USER = "SELECT * FROM WeAreAfrica.dbo.people WHERE (username = @username AND password = @password);";
        private const string SQL_SELECT_PERSON_BASED_ON_EMAIL = "SELECT * FROM WeAreAfrica.dbo.people WHERE (email = @email);";
        private const string SQL_INSERT_PERSON = "INSERT INTO WeAreAfrica.dbo.people (username, email, password, telephone) VALUES (@username, @email, @password, @telephone);";



        public static bool LoginValidation(string username, string password)
        {
            SqlCommand query = new SqlCommand();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
            query.Connection = conn;
            query.CommandText = SQL_GET_USER;
            try
            {
                conn.Open();
                query.Parameters.Add("username", System.Data.SqlDbType.VarChar).Value = username;
                query.Parameters.Add("password", System.Data.SqlDbType.VarChar).Value = password;
                SqlDataReader data = query.ExecuteReader();
                if (data.HasRows)
                {
                    conn.Close();
                    data.Close();
                    return true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return false;
        }


        public static Boolean ValidateCredentials(string username, string password)
        {
            SqlCommand query = new SqlCommand();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
            query.Connection = conn;
            query.CommandText = SQL_GET_USER;
            try
            {
                conn.Open();
                SqlDataReader data = query.ExecuteReader();
                if (data.HasRows)
                {
                    conn.Close();
                    data.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    data.Close();
                    return false;
                }
            }
            catch
            {
            }
            return false;
        }

        public static bool DoesEmailExists(string emailaddress)
        {
            SqlCommand query = new SqlCommand();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
            query.Connection = conn;
            query.CommandText = SQL_SELECT_PERSON_BASED_ON_EMAIL;
            try
            {
                conn.Open();
                query.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = emailaddress;
                SqlDataReader data = query.ExecuteReader();
                if (data.HasRows)
                {
                    conn.Close();
                    data.Close();
                    return true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
            }
            return false;
        }

        public static bool SaveRegistrationDetails(Person person)
        {
            SqlCommand query = new SqlCommand();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
            query.Connection = conn;
            query.CommandText = SQL_INSERT_PERSON;
            query.Parameters.Add("username", System.Data.SqlDbType.VarChar).Value = person.name;
            query.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = person.email;
            query.Parameters.Add("password", System.Data.SqlDbType.VarChar).Value = person.password;
            query.Parameters.Add("telephone", System.Data.SqlDbType.VarChar).Value = person.telephone;
            conn.Open();
            try
            {
                query.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
