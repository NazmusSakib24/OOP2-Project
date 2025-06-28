namespace Student_Hostel_Management_System.View
{
    partial class UtilityBillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBillID = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblElectricity = new System.Windows.Forms.Label();
            this.txtElectricity = new System.Windows.Forms.TextBox();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCllear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBillID.Location = new System.Drawing.Point(21, 37);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(50, 16);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "Bill ID : ";
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(117, 37);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(150, 22);
            this.txtBillID.TabIndex = 1;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoomID.Location = new System.Drawing.Point(21, 75);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(69, 16);
            this.lblRoomID.TabIndex = 2;
            this.lblRoomID.Text = "Room ID : ";
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Location = new System.Drawing.Point(117, 72);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(150, 24);
            this.cmbRoomID.TabIndex = 3;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMonth.Location = new System.Drawing.Point(21, 132);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(52, 16);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Month : ";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(117, 129);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(150, 24);
            this.cmbMonth.TabIndex = 5;
            // 
            // lblElectricity
            // 
            this.lblElectricity.AutoSize = true;
            this.lblElectricity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblElectricity.Location = new System.Drawing.Point(21, 181);
            this.lblElectricity.Name = "lblElectricity";
            this.lblElectricity.Size = new System.Drawing.Size(73, 16);
            this.lblElectricity.TabIndex = 6;
            this.lblElectricity.Text = "Electricity : ";
            // 
            // txtElectricity
            // 
            this.txtElectricity.Location = new System.Drawing.Point(117, 175);
            this.txtElectricity.Name = "txtElectricity";
            this.txtElectricity.Size = new System.Drawing.Size(150, 22);
            this.txtElectricity.TabIndex = 7;
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(117, 223);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(150, 22);
            this.txtWater.TabIndex = 8;
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(117, 274);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(150, 22);
            this.txtGas.TabIndex = 9;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWater.Location = new System.Drawing.Point(21, 226);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(52, 16);
            this.lblWater.TabIndex = 10;
            this.lblWater.Text = "Water : ";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGas.Location = new System.Drawing.Point(21, 277);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(41, 16);
            this.lblGas.TabIndex = 11;
            this.lblGas.Text = "Gas : ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(21, 331);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status : ";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(117, 328);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 24);
            this.cmbStatus.TabIndex = 13;
            // 
            // dgvBills
            // 
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(292, 40);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.RowTemplate.Height = 24;
            this.dgvBills.Size = new System.Drawing.Size(698, 338);
            this.dgvBills.TabIndex = 14;
            this.dgvBills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(74, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 42);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(216, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 42);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(369, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 42);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(507, 466);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 42);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(822, 466);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 42);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCllear
            // 
            this.btnCllear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCllear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCllear.Location = new System.Drawing.Point(656, 466);
            this.btnCllear.Name = "btnCllear";
            this.btnCllear.Size = new System.Drawing.Size(120, 42);
            this.btnCllear.TabIndex = 21;
            this.btnCllear.Text = "Clear";
            this.btnCllear.UseVisualStyleBackColor = false;
            this.btnCllear.Click += new System.EventHandler(this.btnCllear_Click);
            // 
            // UtilityBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 553);
            this.Controls.Add(this.btnCllear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.txtElectricity);
            this.Controls.Add(this.lblElectricity);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbRoomID);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.txtBillID);
            this.Controls.Add(this.lblBillID);
            this.Name = "UtilityBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Utility Bill";
            this.Load += new System.EventHandler(this.UtilityBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblElectricity;
        private System.Windows.Forms.TextBox txtElectricity;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCllear;
    }
}