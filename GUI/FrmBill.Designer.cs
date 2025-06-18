
namespace GUI
{
    partial class FrmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBill));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvBTC = new System.Windows.Forms.DataGridView();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTKVSK = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxCapNhatTrangThai = new System.Windows.Forms.ComboBox();
            this.cbBoxTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBTC)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1220, -4);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(53, 45);
            this.guna2ControlBox1.TabIndex = 27;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // dgvBTC
            // 
            this.dgvBTC.AllowUserToAddRows = false;
            this.dgvBTC.AllowUserToDeleteRows = false;
            this.dgvBTC.AllowUserToResizeColumns = false;
            this.dgvBTC.BackgroundColor = System.Drawing.Color.White;
            this.dgvBTC.ColumnHeadersHeight = 25;
            this.dgvBTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBTC.Location = new System.Drawing.Point(9, 39);
            this.dgvBTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBTC.Name = "dgvBTC";
            this.dgvBTC.RowHeadersWidth = 51;
            this.dgvBTC.Size = new System.Drawing.Size(1461, 485);
            this.dgvBTC.TabIndex = 0;
            this.dgvBTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBTC_CellClick);
            this.dgvBTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBTC_CellContentClick);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1128, -4);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(44, 45);
            this.guna2ControlBox3.TabIndex = 28;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvBTC);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox4.Location = new System.Drawing.Point(15, 209);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1479, 542);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(461, 82);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(248, 52);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Đổi hàng";
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
            this.guna2Button4.Location = new System.Drawing.Point(116, 82);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(248, 52);
            this.guna2Button4.TabIndex = 0;
            this.guna2Button4.Text = "Xóa";
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Silver;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(820, 82);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(248, 52);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Làm mới";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 19);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(266, 50);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Quản lý hóa đơn";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1172, -4);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Azure;
            this.guna2ControlBox2.Size = new System.Drawing.Size(47, 45);
            this.guna2ControlBox2.TabIndex = 29;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.guna2Button4);
            this.groupBox3.Controls.Add(this.guna2Button3);
            this.groupBox3.Controls.Add(this.guna2Button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(15, 784);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1204, 186);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtTKVSK
            // 
            this.txtTKVSK.BackColor = System.Drawing.Color.White;
            this.txtTKVSK.BorderColor = System.Drawing.Color.DarkRed;
            this.txtTKVSK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKVSK.DefaultText = "";
            this.txtTKVSK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTKVSK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTKVSK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKVSK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKVSK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKVSK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKVSK.ForeColor = System.Drawing.Color.White;
            this.txtTKVSK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKVSK.Location = new System.Drawing.Point(147, 26);
            this.txtTKVSK.Margin = new System.Windows.Forms.Padding(6);
            this.txtTKVSK.Name = "txtTKVSK";
            this.txtTKVSK.PasswordChar = '\0';
            this.txtTKVSK.PlaceholderText = "";
            this.txtTKVSK.SelectedText = "";
            this.txtTKVSK.Size = new System.Drawing.Size(450, 52);
            this.txtTKVSK.TabIndex = 1;
            this.txtTKVSK.TextChanged += new System.EventHandler(this.txtTKVSK_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTKVSK);
            this.groupBox1.Controls.Add(this.guna2ImageButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(785, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(631, 90);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(75, 39);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(53, 40);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator1.Location = new System.Drawing.Point(22, 80);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1472, 19);
            this.guna2Separator1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbBoxCapNhatTrangThai);
            this.groupBox2.Controls.Add(this.cbBoxTrangThai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(18, 109);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(728, 90);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc Trạng Thái";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cập nhật Trạng Thái";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbBoxCapNhatTrangThai
            // 
            this.cbBoxCapNhatTrangThai.FormattingEnabled = true;
            this.cbBoxCapNhatTrangThai.Location = new System.Drawing.Point(412, 37);
            this.cbBoxCapNhatTrangThai.Name = "cbBoxCapNhatTrangThai";
            this.cbBoxCapNhatTrangThai.Size = new System.Drawing.Size(309, 37);
            this.cbBoxCapNhatTrangThai.TabIndex = 3;
            this.cbBoxCapNhatTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbBoxCapNhatTrangThai_SelectedIndexChanged);
            this.cbBoxCapNhatTrangThai.RightToLeftChanged += new System.EventHandler(this.cbBoxCapNhatTrangThai_RightToLeftChanged);
            // 
            // cbBoxTrangThai
            // 
            this.cbBoxTrangThai.FormattingEnabled = true;
            this.cbBoxTrangThai.Location = new System.Drawing.Point(7, 37);
            this.cbBoxTrangThai.Name = "cbBoxTrangThai";
            this.cbBoxTrangThai.Size = new System.Drawing.Size(309, 37);
            this.cbBoxTrangThai.TabIndex = 2;
            this.cbBoxTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbBoxTrangThai_SelectedIndexChanged);
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 998);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTicket";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBTC)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridView dgvBTC;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTKVSK;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbBoxTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxCapNhatTrangThai;
    }
}