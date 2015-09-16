namespace JBS2
{
    partial class storereport
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
            this.report_store = new System.Windows.Forms.Button();
            this.crystal_query = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // report_store
            // 
            this.report_store.Location = new System.Drawing.Point(114, 83);
            this.report_store.Name = "report_store";
            this.report_store.Size = new System.Drawing.Size(158, 65);
            this.report_store.TabIndex = 0;
            this.report_store.Text = "report_store";
            this.report_store.UseVisualStyleBackColor = true;
            this.report_store.Click += new System.EventHandler(this.report_store_Click);
            // 
            // crystal_query
            // 
            this.crystal_query.Location = new System.Drawing.Point(131, 248);
            this.crystal_query.Name = "crystal_query";
            this.crystal_query.Size = new System.Drawing.Size(158, 65);
            this.crystal_query.TabIndex = 0;
            this.crystal_query.Text = "crystal_query";
            this.crystal_query.UseVisualStyleBackColor = true;
            this.crystal_query.Click += new System.EventHandler(this.report_store_Click);
            // 
            // storereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 404);
            this.Controls.Add(this.crystal_query);
            this.Controls.Add(this.report_store);
            this.Name = "storereport";
            this.Text = "storereport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button report_store;
        private System.Windows.Forms.Button crystal_query;
    }
}