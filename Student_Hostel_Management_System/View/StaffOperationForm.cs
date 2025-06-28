using Student_Hostel_Management_System.Controller;
using Student_Hostel_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Student_Hostel_Management_System.View
{
    public partial class StaffOperationForm : Form
    {
        private StaffController controller;
        private User loggedInUser;

        public StaffOperationForm(User user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            controller = new StaffController();
        }

        private void StaffOperationForm_Load(object sender, EventArgs e)
        {
            lblUserID.Visible = false;
            cmbUserID.Visible = false;

            UserController userController = new UserController();
            List<User> userList = userController.GetAlluser()
                .Where(u => u.Role == RoleType.Staff || u.Role == RoleType.Admin).ToList();

            cmbUserID.DataSource = userList;
            cmbUserID.DisplayMember = "Username";
            cmbUserID.ValueMember = "UserID";

            LoadStaff();
        }

        private void LoadStaff()
        {
            dgvStaff.DataSource = null;
            dgvStaff.DataSource = controller.GetAllStaff();

            if (dgvStaff.Columns["UserID"] != null)
            {
                dgvStaff.Columns["UserID"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Convert.ToInt32(cmbUserID.SelectedValue);
                string name = txtName.Text;
                string phone = txtPhone.Text;

                Staff s = new Staff(0, userID, name, phone);
                controller.AddStaff(s);

                MessageBox.Show("Staff Added Successfully");
                LoadStaff();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int staffID = Convert.ToInt32(txtStaffID.Text);
                int userID = Convert.ToInt32(cmbUserID.SelectedValue);
                string name = txtName.Text;
                string phone = txtPhone.Text;

                Staff s = new Staff(staffID, userID, name, phone);
                controller.UpdateStaff(s);

                MessageBox.Show("Staff Updated Successfully");
                LoadStaff();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int staffID = Convert.ToInt32(txtStaffID.Text);
                controller.DeleteStaff(staffID);
                MessageBox.Show("Staff Deleted Successfully");
                LoadStaff();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtStaffID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtSearch.Clear();
            txtStaffID.Enabled = true;
            if (cmbUserID.Items.Count > 0)
            {
                cmbUserID.SelectedIndex = 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter a Staff ID.");
                return;
            }

            int staffID;
            if (!int.TryParse(txtSearch.Text, out staffID))
            {
                MessageBox.Show("Staff ID must be a number.");
                return;
            }

            Staff s = controller.SearchStaff(staffID);

            if (s != null)
            {
                txtStaffID.Text = s.StaffID.ToString();
                cmbUserID.SelectedValue = s.UserID;
                txtName.Text = s.Name;
                txtPhone.Text = s.Phone;
                txtStaffID.Enabled = false;
                MessageBox.Show("Staff Found");
            }
            else
            {
                MessageBox.Show("Staff Not Found");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomeFrame admin = new AdminHomeFrame(loggedInUser);
            admin.Show();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

                txtStaffID.Text = row.Cells[0].Value.ToString();
                cmbUserID.SelectedValue = Convert.ToInt32(row.Cells[1].Value);
                txtName.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtStaffID.Enabled = false;
            }
        }
    }
}
