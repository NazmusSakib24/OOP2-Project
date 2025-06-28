using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Hostel_Management_System.Model
{
    public class Admins
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddAdmin(Admin admin)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Admins (UserID, Name) VALUES (@userID, @name)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userID", admin.UserID);
            cmd.Parameters.AddWithValue("@name", admin.Name);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteAdmin(int adminID)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Admins WHERE AdminID = @adminID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@adminID", adminID);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteAdminByUserID(int userID)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Admins WHERE UserID = @userID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public Admin SearchAdmin(string name)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Admins WHERE Name = @name");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", name);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;

            if (reader.Read())
            {
                admin = new Admin
                {
                    AdminID = reader.GetInt32(0),
                    UserID = reader.GetInt32(1),
                    Name = reader.GetString(2)
                };
            }

            cmd.Connection.Close();
            return admin;
        }

        public List<Admin> GetAllAdmins()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Admins");
            cmd.CommandType = CommandType.Text;

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<Admin> adminList = new List<Admin>();
            while (reader.Read())
            {
                Admin admin = new Admin
                {
                    AdminID = reader.GetInt32(0),
                    UserID = reader.GetInt32(1),
                    Name = reader.GetString(2)
                };
                adminList.Add(admin);
            }

            cmd.Connection.Close();
            return adminList;
        }

        public Admin GetAdminByUserID(int userID)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Admins WHERE UserID = @userID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userID", userID);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;

            if (reader.Read())
            {
                admin = new Admin
                {
                    AdminID = reader.GetInt32(0),
                    UserID = reader.GetInt32(1),
                    Name = reader.GetString(2)
                };
            }

            cmd.Connection.Close();
            return admin;
        }
    }
}
