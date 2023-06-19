namespace FinalProject
{
    partial class AppointmentsFrm
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
            this.LVApt = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hospital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vaccine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LVApt
            // 
            this.LVApt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Date,
            this.Hospital,
            this.Vaccine,
            this.Status});
            this.LVApt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LVApt.Enabled = false;
            this.LVApt.HideSelection = false;
            this.LVApt.Location = new System.Drawing.Point(0, 0);
            this.LVApt.MultiSelect = false;
            this.LVApt.Name = "LVApt";
            this.LVApt.Size = new System.Drawing.Size(379, 336);
            this.LVApt.TabIndex = 2;
            this.LVApt.UseCompatibleStateImageBehavior = false;
            this.LVApt.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Hospital
            // 
            this.Hospital.Text = "Hospital";
            // 
            // Vaccine
            // 
            this.Vaccine.Text = "Vaccine";
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // AppointmentsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 336);
            this.Controls.Add(this.LVApt);
            this.Name = "AppointmentsFrm";
            this.Text = "AppointmentsFrm";
            this.Load += new System.EventHandler(this.AppointmentsFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVApt;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Hospital;
        private System.Windows.Forms.ColumnHeader Vaccine;
        private System.Windows.Forms.ColumnHeader Status;
    }
}