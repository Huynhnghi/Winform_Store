namespace GUI
{
    partial class frmQuanLyDanhMuc
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
            this.cbbParentId = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXuatsu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.guna2ButtonXoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonThêm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewLoaiSP = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbParentId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtXuatsu);
            this.groupBox2.Controls.Add(this.txtTenLoai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(33, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(609, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý danh mục";
            // 
            // cbbParentId
            // 
            this.cbbParentId.ForeColor = System.Drawing.Color.Black;
            this.cbbParentId.FormattingEnabled = true;
            this.cbbParentId.ItemHeight = 23;
            this.cbbParentId.Location = new System.Drawing.Point(24, 274);
            this.cbbParentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbParentId.Name = "cbbParentId";
            this.cbbParentId.Size = new System.Drawing.Size(540, 29);
            this.cbbParentId.TabIndex = 7;
            this.cbbParentId.UseSelectable = true;
            this.cbbParentId.SelectedIndexChanged += new System.EventHandler(this.cbbParentId_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Danh mục cha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xuất xứ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại";
            // 
            // txtXuatsu
            // 
            this.txtXuatsu.BorderColor = System.Drawing.Color.DarkRed;
            this.txtXuatsu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXuatsu.DefaultText = "";
            this.txtXuatsu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXuatsu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXuatsu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatsu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatsu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatsu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtXuatsu.ForeColor = System.Drawing.Color.Black;
            this.txtXuatsu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatsu.Location = new System.Drawing.Point(20, 179);
            this.txtXuatsu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtXuatsu.Name = "txtXuatsu";
            this.txtXuatsu.PasswordChar = '\0';
            this.txtXuatsu.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtXuatsu.PlaceholderText = "";
            this.txtXuatsu.SelectedText = "";
            this.txtXuatsu.Size = new System.Drawing.Size(544, 42);
            this.txtXuatsu.TabIndex = 1;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BorderColor = System.Drawing.Color.DarkRed;
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.DefaultText = "";
            this.txtTenLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLoai.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.Location = new System.Drawing.Point(22, 85);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.PasswordChar = '\0';
            this.txtTenLoai.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenLoai.PlaceholderText = "";
            this.txtTenLoai.SelectedText = "";
            this.txtTenLoai.Size = new System.Drawing.Size(542, 42);
            this.txtTenLoai.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.guna2ButtonXoa);
            this.groupBox5.Controls.Add(this.guna2ButtonDong);
            this.groupBox5.Controls.Add(this.guna2ButtonThêm);
            this.groupBox5.Controls.Add(this.guna2Button4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox5.Location = new System.Drawing.Point(33, 383);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(609, 184);
            this.groupBox5.TabIndex = 18;
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
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(42, 39);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(248, 52);
            this.guna2Button4.TabIndex = 0;
            this.guna2Button4.Text = "Cập nhật";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // dataGridViewLoaiSP
            // 
            this.dataGridViewLoaiSP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiSP.Location = new System.Drawing.Point(682, 38);
            this.dataGridViewLoaiSP.Name = "dataGridViewLoaiSP";
            this.dataGridViewLoaiSP.RowHeadersWidth = 62;
            this.dataGridViewLoaiSP.RowTemplate.Height = 28;
            this.dataGridViewLoaiSP.Size = new System.Drawing.Size(634, 549);
            this.dataGridViewLoaiSP.TabIndex = 19;
            this.dataGridViewLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiSP_CellClick);
            this.dataGridViewLoaiSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiSP_CellContentClick);
            // 
            // frmQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 610);
            this.Controls.Add(this.dataGridViewLoaiSP);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmQuanLyDanhMuc";
            this.Text = "frmQuanLyDanhMuc";
            this.Load += new System.EventHandler(this.frmQuanLyDanhMuc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cbbParentId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtXuatsu;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoai;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonXoa;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDong;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonThêm;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.DataGridView dataGridViewLoaiSP;
    }
}