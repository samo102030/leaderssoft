namespace JBS2.PL
{
    partial class Show_all_employee
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
            System.Windows.Forms.Label emp_IDLabel;
            System.Windows.Forms.Label emp_nameLabel;
            System.Windows.Forms.Label emp_Personal_IDLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label emp_AddLabel;
            System.Windows.Forms.Label hire_dateLabel;
            System.Windows.Forms.Label sallaryLabel;
            System.Windows.Forms.Label bounusLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label penalties_DaysLabel;
            System.Windows.Forms.Label avaliable_Absence_DaysLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label emp_User_nameLabel;
            System.Windows.Forms.Label user_PwdLabel;
            System.Windows.Forms.Label emp_typeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.brows_empPic_button = new System.Windows.Forms.Button();
            this.Emp_pictureBox = new System.Windows.Forms.PictureBox();
            this.emp_IDTextBox = new System.Windows.Forms.TextBox();
            this.emp_nameTextBox = new System.Windows.Forms.TextBox();
            this.emp_Personal_IDTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emp_AddTextBox = new System.Windows.Forms.TextBox();
            this.hire_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sallaryTextBox = new System.Windows.Forms.TextBox();
            this.bounusTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.penalties_DaysTextBox = new System.Windows.Forms.TextBox();
            this.avaliable_Absence_DaysTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.emp_User_nameTextBox = new System.Windows.Forms.TextBox();
            this.user_PwdTextBox = new System.Windows.Forms.TextBox();
            this.Employee_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Choose_emp_button = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.johnDataSet = new JBS2.johnDataSet();
            this.employeeTableAdapter = new JBS2.johnDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new JBS2.johnDataSetTableAdapters.TableAdapterManager();
            emp_IDLabel = new System.Windows.Forms.Label();
            emp_nameLabel = new System.Windows.Forms.Label();
            emp_Personal_IDLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            emp_AddLabel = new System.Windows.Forms.Label();
            hire_dateLabel = new System.Windows.Forms.Label();
            sallaryLabel = new System.Windows.Forms.Label();
            bounusLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            penalties_DaysLabel = new System.Windows.Forms.Label();
            avaliable_Absence_DaysLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            emp_User_nameLabel = new System.Windows.Forms.Label();
            user_PwdLabel = new System.Windows.Forms.Label();
            emp_typeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_IDLabel
            // 
            emp_IDLabel.AutoSize = true;
            emp_IDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_IDLabel.Location = new System.Drawing.Point(852, 37);
            emp_IDLabel.Name = "emp_IDLabel";
            emp_IDLabel.Size = new System.Drawing.Size(78, 17);
            emp_IDLabel.TabIndex = 0;
            emp_IDLabel.Text = "كود الموظف :";
            // 
            // emp_nameLabel
            // 
            emp_nameLabel.AutoSize = true;
            emp_nameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_nameLabel.Location = new System.Drawing.Point(851, 75);
            emp_nameLabel.Name = "emp_nameLabel";
            emp_nameLabel.Size = new System.Drawing.Size(79, 17);
            emp_nameLabel.TabIndex = 2;
            emp_nameLabel.Text = "أسم الموظف :";
            // 
            // emp_Personal_IDLabel
            // 
            emp_Personal_IDLabel.AutoSize = true;
            emp_Personal_IDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_Personal_IDLabel.Location = new System.Drawing.Point(856, 111);
            emp_Personal_IDLabel.Name = "emp_Personal_IDLabel";
            emp_Personal_IDLabel.Size = new System.Drawing.Size(79, 17);
            emp_Personal_IDLabel.TabIndex = 4;
            emp_Personal_IDLabel.Text = "الرقم القومى :";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdateLabel.Location = new System.Drawing.Point(852, 149);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(78, 17);
            birthdateLabel.TabIndex = 6;
            birthdateLabel.Text = "تاريخ الميلاد :";
            // 
            // emp_AddLabel
            // 
            emp_AddLabel.AutoSize = true;
            emp_AddLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_AddLabel.Location = new System.Drawing.Point(877, 184);
            emp_AddLabel.Name = "emp_AddLabel";
            emp_AddLabel.Size = new System.Drawing.Size(53, 17);
            emp_AddLabel.TabIndex = 8;
            emp_AddLabel.Text = "العنوان :";
            // 
            // hire_dateLabel
            // 
            hire_dateLabel.AutoSize = true;
            hire_dateLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hire_dateLabel.Location = new System.Drawing.Point(850, 221);
            hire_dateLabel.Name = "hire_dateLabel";
            hire_dateLabel.Size = new System.Drawing.Size(80, 17);
            hire_dateLabel.TabIndex = 10;
            hire_dateLabel.Text = "تاريخ التعيين :";
            // 
            // sallaryLabel
            // 
            sallaryLabel.AutoSize = true;
            sallaryLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sallaryLabel.Location = new System.Drawing.Point(879, 256);
            sallaryLabel.Name = "sallaryLabel";
            sallaryLabel.Size = new System.Drawing.Size(51, 17);
            sallaryLabel.TabIndex = 12;
            sallaryLabel.Text = "المرتب :";
            // 
            // bounusLabel
            // 
            bounusLabel.AutoSize = true;
            bounusLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bounusLabel.Location = new System.Drawing.Point(875, 292);
            bounusLabel.Name = "bounusLabel";
            bounusLabel.Size = new System.Drawing.Size(55, 17);
            bounusLabel.TabIndex = 14;
            bounusLabel.Text = "الحوافز :";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(881, 328);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(49, 17);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "تليفون :";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mobileLabel.Location = new System.Drawing.Point(546, 34);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(51, 17);
            mobileLabel.TabIndex = 18;
            mobileLabel.Text = "محمول :";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mailLabel.Location = new System.Drawing.Point(500, 70);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(97, 17);
            e_mailLabel.TabIndex = 20;
            e_mailLabel.Text = "البريد الإلكترونى :";
            // 
            // penalties_DaysLabel
            // 
            penalties_DaysLabel.AutoSize = true;
            penalties_DaysLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            penalties_DaysLabel.Location = new System.Drawing.Point(511, 106);
            penalties_DaysLabel.Name = "penalties_DaysLabel";
            penalties_DaysLabel.Size = new System.Drawing.Size(86, 17);
            penalties_DaysLabel.TabIndex = 22;
            penalties_DaysLabel.Text = "عد أيام الغياب :";
            // 
            // avaliable_Absence_DaysLabel
            // 
            avaliable_Absence_DaysLabel.AutoSize = true;
            avaliable_Absence_DaysLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            avaliable_Absence_DaysLabel.Location = new System.Drawing.Point(461, 143);
            avaliable_Absence_DaysLabel.Name = "avaliable_Absence_DaysLabel";
            avaliable_Absence_DaysLabel.Size = new System.Drawing.Size(136, 17);
            avaliable_Absence_DaysLabel.TabIndex = 24;
            avaliable_Absence_DaysLabel.Text = "عدد الإجازات المسموحة :";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(536, 202);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(61, 17);
            notesLabel.TabIndex = 26;
            notesLabel.Text = "ملاحظات :";
            // 
            // emp_User_nameLabel
            // 
            emp_User_nameLabel.AutoSize = true;
            emp_User_nameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_User_nameLabel.Location = new System.Drawing.Point(513, 253);
            emp_User_nameLabel.Name = "emp_User_nameLabel";
            emp_User_nameLabel.Size = new System.Drawing.Size(84, 17);
            emp_User_nameLabel.TabIndex = 28;
            emp_User_nameLabel.Text = "أسم المستخدم :";
            // 
            // user_PwdLabel
            // 
            user_PwdLabel.AutoSize = true;
            user_PwdLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_PwdLabel.Location = new System.Drawing.Point(522, 289);
            user_PwdLabel.Name = "user_PwdLabel";
            user_PwdLabel.Size = new System.Drawing.Size(75, 17);
            user_PwdLabel.TabIndex = 30;
            user_PwdLabel.Text = "كلمة المرور :";
            // 
            // emp_typeLabel
            // 
            emp_typeLabel.AutoSize = true;
            emp_typeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emp_typeLabel.Location = new System.Drawing.Point(542, 325);
            emp_typeLabel.Name = "emp_typeLabel";
            emp_typeLabel.Size = new System.Drawing.Size(55, 17);
            emp_typeLabel.TabIndex = 32;
            emp_typeLabel.Text = "الوظيفة :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Type_comboBox);
            this.groupBox1.Controls.Add(this.brows_empPic_button);
            this.groupBox1.Controls.Add(this.Emp_pictureBox);
            this.groupBox1.Controls.Add(emp_IDLabel);
            this.groupBox1.Controls.Add(this.emp_IDTextBox);
            this.groupBox1.Controls.Add(emp_nameLabel);
            this.groupBox1.Controls.Add(this.emp_nameTextBox);
            this.groupBox1.Controls.Add(emp_Personal_IDLabel);
            this.groupBox1.Controls.Add(this.emp_Personal_IDTextBox);
            this.groupBox1.Controls.Add(birthdateLabel);
            this.groupBox1.Controls.Add(this.birthdateDateTimePicker);
            this.groupBox1.Controls.Add(emp_AddLabel);
            this.groupBox1.Controls.Add(this.emp_AddTextBox);
            this.groupBox1.Controls.Add(hire_dateLabel);
            this.groupBox1.Controls.Add(this.hire_dateDateTimePicker);
            this.groupBox1.Controls.Add(sallaryLabel);
            this.groupBox1.Controls.Add(this.sallaryTextBox);
            this.groupBox1.Controls.Add(bounusLabel);
            this.groupBox1.Controls.Add(this.bounusTextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(mobileLabel);
            this.groupBox1.Controls.Add(this.mobileTextBox);
            this.groupBox1.Controls.Add(e_mailLabel);
            this.groupBox1.Controls.Add(this.e_mailTextBox);
            this.groupBox1.Controls.Add(penalties_DaysLabel);
            this.groupBox1.Controls.Add(this.penalties_DaysTextBox);
            this.groupBox1.Controls.Add(avaliable_Absence_DaysLabel);
            this.groupBox1.Controls.Add(this.avaliable_Absence_DaysTextBox);
            this.groupBox1.Controls.Add(notesLabel);
            this.groupBox1.Controls.Add(this.notesTextBox);
            this.groupBox1.Controls.Add(emp_User_nameLabel);
            this.groupBox1.Controls.Add(this.emp_User_nameTextBox);
            this.groupBox1.Controls.Add(user_PwdLabel);
            this.groupBox1.Controls.Add(this.user_PwdTextBox);
            this.groupBox1.Controls.Add(emp_typeLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظف ";
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Items.AddRange(new object[] {
            "المدير",
            "الموظف"});
            this.Type_comboBox.Location = new System.Drawing.Point(235, 318);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(224, 31);
            this.Type_comboBox.TabIndex = 36;
            // 
            // brows_empPic_button
            // 
            this.brows_empPic_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brows_empPic_button.Location = new System.Drawing.Point(9, 299);
            this.brows_empPic_button.Name = "brows_empPic_button";
            this.brows_empPic_button.Size = new System.Drawing.Size(207, 29);
            this.brows_empPic_button.TabIndex = 35;
            this.brows_empPic_button.Text = "تحديد ملف الصورة";
            this.brows_empPic_button.UseVisualStyleBackColor = true;
            this.brows_empPic_button.Click += new System.EventHandler(this.brows_empPic_button_Click);
            // 
            // Emp_pictureBox
            // 
            this.Emp_pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Emp_pictureBox.Location = new System.Drawing.Point(7, 29);
            this.Emp_pictureBox.Name = "Emp_pictureBox";
            this.Emp_pictureBox.Size = new System.Drawing.Size(209, 252);
            this.Emp_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emp_pictureBox.TabIndex = 34;
            this.Emp_pictureBox.TabStop = false;
            // 
            // emp_IDTextBox
            // 
            this.emp_IDTextBox.Enabled = false;
            this.emp_IDTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_IDTextBox.Location = new System.Drawing.Point(729, 34);
            this.emp_IDTextBox.Name = "emp_IDTextBox";
            this.emp_IDTextBox.Size = new System.Drawing.Size(117, 25);
            this.emp_IDTextBox.TabIndex = 1;
            // 
            // emp_nameTextBox
            // 
            this.emp_nameTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_nameTextBox.Location = new System.Drawing.Point(606, 70);
            this.emp_nameTextBox.Name = "emp_nameTextBox";
            this.emp_nameTextBox.Size = new System.Drawing.Size(240, 25);
            this.emp_nameTextBox.TabIndex = 3;
            // 
            // emp_Personal_IDTextBox
            // 
            this.emp_Personal_IDTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_Personal_IDTextBox.Location = new System.Drawing.Point(606, 106);
            this.emp_Personal_IDTextBox.MaxLength = 14;
            this.emp_Personal_IDTextBox.Name = "emp_Personal_IDTextBox";
            this.emp_Personal_IDTextBox.Size = new System.Drawing.Size(240, 25);
            this.emp_Personal_IDTextBox.TabIndex = 5;
            this.emp_Personal_IDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(606, 143);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(240, 25);
            this.birthdateDateTimePicker.TabIndex = 7;
            // 
            // emp_AddTextBox
            // 
            this.emp_AddTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_AddTextBox.Location = new System.Drawing.Point(606, 179);
            this.emp_AddTextBox.Name = "emp_AddTextBox";
            this.emp_AddTextBox.Size = new System.Drawing.Size(240, 25);
            this.emp_AddTextBox.TabIndex = 9;
            // 
            // hire_dateDateTimePicker
            // 
            this.hire_dateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hire_dateDateTimePicker.Location = new System.Drawing.Point(606, 215);
            this.hire_dateDateTimePicker.Name = "hire_dateDateTimePicker";
            this.hire_dateDateTimePicker.Size = new System.Drawing.Size(240, 25);
            this.hire_dateDateTimePicker.TabIndex = 11;
            // 
            // sallaryTextBox
            // 
            this.sallaryTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sallaryTextBox.Location = new System.Drawing.Point(606, 251);
            this.sallaryTextBox.Name = "sallaryTextBox";
            this.sallaryTextBox.Size = new System.Drawing.Size(240, 25);
            this.sallaryTextBox.TabIndex = 13;
            // 
            // bounusTextBox
            // 
            this.bounusTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bounusTextBox.Location = new System.Drawing.Point(606, 287);
            this.bounusTextBox.Name = "bounusTextBox";
            this.bounusTextBox.Size = new System.Drawing.Size(240, 25);
            this.bounusTextBox.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(606, 323);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(240, 25);
            this.phoneTextBox.TabIndex = 17;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.Location = new System.Drawing.Point(235, 29);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(224, 25);
            this.mobileTextBox.TabIndex = 19;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mailTextBox.Location = new System.Drawing.Point(235, 65);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(224, 25);
            this.e_mailTextBox.TabIndex = 21;
            // 
            // penalties_DaysTextBox
            // 
            this.penalties_DaysTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penalties_DaysTextBox.Location = new System.Drawing.Point(235, 101);
            this.penalties_DaysTextBox.Name = "penalties_DaysTextBox";
            this.penalties_DaysTextBox.Size = new System.Drawing.Size(224, 25);
            this.penalties_DaysTextBox.TabIndex = 23;
            // 
            // avaliable_Absence_DaysTextBox
            // 
            this.avaliable_Absence_DaysTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliable_Absence_DaysTextBox.Location = new System.Drawing.Point(235, 138);
            this.avaliable_Absence_DaysTextBox.Name = "avaliable_Absence_DaysTextBox";
            this.avaliable_Absence_DaysTextBox.Size = new System.Drawing.Size(224, 25);
            this.avaliable_Absence_DaysTextBox.TabIndex = 25;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(235, 174);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(224, 64);
            this.notesTextBox.TabIndex = 27;
            // 
            // emp_User_nameTextBox
            // 
            this.emp_User_nameTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_User_nameTextBox.Location = new System.Drawing.Point(235, 248);
            this.emp_User_nameTextBox.Name = "emp_User_nameTextBox";
            this.emp_User_nameTextBox.Size = new System.Drawing.Size(224, 25);
            this.emp_User_nameTextBox.TabIndex = 29;
            // 
            // user_PwdTextBox
            // 
            this.user_PwdTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_PwdTextBox.Location = new System.Drawing.Point(235, 284);
            this.user_PwdTextBox.Name = "user_PwdTextBox";
            this.user_PwdTextBox.Size = new System.Drawing.Size(224, 25);
            this.user_PwdTextBox.TabIndex = 31;
            // 
            // Employee_comboBox
            // 
            this.Employee_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee_comboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_comboBox.FormattingEnabled = true;
            this.Employee_comboBox.Location = new System.Drawing.Point(118, 55);
            this.Employee_comboBox.Name = "Employee_comboBox";
            this.Employee_comboBox.Size = new System.Drawing.Size(240, 30);
            this.Employee_comboBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.Cancel_button);
            this.groupBox2.Controls.Add(this.Update_button);
            this.groupBox2.Controls.Add(this.Delete_button);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(9, 28);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(160, 45);
            this.Cancel_button.TabIndex = 0;
            this.Cancel_button.Text = "إلغاء";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(189, 28);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(160, 45);
            this.Update_button.TabIndex = 0;
            this.Update_button.Text = "حفظ التعديل ";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(368, 28);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(160, 45);
            this.Delete_button.TabIndex = 0;
            this.Delete_button.Text = "حذف الموظف ";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "اختر الموظف :";
            // 
            // Choose_emp_button
            // 
            this.Choose_emp_button.Location = new System.Drawing.Point(237, 12);
            this.Choose_emp_button.Name = "Choose_emp_button";
            this.Choose_emp_button.Size = new System.Drawing.Size(121, 37);
            this.Choose_emp_button.TabIndex = 6;
            this.Choose_emp_button.Text = "اختر الموظف";
            this.Choose_emp_button.UseVisualStyleBackColor = true;
            this.Choose_emp_button.Click += new System.EventHandler(this.Choose_emp_button_Click);
            // 
            // johnDataSet
            // 
            this.johnDataSet.DataSetName = "johnDataSet";
            this.johnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTableAdapter = null;
            this.tableAdapterManager.CurrencyTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.Dameged_ItemTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.Order_in_detailesTableAdapter = null;
            this.tableAdapterManager.Order_Out_DetailsTableAdapter = null;
            this.tableAdapterManager.Order_OutTableAdapter = null;
            this.tableAdapterManager.Orders_inTableAdapter = null;
            this.tableAdapterManager.paid_customerTableAdapter = null;
            this.tableAdapterManager.paid_to_supplierTableAdapter = null;
            this.tableAdapterManager.StoreTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JBS2.johnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Show_all_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 511);
            this.Controls.Add(this.Choose_emp_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_comboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Show_all_employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض بيانات جميع الموظفين";
            this.Load += new System.EventHandler(this.Show_all_employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.johnDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emp_IDTextBox;
        private System.Windows.Forms.TextBox emp_nameTextBox;
        private System.Windows.Forms.TextBox emp_Personal_IDTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox emp_AddTextBox;
        private System.Windows.Forms.DateTimePicker hire_dateDateTimePicker;
        private System.Windows.Forms.TextBox sallaryTextBox;
        private System.Windows.Forms.TextBox bounusTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox penalties_DaysTextBox;
        private System.Windows.Forms.TextBox avaliable_Absence_DaysTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox emp_User_nameTextBox;
        private System.Windows.Forms.TextBox user_PwdTextBox;
        private System.Windows.Forms.PictureBox Emp_pictureBox;
        private System.Windows.Forms.Button brows_empPic_button;
        private System.Windows.Forms.ComboBox Employee_comboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Choose_emp_button;
        private johnDataSet johnDataSet;
        private johnDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private johnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ComboBox Type_comboBox;
    }
}