
namespace GUI
{
    partial class FrmPofile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPofile));
            this.dgvND = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnQuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.txtDN = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ckHienThi = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtNhapLaiPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassOld = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCapNhatPass = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ckPassOld = new System.Windows.Forms.GroupBox();
            this.cbbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCapNhatQuyen = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ckPassOld.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvND
            // 
            this.dgvND.AllowUserToAddRows = false;
            this.dgvND.AllowUserToDeleteRows = false;
            this.dgvND.AllowUserToResizeColumns = false;
            this.dgvND.BackgroundColor = System.Drawing.Color.White;
            this.dgvND.ColumnHeadersHeight = 25;
            this.dgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvND.Location = new System.Drawing.Point(25, 49);
            this.dgvND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvND.Name = "dgvND";
            this.dgvND.RowHeadersWidth = 51;
            this.dgvND.Size = new System.Drawing.Size(637, 506);
            this.dgvND.TabIndex = 0;
            this.dgvND.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvND_CellContentClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(295, 43);
            this.guna2HtmlLabel1.TabIndex = 46;
            this.guna2HtmlLabel1.Text = "Thông tin người dùng";
            // 
            // btnQuyen
            // 
            this.btnQuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuyen.FillColor = System.Drawing.Color.Green;
            this.btnQuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyen.ForeColor = System.Drawing.Color.Black;
            this.btnQuyen.Location = new System.Drawing.Point(284, 118);
            this.btnQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuyen.Name = "btnQuyen";
            this.btnQuyen.Size = new System.Drawing.Size(220, 42);
            this.btnQuyen.TabIndex = 0;
            this.btnQuyen.Text = "Quyền";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.DarkRed;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(161, 128);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(220, 42);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtDN
            // 
            this.txtDN.BorderColor = System.Drawing.Color.DarkRed;
            this.txtDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDN.DefaultText = "";
            this.txtDN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDN.Location = new System.Drawing.Point(27, 87);
            this.txtDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDN.Name = "txtDN";
            this.txtDN.PasswordChar = '\0';
            this.txtDN.PlaceholderText = "";
            this.txtDN.SelectedText = "";
            this.txtDN.Size = new System.Drawing.Size(483, 33);
            this.txtDN.TabIndex = 1;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1239, -1);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Azure;
            this.guna2ControlBox2.Size = new System.Drawing.Size(48, 36);
            this.guna2ControlBox2.TabIndex = 53;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDN);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.guna2HtmlLabel4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(713, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(541, 188);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(27, 52);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(133, 30);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Tên đăng nhập";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1195, -1);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(48, 36);
            this.guna2ControlBox3.TabIndex = 52;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1285, -1);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 51;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvND);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(16, 316);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(689, 582);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách tài khoản";
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(315, 247);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(91, 30);
            this.lbUserName.TabIndex = 55;
            this.lbUserName.Text = "userName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2CheckBox2);
            this.groupBox1.Controls.Add(this.ckHienThi);
            this.groupBox1.Controls.Add(this.txtNhapLaiPass);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.txtPassOld);
            this.groupBox1.Controls.Add(this.btnCapNhatPass);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(713, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(541, 457);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảo mật";
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 0;
            this.guna2CheckBox2.CheckedState.BorderThickness = 0;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox2.Location = new System.Drawing.Point(27, 110);
            this.guna2CheckBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(188, 32);
            this.guna2CheckBox2.TabIndex = 13;
            this.guna2CheckBox2.Text = "Hiển thị mật khẩu";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // ckHienThi
            // 
            this.ckHienThi.AutoSize = true;
            this.ckHienThi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckHienThi.CheckedState.BorderRadius = 0;
            this.ckHienThi.CheckedState.BorderThickness = 0;
            this.ckHienThi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckHienThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckHienThi.Location = new System.Drawing.Point(40, 313);
            this.ckHienThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckHienThi.Name = "ckHienThi";
            this.ckHienThi.Size = new System.Drawing.Size(188, 32);
            this.ckHienThi.TabIndex = 13;
            this.ckHienThi.Text = "Hiển thị mật khẩu";
            this.ckHienThi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckHienThi.UncheckedState.BorderRadius = 0;
            this.ckHienThi.UncheckedState.BorderThickness = 0;
            this.ckHienThi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckHienThi.CheckedChanged += new System.EventHandler(this.ckHienThi_CheckedChanged);
            // 
            // txtNhapLaiPass
            // 
            this.txtNhapLaiPass.BorderColor = System.Drawing.Color.DarkRed;
            this.txtNhapLaiPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiPass.DefaultText = "";
            this.txtNhapLaiPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLaiPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLaiPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhapLaiPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiPass.Location = new System.Drawing.Point(27, 271);
            this.txtNhapLaiPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapLaiPass.Name = "txtNhapLaiPass";
            this.txtNhapLaiPass.PasswordChar = '\0';
            this.txtNhapLaiPass.PlaceholderText = "";
            this.txtNhapLaiPass.SelectedText = "";
            this.txtNhapLaiPass.Size = new System.Drawing.Size(483, 34);
            this.txtNhapLaiPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderColor = System.Drawing.Color.DarkRed;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.Location = new System.Drawing.Point(27, 202);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.Size = new System.Drawing.Size(483, 34);
            this.txtNewPass.TabIndex = 4;
            // 
            // txtPassOld
            // 
            this.txtPassOld.BorderColor = System.Drawing.Color.DarkRed;
            this.txtPassOld.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassOld.DefaultText = "";
            this.txtPassOld.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassOld.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassOld.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassOld.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassOld.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassOld.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassOld.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassOld.Location = new System.Drawing.Point(27, 66);
            this.txtPassOld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.PasswordChar = '\0';
            this.txtPassOld.PlaceholderText = "";
            this.txtPassOld.SelectedText = "";
            this.txtPassOld.Size = new System.Drawing.Size(483, 33);
            this.txtPassOld.TabIndex = 1;
            // 
            // btnCapNhatPass
            // 
            this.btnCapNhatPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatPass.FillColor = System.Drawing.Color.DarkRed;
            this.btnCapNhatPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatPass.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatPass.Location = new System.Drawing.Point(161, 382);
            this.btnCapNhatPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatPass.Name = "btnCapNhatPass";
            this.btnCapNhatPass.Size = new System.Drawing.Size(220, 42);
            this.btnCapNhatPass.TabIndex = 0;
            this.btnCapNhatPass.Text = "Cập nhật";
            this.btnCapNhatPass.Click += new System.EventHandler(this.btnCapNhatPass_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(27, 235);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(201, 30);
            this.guna2HtmlLabel6.TabIndex = 0;
            this.guna2HtmlLabel6.Text = "Nhập lại mật khẩu mới";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(27, 31);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(110, 30);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Mật khẩu cũ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(27, 166);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 30);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Mật khẩu mới";
            // 
            // ckPassOld
            // 
            this.ckPassOld.Controls.Add(this.cbbRole);
            this.ckPassOld.Controls.Add(this.btnCapNhatQuyen);
            this.ckPassOld.Controls.Add(this.btnQuyen);
            this.ckPassOld.Controls.Add(this.guna2HtmlLabel8);
            this.ckPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPassOld.ForeColor = System.Drawing.Color.DarkRed;
            this.ckPassOld.Location = new System.Drawing.Point(713, 702);
            this.ckPassOld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckPassOld.Name = "ckPassOld";
            this.ckPassOld.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckPassOld.Size = new System.Drawing.Size(541, 197);
            this.ckPassOld.TabIndex = 48;
            this.ckPassOld.TabStop = false;
            this.ckPassOld.Text = "Quyền";
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
            this.cbbRole.Location = new System.Drawing.Point(27, 66);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(476, 36);
            this.cbbRole.TabIndex = 5;
            // 
            // btnCapNhatQuyen
            // 
            this.btnCapNhatQuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhatQuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatQuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhatQuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhatQuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhatQuyen.FillColor = System.Drawing.Color.DarkRed;
            this.btnCapNhatQuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatQuyen.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatQuyen.Location = new System.Drawing.Point(27, 118);
            this.btnCapNhatQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatQuyen.Name = "btnCapNhatQuyen";
            this.btnCapNhatQuyen.Size = new System.Drawing.Size(220, 42);
            this.btnCapNhatQuyen.TabIndex = 0;
            this.btnCapNhatQuyen.Text = "Cập nhật";
            this.btnCapNhatQuyen.Click += new System.EventHandler(this.btnCapNhatQuyen_Click);
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(27, 31);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(60, 30);
            this.guna2HtmlLabel8.TabIndex = 0;
            this.guna2HtmlLabel8.Text = "Quyền";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(150, 150);
            this.guna2ImageButton1.Location = new System.Drawing.Point(224, 64);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(283, 176);
            this.guna2ImageButton1.TabIndex = 54;
            // 
            // FrmPofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 913);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ckPassOld);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPofile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPofile";
            this.Load += new System.EventHandler(this.FrmPofile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ckPassOld.ResumeLayout(false);
            this.ckPassOld.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvND;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2TextBox txtDN;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button btnQuyen;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPassOld;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.GroupBox ckPassOld;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRole;
        private Guna.UI2.WinForms.Guna2Button btnCapNhatQuyen;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2CheckBox ckHienThi;
    }
}