
namespace GUI
{
    partial class FrmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchNameStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DTPDateWork = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCode = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddressStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DTPBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCodeCV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtStaffName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStaffCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchNameStaff);
            this.groupBox1.Controls.Add(this.guna2ImageButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(41, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearchNameStaff
            // 
            this.txtSearchNameStaff.BackColor = System.Drawing.Color.White;
            this.txtSearchNameStaff.BorderColor = System.Drawing.Color.DarkRed;
            this.txtSearchNameStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNameStaff.DefaultText = "";
            this.txtSearchNameStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchNameStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchNameStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNameStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNameStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNameStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchNameStaff.ForeColor = System.Drawing.Color.Black;
            this.txtSearchNameStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNameStaff.Location = new System.Drawing.Point(133, 22);
            this.txtSearchNameStaff.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchNameStaff.Name = "txtSearchNameStaff";
            this.txtSearchNameStaff.PasswordChar = '\0';
            this.txtSearchNameStaff.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchNameStaff.PlaceholderText = "";
            this.txtSearchNameStaff.SelectedText = "";
            this.txtSearchNameStaff.Size = new System.Drawing.Size(400, 43);
            this.txtSearchNameStaff.TabIndex = 1;
            this.txtSearchNameStaff.TextChanged += new System.EventHandler(this.txtMaEvent_TextChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(52, 31);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(72, 36);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1297, -1);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Azure;
            this.guna2ControlBox2.Size = new System.Drawing.Size(44, 36);
            this.guna2ControlBox2.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbRole);
            this.groupBox2.Controls.Add(this.DTPDateWork);
            this.groupBox2.Controls.Add(this.btnCode);
            this.groupBox2.Controls.Add(this.txtAddressStaff);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbSex);
            this.groupBox2.Controls.Add(this.DTPBirth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbCodeCV);
            this.groupBox2.Controls.Add(this.txtStaffName);
            this.groupBox2.Controls.Add(this.txtPhoneStaff);
            this.groupBox2.Controls.Add(this.txtStaffCode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(41, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(541, 480);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.DarkRed;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(30, 356);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(474, 34);
            this.txtEmail.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(25, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 28);
            this.label11.TabIndex = 43;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(279, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 28);
            this.label10.TabIndex = 42;
            this.label10.Text = "Mã quyền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 28);
            this.label9.TabIndex = 41;
            this.label9.Text = "Mã chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(264, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 40;
            this.label8.Text = "Ngày vào làm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 28);
            this.label7.TabIndex = 39;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(181, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Địa chỉ";
            // 
            // cbbRole
            // 
            this.cbbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbbRole.BorderColor = System.Drawing.Color.DarkRed;
            this.cbbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbRole.ItemHeight = 30;
            this.cbbRole.Location = new System.Drawing.Point(284, 424);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(252, 36);
            this.cbbRole.TabIndex = 36;
            // 
            // DTPDateWork
            // 
            this.DTPDateWork.Checked = true;
            this.DTPDateWork.FillColor = System.Drawing.Color.White;
            this.DTPDateWork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPDateWork.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPDateWork.Location = new System.Drawing.Point(269, 285);
            this.DTPDateWork.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPDateWork.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPDateWork.Name = "DTPDateWork";
            this.DTPDateWork.Size = new System.Drawing.Size(239, 33);
            this.DTPDateWork.TabIndex = 34;
            this.DTPDateWork.Value = new System.DateTime(2025, 5, 29, 0, 39, 52, 896);
            // 
            // btnCode
            // 
            this.btnCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCode.FillColor = System.Drawing.Color.DarkRed;
            this.btnCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCode.ForeColor = System.Drawing.Color.White;
            this.btnCode.Location = new System.Drawing.Point(319, 50);
            this.btnCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(149, 42);
            this.btnCode.TabIndex = 1;
            this.btnCode.Text = "Tạo mã";
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // txtAddressStaff
            // 
            this.txtAddressStaff.BorderColor = System.Drawing.Color.DarkRed;
            this.txtAddressStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddressStaff.DefaultText = "";
            this.txtAddressStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddressStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddressStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddressStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddressStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddressStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddressStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddressStaff.Location = new System.Drawing.Point(186, 201);
            this.txtAddressStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddressStaff.Name = "txtAddressStaff";
            this.txtAddressStaff.PasswordChar = '\0';
            this.txtAddressStaff.PlaceholderText = "";
            this.txtAddressStaff.SelectedText = "";
            this.txtAddressStaff.Size = new System.Drawing.Size(315, 33);
            this.txtAddressStaff.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(300, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Họ tên";
            // 
            // cbbSex
            // 
            this.cbbSex.BackColor = System.Drawing.Color.Transparent;
            this.cbbSex.BorderColor = System.Drawing.Color.DarkRed;
            this.cbbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSex.ItemHeight = 30;
            this.cbbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSex.Location = new System.Drawing.Point(24, 201);
            this.cbbSex.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(135, 36);
            this.cbbSex.TabIndex = 26;
            // 
            // DTPBirth
            // 
            this.DTPBirth.Checked = true;
            this.DTPBirth.FillColor = System.Drawing.Color.White;
            this.DTPBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPBirth.Location = new System.Drawing.Point(26, 128);
            this.DTPBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPBirth.Name = "DTPBirth";
            this.DTPBirth.Size = new System.Drawing.Size(272, 33);
            this.DTPBirth.TabIndex = 25;
            this.DTPBirth.Value = new System.DateTime(2025, 5, 29, 0, 39, 52, 896);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã nhân viên";
            // 
            // cbbCodeCV
            // 
            this.cbbCodeCV.BackColor = System.Drawing.Color.Transparent;
            this.cbbCodeCV.BorderColor = System.Drawing.Color.DarkRed;
            this.cbbCodeCV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCodeCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCodeCV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCodeCV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCodeCV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCodeCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbCodeCV.ItemHeight = 30;
            this.cbbCodeCV.Location = new System.Drawing.Point(24, 424);
            this.cbbCodeCV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCodeCV.Name = "cbbCodeCV";
            this.cbbCodeCV.Size = new System.Drawing.Size(252, 36);
            this.cbbCodeCV.TabIndex = 2;
            // 
            // txtStaffName
            // 
            this.txtStaffName.BorderColor = System.Drawing.Color.DarkRed;
            this.txtStaffName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffName.DefaultText = "";
            this.txtStaffName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStaffName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStaffName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStaffName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStaffName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStaffName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStaffName.Location = new System.Drawing.Point(305, 128);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.PasswordChar = '\0';
            this.txtStaffName.PlaceholderText = "";
            this.txtStaffName.SelectedText = "";
            this.txtStaffName.Size = new System.Drawing.Size(213, 33);
            this.txtStaffName.TabIndex = 1;
            // 
            // txtPhoneStaff
            // 
            this.txtPhoneStaff.BorderColor = System.Drawing.Color.DarkRed;
            this.txtPhoneStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneStaff.DefaultText = "";
            this.txtPhoneStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneStaff.Location = new System.Drawing.Point(29, 285);
            this.txtPhoneStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneStaff.Name = "txtPhoneStaff";
            this.txtPhoneStaff.PasswordChar = '\0';
            this.txtPhoneStaff.PlaceholderText = "";
            this.txtPhoneStaff.SelectedText = "";
            this.txtPhoneStaff.Size = new System.Drawing.Size(217, 34);
            this.txtPhoneStaff.TabIndex = 1;
            // 
            // txtStaffCode
            // 
            this.txtStaffCode.BorderColor = System.Drawing.Color.DarkRed;
            this.txtStaffCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffCode.DefaultText = "";
            this.txtStaffCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStaffCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStaffCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStaffCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStaffCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStaffCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStaffCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStaffCode.Location = new System.Drawing.Point(27, 58);
            this.txtStaffCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffCode.Name = "txtStaffCode";
            this.txtStaffCode.PasswordChar = '\0';
            this.txtStaffCode.PlaceholderText = "";
            this.txtStaffCode.SelectedText = "";
            this.txtStaffCode.Size = new System.Drawing.Size(180, 34);
            this.txtStaffCode.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1337, -1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(51, 36);
            this.guna2ControlBox1.TabIndex = 19;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1254, -1);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(44, 36);
            this.guna2ControlBox3.TabIndex = 20;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.ColumnHeadersHeight = 40;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaff.Location = new System.Drawing.Point(8, 32);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.Size = new System.Drawing.Size(723, 642);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvStaff);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(621, 85);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(739, 697);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách nhân viên";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStaff.FillColor = System.Drawing.Color.DarkRed;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(281, 31);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(220, 42);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Thêm";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateStaff.FillColor = System.Drawing.Color.DarkRed;
            this.btnUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStaff.Location = new System.Drawing.Point(37, 31);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(220, 42);
            this.btnUpdateStaff.TabIndex = 0;
            this.btnUpdateStaff.Text = "Cập nhật";
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelStaff.FillColor = System.Drawing.Color.DarkRed;
            this.btnDelStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStaff.ForeColor = System.Drawing.Color.White;
            this.btnDelStaff.Location = new System.Drawing.Point(281, 81);
            this.btnDelStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(220, 42);
            this.btnDelStaff.TabIndex = 0;
            this.btnDelStaff.Text = "Xóa";
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(37, 81);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(220, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Đóng";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelStaff);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.btnAddStaff);
            this.groupBox3.Controls.Add(this.btnUpdateStaff);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(44, 649);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(541, 147);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator1.Location = new System.Drawing.Point(41, 55);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1319, 22);
            this.guna2Separator1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 798);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvent";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNameStaff;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtStaffName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneStaff;
        private Guna.UI2.WinForms.Guna2TextBox txtStaffCode;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button btnAddStaff;
        private Guna.UI2.WinForms.Guna2Button btnUpdateStaff;
        private Guna.UI2.WinForms.Guna2Button btnDelStaff;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCodeCV;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSex;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPBirth;
        private Guna.UI2.WinForms.Guna2Button btnCode;
        private Guna.UI2.WinForms.Guna2TextBox txtAddressStaff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPDateWork;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label11;
    }
}