
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Staff = new MetroFramework.Controls.MetroTile();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Cart = new MetroFramework.Controls.MetroTile();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Report = new MetroFramework.Controls.MetroTile();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Bill = new MetroFramework.Controls.MetroTile();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Product = new MetroFramework.Controls.MetroTile();
            this.Customer = new MetroFramework.Controls.MetroTile();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.Supplier = new MetroFramework.Controls.MetroTile();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelRight);
            this.panelLeft.Controls.Add(this.guna2Button3);
            this.panelLeft.Controls.Add(this.btnLogOut);
            this.panelLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.panelLeft.FillColor2 = System.Drawing.Color.DeepPink;
            this.panelLeft.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelLeft.Location = new System.Drawing.Point(-4, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1523, 719);
            this.panelLeft.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.Supplier);
            this.panelRight.Controls.Add(this.guna2Separator1);
            this.panelRight.Controls.Add(this.Staff);
            this.panelRight.Controls.Add(this.guna2HtmlLabel1);
            this.panelRight.Controls.Add(this.Cart);
            this.panelRight.Controls.Add(this.guna2ControlBox1);
            this.panelRight.Controls.Add(this.Report);
            this.panelRight.Controls.Add(this.guna2ControlBox2);
            this.panelRight.Controls.Add(this.Bill);
            this.panelRight.Controls.Add(this.guna2ControlBox3);
            this.panelRight.Controls.Add(this.Product);
            this.panelRight.Controls.Add(this.Customer);
            this.panelRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(270, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1253, 719);
            this.panelRight.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Separator1.Location = new System.Drawing.Point(37, 65);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1139, 12);
            this.guna2Separator1.TabIndex = 28;
            // 
            // Staff
            // 
            this.Staff.ActiveControl = null;
            this.Staff.BackColor = System.Drawing.Color.Pink;
            this.Staff.ForeColor = System.Drawing.Color.Black;
            this.Staff.Location = new System.Drawing.Point(609, 249);
            this.Staff.Margin = new System.Windows.Forms.Padding(4);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(188, 212);
            this.Staff.TabIndex = 20;
            this.Staff.Text = "Nhân viên";
            this.Staff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Staff.TileImage = ((System.Drawing.Image)(resources.GetObject("Staff.TileImage")));
            this.Staff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Staff.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Staff.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Staff.UseCustomBackColor = true;
            this.Staff.UseCustomForeColor = true;
            this.Staff.UseSelectable = true;
            this.Staff.UseStyleColors = true;
            this.Staff.UseTileImage = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(37, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(420, 48);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Quản lý cửa hàng thời trang ";
            // 
            // Cart
            // 
            this.Cart.ActiveControl = null;
            this.Cart.BackColor = System.Drawing.Color.Pink;
            this.Cart.ForeColor = System.Drawing.Color.Black;
            this.Cart.Location = new System.Drawing.Point(413, 249);
            this.Cart.Margin = new System.Windows.Forms.Padding(4);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(188, 212);
            this.Cart.TabIndex = 21;
            this.Cart.Text = "Giỏ hàng";
            this.Cart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cart.TileImage = ((System.Drawing.Image)(resources.GetObject("Cart.TileImage")));
            this.Cart.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cart.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Cart.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Cart.UseCustomBackColor = true;
            this.Cart.UseCustomForeColor = true;
            this.Cart.UseSelectable = true;
            this.Cart.UseStyleColors = true;
            this.Cart.UseTileImage = true;
            this.Cart.Click += new System.EventHandler(this.NoiToChuc_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1193, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 19;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Report
            // 
            this.Report.ActiveControl = null;
            this.Report.AutoSize = true;
            this.Report.BackColor = System.Drawing.Color.Pink;
            this.Report.ForeColor = System.Drawing.Color.Black;
            this.Report.Location = new System.Drawing.Point(413, 85);
            this.Report.Margin = new System.Windows.Forms.Padding(4);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(384, 156);
            this.Report.TabIndex = 22;
            this.Report.Text = "Thống kê";
            this.Report.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Report.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Report.TileImage = ((System.Drawing.Image)(resources.GetObject("Report.TileImage")));
            this.Report.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Report.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Report.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Report.UseCustomBackColor = true;
            this.Report.UseCustomForeColor = true;
            this.Report.UseSelectable = true;
            this.Report.UseStyleColors = true;
            this.Report.UseTileImage = true;
            this.Report.Click += new System.EventHandler(this.ThongKe_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1139, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox2.TabIndex = 18;
            // 
            // Bill
            // 
            this.Bill.ActiveControl = null;
            this.Bill.BackColor = System.Drawing.Color.Pink;
            this.Bill.ForeColor = System.Drawing.Color.Black;
            this.Bill.Location = new System.Drawing.Point(835, 85);
            this.Bill.Margin = new System.Windows.Forms.Padding(4);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(341, 375);
            this.Bill.TabIndex = 23;
            this.Bill.Text = "Đơn hàng";
            this.Bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bill.TileImage = ((System.Drawing.Image)(resources.GetObject("Bill.TileImage")));
            this.Bill.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Bill.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Bill.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Bill.UseCustomBackColor = true;
            this.Bill.UseCustomForeColor = true;
            this.Bill.UseSelectable = true;
            this.Bill.UseStyleColors = true;
            this.Bill.UseTileImage = true;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1084, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox3.TabIndex = 17;
            // 
            // Product
            // 
            this.Product.ActiveControl = null;
            this.Product.AutoSize = true;
            this.Product.BackColor = System.Drawing.Color.Pink;
            this.Product.ForeColor = System.Drawing.Color.Black;
            this.Product.Location = new System.Drawing.Point(65, 85);
            this.Product.Margin = new System.Windows.Forms.Padding(4);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(324, 375);
            this.Product.TabIndex = 27;
            this.Product.Text = "Quản lý sản phẩm";
            this.Product.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Product.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Product.TileImage = ((System.Drawing.Image)(resources.GetObject("Product.TileImage")));
            this.Product.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Product.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Product.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Product.UseCustomBackColor = true;
            this.Product.UseCustomForeColor = true;
            this.Product.UseSelectable = true;
            this.Product.UseTileImage = true;
            this.Product.Click += new System.EventHandler(this.Event_Click);
            // 
            // Customer
            // 
            this.Customer.ActiveControl = null;
            this.Customer.BackColor = System.Drawing.Color.Pink;
            this.Customer.ForeColor = System.Drawing.Color.Black;
            this.Customer.Location = new System.Drawing.Point(65, 487);
            this.Customer.Margin = new System.Windows.Forms.Padding(4);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(519, 194);
            this.Customer.TabIndex = 25;
            this.Customer.Text = "Quản lý khách hàng";
            this.Customer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customer.TileImage = ((System.Drawing.Image)(resources.GetObject("Customer.TileImage")));
            this.Customer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Customer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Customer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Customer.UseCustomBackColor = true;
            this.Customer.UseCustomForeColor = true;
            this.Customer.UseSelectable = true;
            this.Customer.UseStyleColors = true;
            this.Customer.UseTileImage = true;
            this.Customer.Click += new System.EventHandler(this.KhachHang_Click);
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
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
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
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
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
            // Supplier
            // 
            this.Supplier.ActiveControl = null;
            this.Supplier.BackColor = System.Drawing.Color.Pink;
            this.Supplier.Location = new System.Drawing.Point(592, 487);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(584, 194);
            this.Supplier.TabIndex = 25;
            this.Supplier.Text = "Quản lý nhà cung cấp";
            this.Supplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Supplier.TileImage = ((System.Drawing.Image)(resources.GetObject("Supplier.TileImage")));
            this.Supplier.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Supplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Supplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Supplier.UseCustomBackColor = true;
            this.Supplier.UseCustomForeColor = true;
            this.Supplier.UseSelectable = true;
            this.Supplier.UseStyleColors = true;
            this.Supplier.UseTileImage = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 716);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private MetroFramework.Controls.MetroTile Staff;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private MetroFramework.Controls.MetroTile Cart;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private MetroFramework.Controls.MetroTile Report;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private MetroFramework.Controls.MetroTile Bill;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private MetroFramework.Controls.MetroTile Product;
        private MetroFramework.Controls.MetroTile Customer;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private MetroFramework.Controls.MetroTile Supplier;
    }
}