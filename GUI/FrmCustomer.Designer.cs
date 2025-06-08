
namespace GUI
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Search = new Guna.UI2.WinForms.Guna2ImageButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DTPBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbTypeCus = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandomCusCode = new Guna.UI2.WinForms.Guna2Button();
            this.txtCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddressCus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneCus = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelCus = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCus = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchCusName);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(33, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearchCusName
            // 
            this.txtSearchCusName.BackColor = System.Drawing.Color.White;
            this.txtSearchCusName.BorderColor = System.Drawing.Color.DarkRed;
            this.txtSearchCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCusName.DefaultText = "";
            this.txtSearchCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCusName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCusName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCusName.Location = new System.Drawing.Point(132, 60);
            this.txtSearchCusName.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchCusName.Name = "txtSearchCusName";
            this.txtSearchCusName.PasswordChar = '\0';
            this.txtSearchCusName.PlaceholderText = "";
            this.txtSearchCusName.SelectedText = "";
            this.txtSearchCusName.Size = new System.Drawing.Size(400, 58);
            this.txtSearchCusName.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Search.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_Search.ImageRotate = 0F;
            this.btn_Search.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Search.Location = new System.Drawing.Point(37, 52);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Search.Size = new System.Drawing.Size(85, 66);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DTPBirth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbbTypeCus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRandomCusCode);
            this.groupBox2.Controls.Add(this.txtCusName);
            this.groupBox2.Controls.Add(this.txtAddressCus);
            this.groupBox2.Controls.Add(this.txtPhoneCus);
            this.groupBox2.Controls.Add(this.txtCusCode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(33, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(541, 354);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // DTPBirth
            // 
            this.DTPBirth.Checked = true;
            this.DTPBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DTPBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTPBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPBirth.Location = new System.Drawing.Point(17, 286);
            this.DTPBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTPBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTPBirth.Name = "DTPBirth";
            this.DTPBirth.Size = new System.Drawing.Size(285, 36);
            this.DTPBirth.TabIndex = 10;
            this.DTPBirth.Value = new System.DateTime(2025, 6, 5, 3, 3, 50, 731);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày sinh";
            // 
            // cbbTypeCus
            // 
            this.cbbTypeCus.ForeColor = System.Drawing.Color.Black;
            this.cbbTypeCus.FormattingEnabled = true;
            this.cbbTypeCus.ItemHeight = 24;
            this.cbbTypeCus.Location = new System.Drawing.Point(301, 215);
            this.cbbTypeCus.Name = "cbbTypeCus";
            this.cbbTypeCus.Size = new System.Drawing.Size(217, 30);
            this.cbbTypeCus.TabIndex = 7;
            this.cbbTypeCus.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(306, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(307, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // btnRandomCusCode
            // 
            this.btnRandomCusCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRandomCusCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRandomCusCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRandomCusCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRandomCusCode.FillColor = System.Drawing.Color.DarkRed;
            this.btnRandomCusCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomCusCode.ForeColor = System.Drawing.Color.White;
            this.btnRandomCusCode.Location = new System.Drawing.Point(301, 60);
            this.btnRandomCusCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandomCusCode.Name = "btnRandomCusCode";
            this.btnRandomCusCode.Size = new System.Drawing.Size(181, 42);
            this.btnRandomCusCode.TabIndex = 1;
            this.btnRandomCusCode.Text = "Tạo mã";
            this.btnRandomCusCode.Click += new System.EventHandler(this.btnRandomCusCode_Click);
            // 
            // txtCusName
            // 
            this.txtCusName.BorderColor = System.Drawing.Color.DarkRed;
            this.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusName.DefaultText = "";
            this.txtCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusName.ForeColor = System.Drawing.Color.Black;
            this.txtCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Location = new System.Drawing.Point(18, 143);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCusName.PlaceholderText = "";
            this.txtCusName.SelectedText = "";
            this.txtCusName.Size = new System.Drawing.Size(273, 34);
            this.txtCusName.TabIndex = 1;
            // 
            // txtAddressCus
            // 
            this.txtAddressCus.BorderColor = System.Drawing.Color.DarkRed;
            this.txtAddressCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddressCus.DefaultText = "";
            this.txtAddressCus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddressCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddressCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddressCus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddressCus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddressCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddressCus.ForeColor = System.Drawing.Color.Black;
            this.txtAddressCus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddressCus.Location = new System.Drawing.Point(17, 215);
            this.txtAddressCus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddressCus.Name = "txtAddressCus";
            this.txtAddressCus.PasswordChar = '\0';
            this.txtAddressCus.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAddressCus.PlaceholderText = "";
            this.txtAddressCus.SelectedText = "";
            this.txtAddressCus.Size = new System.Drawing.Size(273, 34);
            this.txtAddressCus.TabIndex = 1;
            // 
            // txtPhoneCus
            // 
            this.txtPhoneCus.BorderColor = System.Drawing.Color.DarkRed;
            this.txtPhoneCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneCus.DefaultText = "";
            this.txtPhoneCus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneCus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneCus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneCus.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneCus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneCus.Location = new System.Drawing.Point(302, 143);
            this.txtPhoneCus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneCus.Name = "txtPhoneCus";
            this.txtPhoneCus.PasswordChar = '\0';
            this.txtPhoneCus.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPhoneCus.PlaceholderText = "";
            this.txtPhoneCus.SelectedText = "";
            this.txtPhoneCus.Size = new System.Drawing.Size(217, 34);
            this.txtPhoneCus.TabIndex = 1;
            // 
            // txtCusCode
            // 
            this.txtCusCode.BorderColor = System.Drawing.Color.DarkRed;
            this.txtCusCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusCode.DefaultText = "";
            this.txtCusCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusCode.ForeColor = System.Drawing.Color.Black;
            this.txtCusCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusCode.Location = new System.Drawing.Point(20, 68);
            this.txtCusCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusCode.Name = "txtCusCode";
            this.txtCusCode.PasswordChar = '\0';
            this.txtCusCode.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCusCode.PlaceholderText = "";
            this.txtCusCode.SelectedText = "";
            this.txtCusCode.Size = new System.Drawing.Size(217, 34);
            this.txtCusCode.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelCus);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.btnAddCus);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(33, 609);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(541, 152);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnDelCus
            // 
            this.btnDelCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelCus.FillColor = System.Drawing.Color.DarkRed;
            this.btnDelCus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCus.ForeColor = System.Drawing.Color.White;
            this.btnDelCus.Location = new System.Drawing.Point(298, 50);
            this.btnDelCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelCus.Name = "btnDelCus";
            this.btnDelCus.Size = new System.Drawing.Size(220, 42);
            this.btnDelCus.TabIndex = 0;
            this.btnDelCus.Text = "Xóa";
            this.btnDelCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
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
            this.btnBack.Location = new System.Drawing.Point(173, 100);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(220, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Đóng";
            // 
            // btnAddCus
            // 
            this.btnAddCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCus.FillColor = System.Drawing.Color.DarkRed;
            this.btnAddCus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.Color.White;
            this.btnAddCus.Location = new System.Drawing.Point(20, 50);
            this.btnAddCus.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(220, 42);
            this.btnAddCus.TabIndex = 0;
            this.btnAddCus.Text = "Thêm";
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvKH);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(611, 79);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(739, 665);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách khách hàng";
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(24, 47);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 60;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(689, 597);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1339, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(49, 36);
            this.guna2ControlBox1.TabIndex = 5;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1298, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Azure;
            this.guna2ControlBox2.Size = new System.Drawing.Size(43, 36);
            this.guna2ControlBox2.TabIndex = 5;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1248, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(49, 36);
            this.guna2ControlBox3.TabIndex = 5;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator1.Location = new System.Drawing.Point(33, 59);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1308, 25);
            this.guna2Separator1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 798);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCusName;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtCusName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneCus;
        private Guna.UI2.WinForms.Guna2TextBox txtCusCode;
        private Guna.UI2.WinForms.Guna2TextBox txtAddressCus;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Button btnDelCus;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnAddCus;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnRandomCusCode;
        private MetroFramework.Controls.MetroComboBox cbbTypeCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTPBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvKH;
    }
}