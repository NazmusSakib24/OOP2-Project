﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Hostel_Management_System.Model;

namespace Student_Hostel_Management_System.Controller
{
    public class UserController
    {
        Users users = new Users();

        public void AddUser(User user)
        {
            users.AddUser(user);
        }

        public void DeleteUser(int userId, string role, string currentUserRole)
        {
            if (currentUserRole != "Admin" && currentUserRole != "Staff")
            {
                throw new UnauthorizedAccessException("Only Admin and Staff can delete users.");
            }

            users.DeleteUser(userId, role);
        }


        public void UpdateUser(User user)
        {
            users.UpdateUser(user);
        }

        public User SearchUser(string username, int password)
        {
            return users.SearchUser(username, password);
        }

        public User SearchUserByID(int userId)
        {
            return users.GetAllUsers().FirstOrDefault(u => u.UserID == userId);
        }


        public List<User> GetAlluser()
        {
            return users.GetAllUsers();
        }

        public User SearchUserByUsernameAndSecurityAns(string username, string securityAns)
        {
            return users.SearchUserByUsernameAndSecurityAns(username, securityAns);
        }

    }
}
