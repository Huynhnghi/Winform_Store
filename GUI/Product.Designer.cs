
namespace GUI
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnMua = new Guna.UI2.WinForms.Guna2Button();
            this.txtGia = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.Label();
            this.pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMauSac = new MetroFramework.Controls.MetroComboBox();
            this.flCBB = new System.Windows.Forms.FlowLayoutPanel();
            this.btnS = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnXL = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.flCBB.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.flCBB);
            this.metroPanel1.Controls.Add(this.cbbMauSac);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.btnMua);
            this.metroPanel1.Controls.Add(this.txtGia);
            this.metroPanel1.Controls.Add(this.txtTenSP);
            this.metroPanel1.Controls.Add(this.pic);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(272, 385);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnMua
            // 
            this.btnMua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMua.FillColor = System.Drawing.Color.Maroon;
            this.btnMua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMua.ForeColor = System.Drawing.Color.White;
            this.btnMua.Location = new System.Drawing.Point(-3, 338);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(272, 44);
            this.btnMua.TabIndex = 5;
            this.btnMua.Text = "Mua ngay";
            // 
            // txtGia
            // 
            this.txtGia.AutoSize = true;
            this.txtGia.BackColor = System.Drawing.Color.Transparent;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtGia.Location = new System.Drawing.Point(4, 201);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(35, 23);
            this.txtGia.TabIndex = 4;
            this.txtGia.Text = "Giá";
            // 
            // txtTenSP
            // 
            this.txtTenSP.AutoSize = true;
            this.txtTenSP.BackColor = System.Drawing.Color.Transparent;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTenSP.Location = new System.Drawing.Point(4, 169);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(116, 23);
            this.txtTenSP.TabIndex = 3;
            this.txtTenSP.Text = "Tên sản phẩm";
            // 
            // pic
            // 
            this.pic.ImageRotate = 0F;
            this.pic.Location = new System.Drawing.Point(3, 3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(269, 163);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Màu sắc: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbMauSac
            // 
            this.cbbMauSac.FormattingEnabled = true;
            this.cbbMauSac.ItemHeight = 24;
            this.cbbMauSac.Location = new System.Drawing.Point(92, 229);
            this.cbbMauSac.Name = "cbbMauSac";
            this.cbbMauSac.Size = new System.Drawing.Size(159, 30);
            this.cbbMauSac.TabIndex = 7;
            this.cbbMauSac.UseSelectable = true;
            // 
            // flCBB
            // 
            this.flCBB.Controls.Add(this.btnS);
            this.flCBB.Controls.Add(this.btnM);
            this.flCBB.Controls.Add(this.btnL);
            this.flCBB.Controls.Add(this.btnXL);
            this.flCBB.Location = new System.Drawing.Point(36, 274);
            this.flCBB.Name = "flCBB";
            this.flCBB.Size = new System.Drawing.Size(201, 58);
            this.flCBB.TabIndex = 8;
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(3, 3);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(44, 51);
            this.btnS.TabIndex = 0;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(53, 3);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(44, 51);
            this.btnM.TabIndex = 1;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(103, 3);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(44, 51);
            this.btnL.TabIndex = 2;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            // 
            // btnXL
            // 
            this.btnXL.Location = new System.Drawing.Point(153, 3);
            this.btnXL.Name = "btnXL";
            this.btnXL.Size = new System.Drawing.Size(44, 51);
            this.btnXL.TabIndex = 3;
            this.btnXL.Text = "XL";
            this.btnXL.UseVisualStyleBackColor = true;
            this.btnXL.Click += new System.EventHandler(this.button4_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(279, 391);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.flCBB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Guna.UI2.WinForms.Guna2Button btnMua;
        private System.Windows.Forms.Label txtGia;
        private System.Windows.Forms.Label txtTenSP;
        private Guna.UI2.WinForms.Guna2PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flCBB;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnXL;
        private MetroFramework.Controls.MetroComboBox cbbMauSac;
    }
}
