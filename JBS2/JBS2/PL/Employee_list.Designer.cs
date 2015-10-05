namespace JBS2.PL
{
    partial class Employee_list
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
            this.DG_Employee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Employee
            // 
            this.DG_Employee.AllowUserToAddRows = false;
            this.DG_Employee.AllowUserToDeleteRows = false;
            this.DG_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Employee.Location = new System.Drawing.Point(0, 0);
            this.DG_Employee.Name = "DG_Employee";
            this.DG_Employee.ReadOnly = true;
            this.DG_Employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DG_Employee.Size = new System.Drawing.Size(880, 419);
            this.DG_Employee.TabIndex = 0;
            this.DG_Employee.DoubleClick += new System.EventHandler(this.DG_Employee_DoubleClick);
            // 
            // Employee_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 419);
            this.Controls.Add(this.DG_Employee);
            this.MinimizeBox = false;
            this.Name = "Employee_list";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة بجميع العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DG_Employee;

    }
}