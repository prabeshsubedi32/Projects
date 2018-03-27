﻿using System;
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
                    FirstName = rd["FirstName"].ToString(),
                    LastName = rd["LastName"].ToString(),
                    UserName = rd["UsernameName"].ToString()
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
            cmd.Parameters.Add("@un", SqlDbType.VarChar).Value = user.UserName;
            cmd.Parameters.Add("@pwdn", SqlDbType.VarChar).Value = user.Password;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = user.FirstName;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = user.LastName;
            cmd.ExecuteNonQuery();
        }
    }
}
