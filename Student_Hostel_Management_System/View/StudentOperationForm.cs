using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Student_Hostel_Management_System.Model;
using Student_Hostel_Management_System.Controller;

namespace Student_Hostel_Management_System.View
{
    public partial class StudentOperationForm : Form
    {
        private StudentController controller;
        private User loggedInUser;

        public StudentOperationForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            controller = new StudentController();
        }

        private void StudentOperationForm_Load(object sender, EventArgs e)
        {
            RoomController roomController = new RoomController();
            List<Room> roomList = roomController.GetAllRooms();
            cmbRoomID.Items.Clear();
            foreach (Room r in roomList)
            {
                if (r.Status == "Available")
                {
                    cmbRoomID.Items.Add(r.RoomID);
                }
            }

            dgvStudents.DataSource = controller.GetAllStudents();
            dgvStudents.Columns["UserID"].Visible = false;
            dgvStudents.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = loggedInUser.UserID;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                int roomID = Convert.ToInt32(cmbRoomID.SelectedItem);

                RoomController roomController = new RoomController();
                Room selectedRoom = roomController.SearchRoom(roomID);

                StudentController studentController = new StudentController();
                int currentOccupants = studentController.CountStudentsInRoom(roomID);

                if (currentOccupants >= selectedRoom.Capacity)
                {
                    MessageBox.Show("This room is already full. Please select another available room.");
                    return;
                }

                Student s = new Student(0, userID, name, phone, roomID);
                controller.AddStudent(s);

                MessageBox.Show("Student Added Successfully");
                dgvStudents.DataSource = controller.GetAllStudents();
                dgvStudents.Columns["UserID"].Visible = false;
                dgvStudents.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Row First.");
                return;
            }

            try
            {
                int studentID = Convert.ToInt32(txtStudentID.Text);
                int userID = loggedInUser.UserID;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                int roomID = Convert.ToInt32(cmbRoomID.SelectedItem);

                Student s = new Student(studentID, userID, name, phone, roomID);
                controller.UpdateStudent(s);

                MessageBox.Show("Student Updated Successfully");
                dgvStudents.DataSource = controller.GetAllStudents();
                dgvStudents.Columns["UserID"].Visible = false;
                dgvStudents.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Please enter or search a valid Student ID first.");
                return;
            }

            try
            {
                int studentID = Convert.ToInt32(txtStudentID.Text);
                controller.DeleteStudent(studentID);

                MessageBox.Show("Student Deleted Successfully");
                dgvStudents.DataSource = controller.GetAllStudents();
                dgvStudents.Columns["UserID"].Visible = false;
                dgvStudents.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtStudentID.Enabled = true;
            txtName.Clear();
            txtPhone.Clear();
            cmbRoomID.SelectedIndex = 0;
            txtSearch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (loggedInUser.Role == RoleType.Admin)
            {
                AdminHomeFrame admin = new AdminHomeFrame(loggedInUser);
                admin.Show();
            }
            else
            {
                StaffHomeFrom staff = new StaffHomeFrom(loggedInUser);
                staff.Show();
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtStudentID.Enabled = false;
                txtName.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                cmbRoomID.SelectedItem = Convert.ToInt32(row.Cells[4].Value);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a student name.");
                return;
            }

            Student s = controller.SearchStudent(name);

            if (s != null)
            {
                txtStudentID.Text = s.StudentID.ToString();
                txtStudentID.Enabled = false;
                txtName.Text = s.Name;
                txtPhone.Text = s.Phone;
                cmbRoomID.SelectedItem = s.AssignedRoomID;
                MessageBox.Show("Student Found");
            }
            else
            {
                MessageBox.Show("Student Not Found");
            }
        }
    }
}
