using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class UserDataAccess
    {
        public List<User> getUsers()
        {
            List<User> listUser = new List<User>();
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetUser", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                listUser.Add(new User()
                {
                    Id=Convert.ToInt32(rd["Id"]),
                    FirstName = rd["FirstName"].ToString(),
                    LastName = rd["LastName"].ToString(), 
                    UserName = rd["UsernameName"].ToString(),
                    Password = rd["PasswordName"].ToString(),
                    UserType = Convert.ToInt32(rd["UserType"]),
                });

            }

            return listUser;
        }

        public void AddUser(User user )
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            SqlCommand cmd = new SqlCommand("AddUsers", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@un", SqlDbType.VarChar,50).Value = user.UserName;
            cmd.Parameters.Add("@pwdn", SqlDbType.VarChar,50).Value = user.Password;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar,50).Value = user.FirstName;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar,50).Value = user.LastName;
            cmd.Parameters.Add("@userType", SqlDbType.Int).Value = user.UserType;

            cmd.ExecuteNonQuery();
        }

        public List<User> getUserIds()
        {
            List<User> listUser = new List<User>();
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetIDs", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                listUser.Add(new User()
                {
                    Id =Convert.ToInt32(rd["Id"])
                });

            }

            return listUser;
        }

        public void UpdateUser(User user)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            SqlCommand cmd = new SqlCommand("UpdateUsers", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = user.Id;
            cmd.Parameters.Add("@un", SqlDbType.VarChar, 50).Value = user.UserName;
            cmd.Parameters.Add("@pwdn", SqlDbType.VarChar, 50).Value = user.Password;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar, 50).Value = user.FirstName;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar, 50).Value = user.LastName;
            cmd.Parameters.Add("@userType", SqlDbType.Int).Value = user.UserType;
           
            cmd.ExecuteNonQuery();
        }
        public void DeleteUser(int id)
        {
            SqlConnection conn = new SqlConnection(GetDbConnection.Connecton());
            SqlCommand cmd = new SqlCommand("DeleteUsers", conn);
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            

            cmd.ExecuteNonQuery();
        }

    }
}
