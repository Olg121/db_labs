
namespace db.Controls
{
    partial class ProductReceiptsControl
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
            this.productCB = new System.Windows.Forms.ComboBox();
            this.discountValueLbl = new System.Windows.Forms.Label();
            this.productsCountTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.productCB);
            this.flowLayoutPanel1.Controls.Add(this.discountValueLbl);
            this.flowLayoutPanel1.Controls.Add(this.productsCountTB);
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
            this.productNameLbl.Size = new System.Drawing.Size(39, 15);
            this.productNameLbl.TabIndex = 4;
            this.productNameLbl.Text = "Товар";
            // 
            // productCB
            // 
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(3, 18);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(142, 23);
            this.productCB.TabIndex = 5;
            // 
            // discountValueLbl
            // 
            this.discountValueLbl.AutoSize = true;
            this.discountValueLbl.Location = new System.Drawing.Point(3, 44);
            this.discountValueLbl.Name = "discountValueLbl";
            this.discountValueLbl.Size = new System.Drawing.Size(93, 15);
            this.discountValueLbl.TabIndex = 6;
            this.discountValueLbl.Text = "Кол-во товаров";
            // 
            // productsCountTB
            // 
            this.productsCountTB.Location = new System.Drawing.Point(3, 62);
            this.productsCountTB.Name = "productsCountTB";
            this.productsCountTB.Size = new System.Drawing.Size(142, 23);
            this.productsCountTB.TabIndex = 7;
            // 
            // ProductReceiptsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProductReceiptsControl";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.Label discountValueLbl;
        private System.Windows.Forms.TextBox productsCountTB;
    }
}
