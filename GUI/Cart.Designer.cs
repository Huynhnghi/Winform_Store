
namespace GUI
{
    partial class Cart
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
            this.picCartProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.selectSL = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbMauSac = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCartProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSL)).BeginInit();
            this.SuspendLayout();
            // 
            // picCartProduct
            // 
            this.picCartProduct.ImageRotate = 0F;
            this.picCartProduct.Location = new System.Drawing.Point(3, 0);
            this.picCartProduct.Name = "picCartProduct";
            this.picCartProduct.Size = new System.Drawing.Size(148, 160);
            this.picCartProduct.TabIndex = 0;
            this.picCartProduct.TabStop = false;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.ForeColor = System.Drawing.Color.Black;
            this.lbTenSP.Location = new System.Drawing.Point(164, 20);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(100, 20);
            this.lbTenSP.TabIndex = 1;
            this.lbTenSP.Text = "Tên sản phẩm";
            // 
            // selectSL
            // 
            this.selectSL.BackColor = System.Drawing.Color.Transparent;
            this.selectSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selectSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectSL.Location = new System.Drawing.Point(316, 71);
            this.selectSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectSL.Name = "selectSL";
            this.selectSL.Size = new System.Drawing.Size(80, 30);
            this.selectSL.TabIndex = 3;
            this.selectSL.UpDownButtonFillColor = System.Drawing.Color.DarkRed;
            this.selectSL.UpDownButtonForeColor = System.Drawing.Color.White;
            this.selectSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbMauSac
            // 
            this.lbMauSac.AutoSize = true;
            this.lbMauSac.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMauSac.ForeColor = System.Drawing.Color.Black;
            this.lbMauSac.Location = new System.Drawing.Point(164, 50);
            this.lbMauSac.Name = "lbMauSac";
            this.lbMauSac.Size = new System.Drawing.Size(63, 20);
            this.lbMauSac.TabIndex = 4;
            this.lbMauSac.Text = "Màu sắc";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Black;
            this.lbSize.Location = new System.Drawing.Point(164, 81);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(36, 20);
            this.lbSize.TabIndex = 5;
            this.lbSize.Text = "Size";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Red;
            this.txtPrice.Location = new System.Drawing.Point(164, 111);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(35, 23);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Text = "Giá";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbMauSac);
            this.Controls.Add(this.selectSL);
            this.Controls.Add(this.lbTenSP);
            this.Controls.Add(this.picCartProduct);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(399, 163);
            ((System.ComponentModel.ISupportInitialize)(this.picCartProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picCartProduct;
        private System.Windows.Forms.Label lbTenSP;
        private Guna.UI2.WinForms.Guna2NumericUpDown selectSL;
        private System.Windows.Forms.Label lbMauSac;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label txtPrice;
    }
}
