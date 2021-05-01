
namespace db.Controls
{
    partial class ProductControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.brandLbl = new System.Windows.Forms.Label();
            this.brandCB = new System.Windows.Forms.ComboBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.nameTB);
            this.flowLayoutPanel1.Controls.Add(this.brandLbl);
            this.flowLayoutPanel1.Controls.Add(this.brandCB);
            this.flowLayoutPanel1.Controls.Add(this.priceLbl);
            this.flowLayoutPanel1.Controls.Add(this.priceTB);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(3, 0);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(53, 15);
            this.productNameLbl.TabIndex = 5;
            this.productNameLbl.Text = "Продукт";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(3, 18);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(142, 23);
            this.nameTB.TabIndex = 8;
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Location = new System.Drawing.Point(3, 44);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(40, 15);
            this.brandLbl.TabIndex = 7;
            this.brandLbl.Text = "Бренд";
            // 
            // brandCB
            // 
            this.brandCB.FormattingEnabled = true;
            this.brandCB.Location = new System.Drawing.Point(3, 62);
            this.brandCB.Name = "brandCB";
            this.brandCB.Size = new System.Drawing.Size(142, 23);
            this.brandCB.TabIndex = 6;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(3, 88);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(35, 15);
            this.priceLbl.TabIndex = 9;
            this.priceLbl.Text = "Цена";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(3, 106);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(142, 23);
            this.priceTB.TabIndex = 10;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProductControl";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.ComboBox brandCB;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox priceTB;
    }
}
