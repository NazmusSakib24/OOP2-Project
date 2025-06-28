using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Hostel_Management_System.Model
{
    public class Admin
    {
        private int adminID;
        private int userID;
        private string name;

        // Parameterless Constructor
        public Admin() { }

        // Parameterized Constructor
        public Admin(int adminID, int userID, string name)
        {
            this.adminID = adminID;
            this.userID = userID;
            this.name = name;
        }

        // Properties
        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
