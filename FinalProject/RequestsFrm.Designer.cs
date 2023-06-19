
namespace FinalProject
{
    partial class RequestsFrm
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
            this.LVReq = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vaccine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAptInfo = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboHosp = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDeny = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpAptInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVReq
            // 
            this.LVReq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Location,
            this.Age,
            this.Gender,
            this.Vaccine});
            this.LVReq.HideSelection = false;
            this.LVReq.Location = new System.Drawing.Point(29, 12);
            this.LVReq.MultiSelect = false;
            this.LVReq.Name = "LVReq";
            this.LVReq.Size = new System.Drawing.Size(348, 147);
            this.LVReq.TabIndex = 5;
            this.LVReq.UseCompatibleStateImageBehavior = false;
            this.LVReq.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            // 
            // Location
            // 
            this.Location.Text = "Location";
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // Vaccine
            // 
            this.Vaccine.Text = "Vaccine";
            // 
            // grpAptInfo
            // 
            this.grpAptInfo.Controls.Add(this.BtnSave);
            this.grpAptInfo.Controls.Add(this.label2);
            this.grpAptInfo.Controls.Add(this.label1);
            this.grpAptInfo.Controls.Add(this.ComboHosp);
            this.grpAptInfo.Controls.Add(this.datePicker);
            this.grpAptInfo.Enabled = false;
            this.grpAptInfo.Location = new System.Drawing.Point(29, 218);
            this.grpAptInfo.Name = "grpAptInfo";
            this.grpAptInfo.Size = new System.Drawing.Size(348, 146);
            this.grpAptInfo.TabIndex = 8;
            this.grpAptInfo.TabStop = false;
            this.grpAptInfo.Text = "Appointment Info";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(257, 102);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hospital";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set date";
            // 
            // ComboHosp
            // 
            this.ComboHosp.FormattingEnabled = true;
            this.ComboHosp.Items.AddRange(new object[] {
            "Hotel-Dieu",
            "Geitaoui",
            "AUBMC",
            "Bahman",
            "Saint George",
            "Mount Lebanon",
            "Najjar"});
            this.ComboHosp.Location = new System.Drawing.Point(115, 104);
            this.ComboHosp.Name = "ComboHosp";
            this.ComboHosp.Size = new System.Drawing.Size(121, 21);
            this.ComboHosp.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(115, 58);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 5;
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(250, 175);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(75, 23);
            this.btnDeny.TabIndex = 7;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(87, 175);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 6;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(250, 400);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 400);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // RequestsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 442);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LVReq);
            this.Controls.Add(this.grpAptInfo);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnApprove);
            this.Name = "RequestsFrm";
            this.Text = "RequestsFrm";
            this.Load += new System.EventHandler(this.RequestsFrm_Load);
            this.grpAptInfo.ResumeLayout(false);
            this.grpAptInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVReq;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Vaccine;
        private System.Windows.Forms.GroupBox grpAptInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboHosp;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnReset;
    }
}