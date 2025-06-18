namespace GUI
{
    partial class FrmSanPham
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaLoai = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMota = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.guna2ButtonXoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonThêm = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHinhAnh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbMaNCC = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaNCC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHinhAnh);
            this.groupBox2.Controls.Add(this.cbbMaLoai);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMota);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(13, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(609, 327);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý sản phẩm";
            // 
            // cbbMaLoai
            // 
            this.cbbMaLoai.ForeColor = System.Drawing.Color.Black;
            this.cbbMaLoai.FormattingEnabled = true;
            this.cbbMaLoai.ItemHeight = 23;
            this.cbbMaLoai.Location = new System.Drawing.Point(24, 274);
            this.cbbMaLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaLoai.Name = "cbbMaLoai";
            this.cbbMaLoai.Size = new System.Drawing.Size(310, 29);
            this.cbbMaLoai.TabIndex = 7;
            this.cbbMaLoai.UseSelectable = true;
            this.cbbMaLoai.SelectedValueChanged += new System.EventHandler(this.cbbMaLoai_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtMota
            // 
            this.txtMota.BorderColor = System.Drawing.Color.DarkRed;
            this.txtMota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMota.DefaultText = "";
            this.txtMota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMota.ForeColor = System.Drawing.Color.Black;
            this.txtMota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMota.Location = new System.Drawing.Point(20, 179);
            this.txtMota.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMota.Name = "txtMota";
            this.txtMota.PasswordChar = '\0';
            this.txtMota.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMota.PlaceholderText = "";
            this.txtMota.SelectedText = "";
            this.txtMota.Size = new System.Drawing.Size(314, 42);
            this.txtMota.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderColor = System.Drawing.Color.DarkRed;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(22, 85);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(542, 42);
            this.txtTenSP.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.guna2ButtonXoa);
            this.groupBox5.Controls.Add(this.guna2ButtonDong);
            this.groupBox5.Controls.Add(this.guna2ButtonThêm);
            this.groupBox5.Controls.Add(this.btnCapNhat);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox5.Location = new System.Drawing.Point(13, 339);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(609, 184);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // guna2ButtonXoa
            // 
            this.guna2ButtonXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonXoa.FillColor = System.Drawing.Color.DarkRed;
            this.guna2ButtonXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonXoa.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonXoa.Location = new System.Drawing.Point(316, 101);
            this.guna2ButtonXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ButtonXoa.Name = "guna2ButtonXoa";
            this.guna2ButtonXoa.Size = new System.Drawing.Size(248, 52);
            this.guna2ButtonXoa.TabIndex = 0;
            this.guna2ButtonXoa.Text = "Xóa";
            this.guna2ButtonXoa.Click += new System.EventHandler(this.guna2ButtonXoa_Click);
            // 
            // guna2ButtonDong
            // 
            this.guna2ButtonDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDong.FillColor = System.Drawing.Color.Silver;
            this.guna2ButtonDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonDong.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonDong.Location = new System.Drawing.Point(42, 101);
            this.guna2ButtonDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ButtonDong.Name = "guna2ButtonDong";
            this.guna2ButtonDong.Size = new System.Drawing.Size(248, 52);
            this.guna2ButtonDong.TabIndex = 0;
            this.guna2ButtonDong.Text = "Đóng";
            this.guna2ButtonDong.Click += new System.EventHandler(this.guna2ButtonDong_Click);
            // 
            // guna2ButtonThêm
            // 
            this.guna2ButtonThêm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonThêm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonThêm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonThêm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonThêm.FillColor = System.Drawing.Color.DarkRed;
            this.guna2ButtonThêm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonThêm.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonThêm.Location = new System.Drawing.Point(316, 39);
            this.guna2ButtonThêm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ButtonThêm.Name = "guna2ButtonThêm";
            this.guna2ButtonThêm.Size = new System.Drawing.Size(248, 52);
            this.guna2ButtonThêm.TabIndex = 0;
            this.guna2ButtonThêm.Text = "Thêm";
            this.guna2ButtonThêm.Click += new System.EventHandler(this.guna2ButtonThêm_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(42, 39);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(248, 52);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(629, 12);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.RowHeadersWidth = 62;
            this.dataGridViewSP.RowTemplate.Height = 28;
            this.dataGridViewSP.Size = new System.Drawing.Size(731, 565);
            this.dataGridViewSP.TabIndex = 20;
            this.dataGridViewSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSP_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(353, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hình ảnh";
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.BorderColor = System.Drawing.Color.DarkRed;
            this.txtHinhAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHinhAnh.DefaultText = "";
            this.txtHinhAnh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHinhAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHinhAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHinhAnh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHinhAnh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHinhAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHinhAnh.ForeColor = System.Drawing.Color.Black;
            this.txtHinhAnh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHinhAnh.Location = new System.Drawing.Point(355, 179);
            this.txtHinhAnh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.PasswordChar = '\0';
            this.txtHinhAnh.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtHinhAnh.PlaceholderText = "";
            this.txtHinhAnh.SelectedText = "";
            this.txtHinhAnh.Size = new System.Drawing.Size(205, 42);
            this.txtHinhAnh.TabIndex = 8;
            // 
            // cbbMaNCC
            // 
            this.cbbMaNCC.ForeColor = System.Drawing.Color.Black;
            this.cbbMaNCC.FormattingEnabled = true;
            this.cbbMaNCC.ItemHeight = 23;
            this.cbbMaNCC.Location = new System.Drawing.Point(348, 274);
            this.cbbMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaNCC.Name = "cbbMaNCC";
            this.cbbMaNCC.Size = new System.Drawing.Size(208, 29);
            this.cbbMaNCC.TabIndex = 11;
            this.cbbMaNCC.UseSelectable = true;
            this.cbbMaNCC.SelectedValueChanged += new System.EventHandler(this.cbbMaNCC_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(353, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Nhà cung cấp";
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 576);
            this.Controls.Add(this.dataGridViewSP);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cbbMaLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMota;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonXoa;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDong;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonThêm;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private MetroFramework.Controls.MetroComboBox cbbMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtHinhAnh;
        private System.Windows.Forms.DataGridView dataGridViewSP;
    }
}