using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Hostel_Management_System.Model;

namespace Student_Hostel_Management_System.Controller
{
    public class AdminController
    {
        Admins admins = new Admins();

        public void DeleteAdminByUserID(int userID)
        {
            admins.DeleteAdminByUserID(userID);
        }
    }
}
