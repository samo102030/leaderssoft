namespace JBS2
{
    partial class datagride
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
            this.button1 = new System.Windows.Forms.Button();
            this.itemsdataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.nametextBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemsdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemsdataGridView
            // 
            this.itemsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.adress});
            this.itemsdataGridView.Location = new System.Drawing.Point(33, 115);
            this.itemsdataGridView.Name = "itemsdataGridView";
            this.itemsdataGridView.Size = new System.Drawing.Size(268, 150);
            this.itemsdataGridView.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ToolTipText = "name";
            // 
            // adress
            // 
            this.adress.HeaderText = "adress";
            this.adress.Name = "adress";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(33, 58);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(100, 20);
            this.nametextBox1.TabIndex = 2;
            // 
            // nametextBox2
            // 
            this.nametextBox2.Location = new System.Drawing.Point(181, 58);
            this.nametextBox2.Name = "nametextBox2";
            this.nametextBox2.Size = new System.Drawing.Size(100, 20);
            this.nametextBox2.TabIndex = 2;
            // 
            // datagride
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 416);
            this.Controls.Add(this.nametextBox2);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.itemsdataGridView);
            this.Controls.Add(this.button1);
            this.Name = "datagride";
            this.Text = "datagride";
            ((System.ComponentModel.ISupportInitialize)(this.itemsdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView itemsdataGridView;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.TextBox nametextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
    }
}