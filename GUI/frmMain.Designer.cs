
namespace GUI
{
    partial class frmMain
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
            this.panelLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.NhanVien = new MetroFramework.Controls.MetroTile();
            this.NoiToChuc = new MetroFramework.Controls.MetroTile();
            this.ThongKe = new MetroFramework.Controls.MetroTile();
            this.HoaDon = new MetroFramework.Controls.MetroTile();
            this.NhaToChuc = new MetroFramework.Controls.MetroTile();
            this.Event = new MetroFramework.Controls.MetroTile();
            this.KhachHang = new MetroFramework.Controls.MetroTile();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelRight);
            this.panelLeft.Controls.Add(this.guna2Button3);
            this.panelLeft.Controls.Add(this.btnLogOut);
            this.panelLeft.Controls.Add(this.guna2Button1);
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.panelLeft.FillColor2 = System.Drawing.Color.DeepPink;
            this.panelLeft.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelLeft.Location = new System.Drawing.Point(-4, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1523, 719);
            this.panelLeft.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.guna2Separator1);
            this.panelRight.Controls.Add(this.NhanVien);
            this.panelRight.Controls.Add(this.guna2HtmlLabel1);
            this.panelRight.Controls.Add(this.NoiToChuc);
            this.panelRight.Controls.Add(this.guna2ControlBox1);
            this.panelRight.Controls.Add(this.ThongKe);
            this.panelRight.Controls.Add(this.guna2ControlBox2);
            this.panelRight.Controls.Add(this.HoaDon);
            this.panelRight.Controls.Add(this.guna2ControlBox3);
            this.panelRight.Controls.Add(this.NhaToChuc);
            this.panelRight.Controls.Add(this.Event);
            this.panelRight.Controls.Add(this.KhachHang);
            this.panelRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(270, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1253, 719);
            this.panelRight.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator1.Location = new System.Drawing.Point(37, 65);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1139, 12);
            this.guna2Separator1.TabIndex = 28;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(37, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(352, 48);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Quản lý tổ chức sự kiện";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1193, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 19;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1139, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox2.TabIndex = 18;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1084, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox3.TabIndex = 17;
            // 
            // NhanVien
            // 
            this.NhanVien.ActiveControl = null;
            this.NhanVien.BackColor = System.Drawing.Color.Pink;
            this.NhanVien.ForeColor = System.Drawing.Color.Black;
            this.NhanVien.Location = new System.Drawing.Point(609, 249);
            this.NhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Size = new System.Drawing.Size(188, 212);
            this.NhanVien.TabIndex = 20;
            this.NhanVien.Text = "Nhân viên";
            this.NhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NhanVien.TileImage = global::GUI.Properties.Resources.teamwork__1_;
            this.NhanVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NhanVien.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.NhanVien.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.NhanVien.UseCustomBackColor = true;
            this.NhanVien.UseCustomForeColor = true;
            this.NhanVien.UseSelectable = true;
            this.NhanVien.UseStyleColors = true;
            this.NhanVien.UseTileImage = true;
            // 
            // NoiToChuc
            // 
            this.NoiToChuc.ActiveControl = null;
            this.NoiToChuc.BackColor = System.Drawing.Color.Pink;
            this.NoiToChuc.ForeColor = System.Drawing.Color.Black;
            this.NoiToChuc.Location = new System.Drawing.Point(413, 249);
            this.NoiToChuc.Margin = new System.Windows.Forms.Padding(4);
            this.NoiToChuc.Name = "NoiToChuc";
            this.NoiToChuc.Size = new System.Drawing.Size(188, 212);
            this.NoiToChuc.TabIndex = 21;
            this.NoiToChuc.Text = "Giỏ hàng";
            this.NoiToChuc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NoiToChuc.TileImage = global::GUI.Properties.Resources.cart__1_;
            this.NoiToChuc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoiToChuc.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.NoiToChuc.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.NoiToChuc.UseCustomBackColor = true;
            this.NoiToChuc.UseCustomForeColor = true;
            this.NoiToChuc.UseSelectable = true;
            this.NoiToChuc.UseStyleColors = true;
            this.NoiToChuc.UseTileImage = true;
            // 
            // ThongKe
            // 
            this.ThongKe.ActiveControl = null;
            this.ThongKe.AutoSize = true;
            this.ThongKe.BackColor = System.Drawing.Color.Pink;
            this.ThongKe.ForeColor = System.Drawing.Color.Black;
            this.ThongKe.Location = new System.Drawing.Point(413, 85);
            this.ThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(384, 156);
            this.ThongKe.TabIndex = 22;
            this.ThongKe.Text = "Thống kê";
            this.ThongKe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ThongKe.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ThongKe.TileImage = global::GUI.Properties.Resources.description__1_;
            this.ThongKe.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ThongKe.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ThongKe.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ThongKe.UseCustomBackColor = true;
            this.ThongKe.UseCustomForeColor = true;
            this.ThongKe.UseSelectable = true;
            this.ThongKe.UseStyleColors = true;
            this.ThongKe.UseTileImage = true;
            this.ThongKe.Click += new System.EventHandler(this.ThongKe_Click);
            // 
            // HoaDon
            // 
            this.HoaDon.ActiveControl = null;
            this.HoaDon.BackColor = System.Drawing.Color.Pink;
            this.HoaDon.ForeColor = System.Drawing.Color.Black;
            this.HoaDon.Location = new System.Drawing.Point(835, 85);
            this.HoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Size = new System.Drawing.Size(341, 375);
            this.HoaDon.TabIndex = 23;
            this.HoaDon.Text = "Đơn hàng";
            this.HoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HoaDon.TileImage = global::GUI.Properties.Resources.bill__1___1_;
            this.HoaDon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HoaDon.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.HoaDon.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.HoaDon.UseCustomBackColor = true;
            this.HoaDon.UseCustomForeColor = true;
            this.HoaDon.UseSelectable = true;
            this.HoaDon.UseStyleColors = true;
            this.HoaDon.UseTileImage = true;
            // 
            // NhaToChuc
            // 
            this.NhaToChuc.ActiveControl = null;
            this.NhaToChuc.BackColor = System.Drawing.Color.Pink;
            this.NhaToChuc.ForeColor = System.Drawing.Color.Black;
            this.NhaToChuc.Location = new System.Drawing.Point(609, 487);
            this.NhaToChuc.Margin = new System.Windows.Forms.Padding(4);
            this.NhaToChuc.Name = "NhaToChuc";
            this.NhaToChuc.Size = new System.Drawing.Size(567, 194);
            this.NhaToChuc.TabIndex = 24;
            this.NhaToChuc.Text = "Quản lý nhà cung cấp";
            this.NhaToChuc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NhaToChuc.TileImage = global::GUI.Properties.Resources.supplier__2_;
            this.NhaToChuc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NhaToChuc.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.NhaToChuc.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.NhaToChuc.UseCustomBackColor = true;
            this.NhaToChuc.UseCustomForeColor = true;
            this.NhaToChuc.UseSelectable = true;
            this.NhaToChuc.UseStyleColors = true;
            this.NhaToChuc.UseTileImage = true;
            this.NhaToChuc.Click += new System.EventHandler(this.NhaToChuc_Click);
            // 
            // Event
            // 
            this.Event.ActiveControl = null;
            this.Event.AutoSize = true;
            this.Event.BackColor = System.Drawing.Color.Pink;
            this.Event.ForeColor = System.Drawing.Color.Black;
            this.Event.Location = new System.Drawing.Point(65, 85);
            this.Event.Margin = new System.Windows.Forms.Padding(4);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(324, 375);
            this.Event.TabIndex = 27;
            this.Event.Text = "Quản lý sản phẩm";
            this.Event.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Event.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Event.TileImage = global::GUI.Properties.Resources.brand__2_;
            this.Event.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Event.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Event.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Event.UseCustomBackColor = true;
            this.Event.UseCustomForeColor = true;
            this.Event.UseSelectable = true;
            this.Event.UseTileImage = true;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // KhachHang
            // 
            this.KhachHang.ActiveControl = null;
            this.KhachHang.BackColor = System.Drawing.Color.Pink;
            this.KhachHang.ForeColor = System.Drawing.Color.Black;
            this.KhachHang.Location = new System.Drawing.Point(65, 487);
            this.KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Size = new System.Drawing.Size(519, 194);
            this.KhachHang.TabIndex = 25;
            this.KhachHang.Text = "Quản lý khách hàng";
            this.KhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KhachHang.TileImage = global::GUI.Properties.Resources.cus;
            this.KhachHang.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KhachHang.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.KhachHang.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.KhachHang.UseCustomBackColor = true;
            this.KhachHang.UseCustomForeColor = true;
            this.KhachHang.UseSelectable = true;
            this.KhachHang.UseStyleColors = true;
            this.KhachHang.UseTileImage = true;
            this.KhachHang.Click += new System.EventHandler(this.KhachHang_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Pink;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Pink;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = global::GUI.Properties.Resources.user;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button3.Location = new System.Drawing.Point(0, 586);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(271, 66);
            this.guna2Button3.TabIndex = 0;
            this.guna2Button3.Text = "Thông tin cá nhân";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.HotPink;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::GUI.Properties.Resources.exit;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogOut.Location = new System.Drawing.Point(0, 647);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(271, 68);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::GUI.Properties.Resources.me;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(271, 59);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 716);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private MetroFramework.Controls.MetroTile NhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private MetroFramework.Controls.MetroTile NoiToChuc;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private MetroFramework.Controls.MetroTile ThongKe;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private MetroFramework.Controls.MetroTile HoaDon;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private MetroFramework.Controls.MetroTile NhaToChuc;
        private MetroFramework.Controls.MetroTile Event;
        private MetroFramework.Controls.MetroTile KhachHang;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}