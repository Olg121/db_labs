
namespace db.Controls
{
    partial class DiscountControl
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
            this.discountValueTB = new System.Windows.Forms.TextBox();
            this.dateFromLbl = new System.Windows.Forms.Label();
            this.dateFromDTP = new System.Windows.Forms.DateTimePicker();
            this.dateToLbl = new System.Windows.Forms.Label();
            this.dateToDTP = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productNameLbl);
            this.flowLayoutPanel1.Controls.Add(this.productCB);
            this.flowLayoutPanel1.Controls.Add(this.discountValueLbl);
            this.flowLayoutPanel1.Controls.Add(this.discountValueTB);
            this.flowLayoutPanel1.Controls.Add(this.dateFromLbl);
            this.flowLayoutPanel1.Controls.Add(this.dateFromDTP);
            this.flowLayoutPanel1.Controls.Add(this.dateToLbl);
            this.flowLayoutPanel1.Controls.Add(this.dateToDTP);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(159, 185);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(3, 0);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(53, 15);
            this.productNameLbl.TabIndex = 0;
            this.productNameLbl.Text = "Продукт";
            // 
            // productCB
            // 
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(3, 18);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(142, 23);
            this.productCB.TabIndex = 1;
            // 
            // discountValueLbl
            // 
            this.discountValueLbl.AutoSize = true;
            this.discountValueLbl.Location = new System.Drawing.Point(3, 44);
            this.discountValueLbl.Name = "discountValueLbl";
            this.discountValueLbl.Size = new System.Drawing.Size(88, 15);
            this.discountValueLbl.TabIndex = 2;
            this.discountValueLbl.Text = "Размер скидки";
            // 
            // discountValueTB
            // 
            this.discountValueTB.Location = new System.Drawing.Point(3, 62);
            this.discountValueTB.Name = "discountValueTB";
            this.discountValueTB.Size = new System.Drawing.Size(142, 23);
            this.discountValueTB.TabIndex = 3;
            // 
            // dateFromLbl
            // 
            this.dateFromLbl.AutoSize = true;
            this.dateFromLbl.Location = new System.Drawing.Point(3, 88);
            this.dateFromLbl.Name = "dateFromLbl";
            this.dateFromLbl.Size = new System.Drawing.Size(74, 15);
            this.dateFromLbl.TabIndex = 4;
            this.dateFromLbl.Text = "Дата начала";
            // 
            // dateFromDTP
            // 
            this.dateFromDTP.Location = new System.Drawing.Point(3, 106);
            this.dateFromDTP.Name = "dateFromDTP";
            this.dateFromDTP.Size = new System.Drawing.Size(142, 23);
            this.dateFromDTP.TabIndex = 5;
            // 
            // dateToLbl
            // 
            this.dateToLbl.AutoSize = true;
            this.dateToLbl.Location = new System.Drawing.Point(3, 132);
            this.dateToLbl.Name = "dateToLbl";
            this.dateToLbl.Size = new System.Drawing.Size(95, 15);
            this.dateToLbl.TabIndex = 6;
            this.dateToLbl.Text = "Дата окончания";
            // 
            // dateToDTP
            // 
            this.dateToDTP.Location = new System.Drawing.Point(3, 150);
            this.dateToDTP.Name = "dateToDTP";
            this.dateToDTP.Size = new System.Drawing.Size(142, 23);
            this.dateToDTP.TabIndex = 7;
            // 
            // DiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DiscountControl";
            this.Size = new System.Drawing.Size(159, 185);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.Label discountValueLbl;
        private System.Windows.Forms.TextBox discountValueTB;
        private System.Windows.Forms.Label dateFromLbl;
        private System.Windows.Forms.DateTimePicker dateFromDTP;
        private System.Windows.Forms.Label dateToLbl;
        private System.Windows.Forms.DateTimePicker dateToDTP;
    }
}
