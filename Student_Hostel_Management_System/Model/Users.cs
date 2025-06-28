using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Student_Hostel_Management_System.Model
{
    public class Users
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddUser(User user)
        {
            SqlCommand cmd = null;
            int newUserId = -1;

            try
            {

                cmd = sda.GetQuery("INSERT INTO Users (Username, Password, Role, SecurityAns) VALUES (@username, @password, @role, @securityAns); SELECT SCOPE_IDENTITY();");
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role.ToString());
                cmd.Parameters.AddWithValue("@securityAns", user.SecurityAns);
                cmd.Connection.Open();
                object result = cmd.ExecuteScalar();
                cmd.Connection.Close();

                if (result != null && int.TryParse(result.ToString(), out newUserId))
                {
                 
                }
                else
                {
                    throw new Exception("Failed to retrieve new UserID after inserting into Users table.");
                }

                if (user.Role.ToString() == "Admin")
                {
                    SqlCommand cmdAdmins = sda.GetQuery("INSERT INTO Admins (UserID, Name) VALUES (@userId, @name)");
                    cmdAdmins.CommandType = CommandType.Text;
                    cmdAdmins.Parameters.AddWithValue("@userId", newUserId);
                    cmdAdmins.Parameters.AddWithValue("@name", user.Username);
                    cmdAdmins.Connection.Open();
                    cmdAdmins.ExecuteNonQuery();
                    cmdAdmins.Connection.Close();
                }
                else if (user.Role.ToString() == "Staff")
                {
                    SqlCommand cmdStaff = sda.GetQuery("INSERT INTO Staff (UserID, Name, Phone) VALUES (@userId, @name, @phone)");
                    cmdStaff.CommandType = CommandType.Text;
                    cmdStaff.Parameters.AddWithValue("@userId", newUserId);
                    cmdStaff.Parameters.AddWithValue("@name", user.Username);
                    cmdStaff.Parameters.AddWithValue("@phone", "01000000000");
                    cmdStaff.Connection.Open();
                    cmdStaff.ExecuteNonQuery();
                    cmdStaff.Connection.Close();
                }
                else if (user.Role.ToString() == "Student")
                {
                   
                    SqlCommand roomCheck = sda.GetQuery("SELECT COUNT(*) FROM Rooms WHERE RoomID = 1");
                    roomCheck.CommandType = CommandType.Text;
                    roomCheck.Connection.Open();
                    int roomExists = (int)roomCheck.ExecuteScalar();
                    roomCheck.Connection.Close();

                    if (roomExists == 0)
                    {
                        throw new Exception("Room ID 1 does not exist. Cannot assign student.");
                    }

                   
                    SqlCommand cmdStudents = sda.GetQuery("INSERT INTO Students (UserID, Name, Phone, AssignedRoomID) VALUES (@userId, @name, @phone, @assignedRoomId)");
                    cmdStudents.CommandType = CommandType.Text;
                    cmdStudents.Parameters.AddWithValue("@userId", newUserId);
                    cmdStudents.Parameters.AddWithValue("@name", user.Username);
                    cmdStudents.Parameters.AddWithValue("@phone", "01000000000");
                    cmdStudents.Parameters.AddWithValue("@assignedRoomId", 1);
                    cmdStudents.Connection.Open();
                    cmdStudents.ExecuteNonQuery();
                    cmdStudents.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding user: " + ex.Message);
                throw;
            }
        }

        public void DeleteUser(int userId, string role)
        {
            SqlCommand cmdRole = null;

            if (role == "Admin")
                cmdRole = sda.GetQuery("DELETE FROM Admins WHERE UserID = @userID");
            else if (role == "Staff")
                cmdRole = sda.GetQuery("DELETE FROM Staff WHERE UserID = @userID");
            else if (role == "Student")
                cmdRole = sda.GetQuery("DELETE FROM Students WHERE UserID = @userID");

            if (cmdRole != null)
            {
                cmdRole.CommandType = CommandType.Text;
                cmdRole.Parameters.AddWithValue("@userID", userId);
                cmdRole.Connection.Open();
                cmdRole.ExecuteNonQuery();
                cmdRole.Connection.Close();
            }

            SqlCommand cmdUser = sda.GetQuery("DELETE FROM Users WHERE UserID = @userID");
            cmdUser.CommandType = CommandType.Text;
            cmdUser.Parameters.AddWithValue("@userID", userId);
            cmdUser.Connection.Open();
            cmdUser.ExecuteNonQuery();
            cmdUser.Connection.Close();
        }

        public void UpdateUser(User user)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Users SET Username=@username, Password=@password, Role=@role, SecurityAns=@securityAns WHERE UserID=@userID;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userID", user.UserID);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role.ToString());
            cmd.Parameters.AddWithValue("@securityAns", user.SecurityAns);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public User SearchUser(string username, int password)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users WHERE Username= @username AND Password=@password;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            List<User> userList = GetData(cmd);
            return userList.Count > 0 ? userList[0] : null;
        }

        public List<User> GetAllUsers()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }

        public List<User> GetData(SqlCommand cmd)
        {
            List<User> userlist = new List<User>();
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                User u = new User();
                u.UserID = sdr.GetInt32(0);
                u.Username = sdr.GetString(1);
                u.Password = sdr.GetInt32(2);
                u.Role = (RoleType)Enum.Parse(typeof(RoleType), sdr.GetString(3));
                u.SecurityAns = sdr.GetString(4);
                userlist.Add(u);
            }
            sdr.Close();
            cmd.Connection.Close();
            return userlist;
        }

        public User SearchUserByUsernameAndSecurityAns(string username, string securityAns)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users WHERE Username=@username AND SecurityAns=@securityAns;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@securityAns", securityAns);
            List<User> userList = GetData(cmd);
            return userList.Count > 0 ? userList[0] : null;
        }
    }
}
