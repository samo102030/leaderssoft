namespace JBS2
{
    partial class employee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bounusLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label user_NameLabel;
            System.Windows.Forms.Label sallaryLabel;
            System.Windows.Forms.Label emp_nameLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label hire_dateLabel;
            System.Windows.Forms.Label emp_Personal_IDLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label emp_AddLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label label4;
            this.emp_pictureBox = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.browse_emp_pic = new System.Windows.Forms.Button();
            this.emp_type_comboBox = new System.Windows.Forms.ComboBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.bounusTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.user_NameTextBox = new System.Windows.Forms.TextBox();
            this.sallaryTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.Notes_textBox = new System.Windows.Forms.TextBox();
            this.hire_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emp_nameTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.emp_AddTextBox = new System.Windows.Forms.TextBox();
            this.emp_Personal_IDTextBox = new System.Windows.Forms.TextBox();
            this.peneltis_day_textBox = new System.Windows.Forms.TextBox();
            this.available_peneltis_day_textBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Employee_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSet1 = new JBS2.johnDataSet();
            this.employeeTableAdapter1 = new JBS2.johnDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager1 = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            bounusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            user_NameLabel = new System.Windows.Forms.Label();
            sallaryLabel = new System.Windows.Forms.Label();
            emp_nameLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            hire_dateLabel = new System.Windows.Forms.Label();
            emp_Personal_IDLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            emp_AddLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emp_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // bounusLabel
            // 
            bounusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            bounusLabel.AutoSize = true;
            bounusLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bounusLabel.Location = new System.Drawing.Point(10, 227);
            bounusLabel.Name = "bounusLabel";
            bounusLabel.Size = new System.Drawing.Size(45, 17);
            bounusLabel.TabIndex = 97;
            bounusLabel.Text = "علاوة :";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(349, 294);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 17);
            label1.TabIndex = 108;
            label1.Text = "نوع المستخدم :";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(350, 263);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(78, 17);
            passwordLabel.TabIndex = 107;
            passwordLabel.Text = "الرقم السرى :";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(10, 261);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(51, 17);
            phoneLabel.TabIndex = 100;
            phoneLabel.Text = "الهاتف :";
            // 
            // mobileLabel
            // 
            mobileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            mobileLabel.AutoSize = true;
            mobileLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mobileLabel.Location = new System.Drawing.Point(10, 296);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(59, 17);
            mobileLabel.TabIndex = 101;
            mobileLabel.Text = "المحمول :";
            // 
            // user_NameLabel
            // 
            user_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            user_NameLabel.AutoSize = true;
            user_NameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_NameLabel.Location = new System.Drawing.Point(350, 233);
            user_NameLabel.Name = "user_NameLabel";
            user_NameLabel.Size = new System.Drawing.Size(84, 17);
            user_NameLabel.TabIndex = 106;
            user_NameLabel.Text = "اسم المستخدم :";
            // 
            // sallaryLabel
            // 
            sallaryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            sallaryLabel.AutoSize = true;
            sallaryLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sallaryLabel.Location = new System.Drawing.Point(10, 197);
            sallaryLabel.Name = "sallaryLabel";
            sallaryLabel.Size = new System.Drawing.Size(51, 17);
            sallaryLabel.TabIndex = 94;
            sallaryLabel.Text = "المرتب :";
            // 
            // emp_nameLabel
            // 
            emp_nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emp_nameLabel.AutoSize = true;
            emp_nameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_nameLabel.Location = new System.Drawing.Point(10, 37);
            emp_nameLabel.Name = "emp_nameLabel";
            emp_nameLabel.Size = new System.Drawing.Size(79, 17);
            emp_nameLabel.TabIndex = 81;
            emp_nameLabel.Text = "اسم الموظف :";
            // 
            // e_mailLabel
            // 
            e_mailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.Location = new System.Drawing.Point(350, 35);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(97, 17);
            e_mailLabel.TabIndex = 102;
            e_mailLabel.Text = "البريد الالكترونى :";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(350, 138);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 17);
            label2.TabIndex = 105;
            label2.Text = "ملاحظات :";
            // 
            // hire_dateLabel
            // 
            hire_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            hire_dateLabel.AutoSize = true;
            hire_dateLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hire_dateLabel.Location = new System.Drawing.Point(10, 168);
            hire_dateLabel.Name = "hire_dateLabel";
            hire_dateLabel.Size = new System.Drawing.Size(80, 17);
            hire_dateLabel.TabIndex = 93;
            hire_dateLabel.Text = "تاريخ التعيين :";
            // 
            // emp_Personal_IDLabel
            // 
            emp_Personal_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emp_Personal_IDLabel.AutoSize = true;
            emp_Personal_IDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_Personal_IDLabel.Location = new System.Drawing.Point(10, 69);
            emp_Personal_IDLabel.Name = "emp_Personal_IDLabel";
            emp_Personal_IDLabel.Size = new System.Drawing.Size(91, 17);
            emp_Personal_IDLabel.TabIndex = 83;
            emp_Personal_IDLabel.Text = "الكود الشخصى :";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(350, 70);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 17);
            label3.TabIndex = 103;
            label3.Text = "أيام الغياب :";
            // 
            // emp_AddLabel
            // 
            emp_AddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emp_AddLabel.AutoSize = true;
            emp_AddLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_AddLabel.Location = new System.Drawing.Point(10, 135);
            emp_AddLabel.Name = "emp_AddLabel";
            emp_AddLabel.Size = new System.Drawing.Size(53, 17);
            emp_AddLabel.TabIndex = 89;
            emp_AddLabel.Text = "العنوان :";
            // 
            // birthdateLabel
            // 
            birthdateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            birthdateLabel.AutoSize = true;
            birthdateLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdateLabel.Location = new System.Drawing.Point(10, 103);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(78, 17);
            birthdateLabel.TabIndex = 87;
            birthdateLabel.Text = "تاريخ الميلاد :";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(344, 103);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 17);
            label4.TabIndex = 104;
            label4.Text = "ايام الإجازات المتاحة :";
            // 
            // emp_pictureBox
            // 
            this.emp_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emp_pictureBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.emp_pictureBox.Location = new System.Drawing.Point(708, 7);
            this.emp_pictureBox.Name = "emp_pictureBox";
            this.emp_pictureBox.Size = new System.Drawing.Size(234, 288);
            this.emp_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emp_pictureBox.TabIndex = 39;
            this.emp_pictureBox.TabStop = false;
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(217, 17);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(176, 60);
            this.delete.TabIndex = 1;
            this.delete.Text = "مسح";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "اغلاق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(426, 17);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(176, 60);
            this.add.TabIndex = 0;
            this.add.Text = "اضافة";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Location = new System.Drawing.Point(252, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 93);
            this.panel1.TabIndex = 43;
            // 
            // browse_emp_pic
            // 
            this.browse_emp_pic.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_emp_pic.Location = new System.Drawing.Point(708, 310);
            this.browse_emp_pic.Name = "browse_emp_pic";
            this.browse_emp_pic.Size = new System.Drawing.Size(234, 37);
            this.browse_emp_pic.TabIndex = 16;
            this.browse_emp_pic.Text = "تحديد ملف الصورة";
            this.browse_emp_pic.UseVisualStyleBackColor = true;
            this.browse_emp_pic.Click += new System.EventHandler(this.browse_emp_pic_Click);
            // 
            // emp_type_comboBox
            // 
            this.emp_type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emp_type_comboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_type_comboBox.FormattingEnabled = true;
            this.emp_type_comboBox.Items.AddRange(new object[] {
            "المدير",
            "الموظف"});
            this.emp_type_comboBox.Location = new System.Drawing.Point(471, 293);
            this.emp_type_comboBox.Name = "emp_type_comboBox";
            this.emp_type_comboBox.Size = new System.Drawing.Size(200, 25);
            this.emp_type_comboBox.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(107, 256);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 25);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // bounusTextBox
            // 
            this.bounusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bounusTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bounusTextBox.Location = new System.Drawing.Point(107, 222);
            this.bounusTextBox.MaxLength = 5;
            this.bounusTextBox.Name = "bounusTextBox";
            this.bounusTextBox.Size = new System.Drawing.Size(200, 25);
            this.bounusTextBox.TabIndex = 8;
            this.bounusTextBox.TextChanged += new System.EventHandler(this.bounusTextBox_TextChanged);
            this.bounusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bounusTextBox_KeyPress);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(471, 257);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 25);
            this.passwordTextBox.TabIndex = 14;
            // 
            // user_NameTextBox
            // 
            this.user_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_NameTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_NameTextBox.Location = new System.Drawing.Point(471, 227);
            this.user_NameTextBox.Name = "user_NameTextBox";
            this.user_NameTextBox.Size = new System.Drawing.Size(200, 25);
            this.user_NameTextBox.TabIndex = 13;
            // 
            // sallaryTextBox
            // 
            this.sallaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sallaryTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sallaryTextBox.Location = new System.Drawing.Point(107, 192);
            this.sallaryTextBox.MaxLength = 5;
            this.sallaryTextBox.Name = "sallaryTextBox";
            this.sallaryTextBox.Size = new System.Drawing.Size(200, 25);
            this.sallaryTextBox.TabIndex = 5;
            this.sallaryTextBox.TextChanged += new System.EventHandler(this.sallaryTextBox_TextChanged);
            this.sallaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sallaryTextBox_KeyPress);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mobileTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Location = new System.Drawing.Point(107, 291);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(200, 25);
            this.mobileTextBox.TabIndex = 8;
            this.mobileTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobileTextBox_KeyPress);
            // 
            // Notes_textBox
            // 
            this.Notes_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Notes_textBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes_textBox.Location = new System.Drawing.Point(471, 132);
            this.Notes_textBox.Multiline = true;
            this.Notes_textBox.Name = "Notes_textBox";
            this.Notes_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Notes_textBox.Size = new System.Drawing.Size(200, 89);
            this.Notes_textBox.TabIndex = 12;
            // 
            // hire_dateDateTimePicker
            // 
            this.hire_dateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hire_dateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hire_dateDateTimePicker.Location = new System.Drawing.Point(107, 162);
            this.hire_dateDateTimePicker.Name = "hire_dateDateTimePicker";
            this.hire_dateDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.hire_dateDateTimePicker.TabIndex = 4;
            // 
            // emp_nameTextBox
            // 
            this.emp_nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emp_nameTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_nameTextBox.Location = new System.Drawing.Point(107, 32);
            this.emp_nameTextBox.Name = "emp_nameTextBox";
            this.emp_nameTextBox.Size = new System.Drawing.Size(200, 25);
            this.emp_nameTextBox.TabIndex = 0;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.e_mailTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mailTextBox.Location = new System.Drawing.Point(471, 29);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(200, 25);
            this.e_mailTextBox.TabIndex = 9;
            // 
            // emp_AddTextBox
            // 
            this.emp_AddTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emp_AddTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_AddTextBox.Location = new System.Drawing.Point(107, 130);
            this.emp_AddTextBox.Name = "emp_AddTextBox";
            this.emp_AddTextBox.Size = new System.Drawing.Size(200, 25);
            this.emp_AddTextBox.TabIndex = 3;
            // 
            // emp_Personal_IDTextBox
            // 
            this.emp_Personal_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emp_Personal_IDTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_Personal_IDTextBox.Location = new System.Drawing.Point(107, 64);
            this.emp_Personal_IDTextBox.MaxLength = 14;
            this.emp_Personal_IDTextBox.Name = "emp_Personal_IDTextBox";
            this.emp_Personal_IDTextBox.Size = new System.Drawing.Size(200, 25);
            this.emp_Personal_IDTextBox.TabIndex = 1;
            this.emp_Personal_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emp_Personal_IDTextBox_KeyPress);
            // 
            // peneltis_day_textBox
            // 
            this.peneltis_day_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.peneltis_day_textBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peneltis_day_textBox.Location = new System.Drawing.Point(471, 64);
            this.peneltis_day_textBox.MaxLength = 2;
            this.peneltis_day_textBox.Name = "peneltis_day_textBox";
            this.peneltis_day_textBox.Size = new System.Drawing.Size(200, 25);
            this.peneltis_day_textBox.TabIndex = 10;
            
            this.peneltis_day_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peneltis_day_textBox_KeyPress);
            // 
            // available_peneltis_day_textBox
            // 
            this.available_peneltis_day_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.available_peneltis_day_textBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_peneltis_day_textBox.Location = new System.Drawing.Point(471, 97);
            this.available_peneltis_day_textBox.MaxLength = 2;
            this.available_peneltis_day_textBox.Name = "available_peneltis_day_textBox";
            this.available_peneltis_day_textBox.Size = new System.Drawing.Size(200, 25);
            this.available_peneltis_day_textBox.TabIndex = 11;
            this.available_peneltis_day_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.available_peneltis_day_textBox_KeyPress);
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthdateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(107, 97);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.birthdateDateTimePicker.TabIndex = 2;
            // 
            // Employee_bindingSource
            // 
            this.Employee_bindingSource.DataMember = "Employee";
            this.Employee_bindingSource.DataSource = this.johnDataSet1;
            // 
            // johnDataSet1
            // 
            this.johnDataSet1.DataSetName = "johnDataSet";
            this.johnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BrandTableAdapter = null;
            this.tableAdapterManager1.CurrencyTableAdapter = null;
            this.tableAdapterManager1.customersTableAdapter = null;
            this.tableAdapterManager1.Dameged_ItemTableAdapter = null;
            this.tableAdapterManager1.EmployeeTableAdapter = this.employeeTableAdapter1;
            this.tableAdapterManager1.ItemsTableAdapter = null;
            this.tableAdapterManager1.Order_in_detailesTableAdapter = null;
            this.tableAdapterManager1.Order_Out_DetailsTableAdapter = null;
            this.tableAdapterManager1.Order_OutTableAdapter = null;
            this.tableAdapterManager1.Orders_inTableAdapter = null;
            this.tableAdapterManager1.paid_customerTableAdapter = null;
            this.tableAdapterManager1.paid_to_supplierTableAdapter = null;
            this.tableAdapterManager1.StoreTableAdapter = null;
            this.tableAdapterManager1.supplierTableAdapter = null;
            this.tableAdapterManager1.typesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = JBS2.johnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 481);
            this.Controls.Add(this.emp_type_comboBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.bounusTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(bounusLabel);
            this.Controls.Add(label1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.user_NameTextBox);
            this.Controls.Add(this.sallaryTextBox);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(user_NameLabel);
            this.Controls.Add(sallaryLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.Notes_textBox);
            this.Controls.Add(this.hire_dateDateTimePicker);
            this.Controls.Add(emp_nameLabel);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(label2);
            this.Controls.Add(hire_dateLabel);
            this.Controls.Add(this.emp_nameTextBox);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(this.emp_AddTextBox);
            this.Controls.Add(emp_Personal_IDLabel);
            this.Controls.Add(label3);
            this.Controls.Add(emp_AddLabel);
            this.Controls.Add(this.emp_Personal_IDTextBox);
            this.Controls.Add(this.peneltis_day_textBox);
            this.Controls.Add(this.available_peneltis_day_textBox);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(label4);
            this.Controls.Add(this.browse_emp_pic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emp_pictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " ";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emp_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox emp_pictureBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button browse_emp_pic;
        private System.Windows.Forms.ComboBox emp_type_comboBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox bounusTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox user_NameTextBox;
        private System.Windows.Forms.TextBox sallaryTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox Notes_textBox;
        private System.Windows.Forms.DateTimePicker hire_dateDateTimePicker;
        private System.Windows.Forms.TextBox emp_nameTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox emp_AddTextBox;
        private System.Windows.Forms.TextBox emp_Personal_IDTextBox;
        private System.Windows.Forms.TextBox peneltis_day_textBox;
        private System.Windows.Forms.TextBox available_peneltis_day_textBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.BindingSource Employee_bindingSource;
        private johnDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private johnDataSet johnDataSet1;
    }
}