
namespace db.Lab2
{
    partial class CashierControlLab2
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
            db.DbModel.Cashier cashier1 = new db.DbModel.Cashier();
            db.DbModel.Cashier cashier2 = new db.DbModel.Cashier();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cashierControl = new db.Controls.CashierControl();
            this.addCashierBtn = new System.Windows.Forms.Button();
            this.updateLstBtn = new System.Windows.Forms.Button();
            this.countLbl = new System.Windows.Forms.Label();
            this.countValueLbl = new System.Windows.Forms.Label();
            this.lastIdLbl = new System.Windows.Forms.Label();
            this.lastIdValueLbl = new System.Windows.Forms.Label();
            this.cashierGrid = new System.Windows.Forms.DataGridView();
            this.cashierControl1 = new db.Controls.CashierControl();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cashierControl);
            this.flowLayoutPanel1.Controls.Add(this.addCashierBtn);
            this.flowLayoutPanel1.Controls.Add(this.updateLstBtn);
            this.flowLayoutPanel1.Controls.Add(this.countLbl);
            this.flowLayoutPanel1.Controls.Add(this.countValueLbl);
            this.flowLayoutPanel1.Controls.Add(this.lastIdLbl);
            this.flowLayoutPanel1.Controls.Add(this.lastIdValueLbl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(235, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(190, 416);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // cashierControl
            // 
            cashier1.FirstName = "";
            cashier1.Id = 0;
            cashier1.MiddleName = "";
            cashier1.Surname = "";
            this.cashierControl.Cashier = cashier1;
            this.cashierControl.Location = new System.Drawing.Point(3, 3);
            this.cashierControl.Name = "cashierControl";
            this.cashierControl.Size = new System.Drawing.Size(107, 134);
            this.cashierControl.TabIndex = 0;
            // 
            // addCashierBtn
            // 
            this.addCashierBtn.Location = new System.Drawing.Point(3, 143);
            this.addCashierBtn.Name = "addCashierBtn";
            this.addCashierBtn.Size = new System.Drawing.Size(107, 23);
            this.addCashierBtn.TabIndex = 1;
            this.addCashierBtn.Text = "Добавить";
            this.addCashierBtn.UseVisualStyleBackColor = true;
            this.addCashierBtn.Click += new System.EventHandler(this.AddCashierBtn_Click);
            // 
            // updateLstBtn
            // 
            this.updateLstBtn.Location = new System.Drawing.Point(3, 172);
            this.updateLstBtn.Name = "updateLstBtn";
            this.updateLstBtn.Size = new System.Drawing.Size(107, 23);
            this.updateLstBtn.TabIndex = 2;
            this.updateLstBtn.Text = "Обновить";
            this.updateLstBtn.UseVisualStyleBackColor = true;
            this.updateLstBtn.Click += new System.EventHandler(this.UpdateLstBtn_Click);
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(3, 198);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(119, 15);
            this.countLbl.TabIndex = 3;
            this.countLbl.Text = "Количество записей";
            // 
            // countValueLbl
            // 
            this.countValueLbl.AutoSize = true;
            this.countValueLbl.Location = new System.Drawing.Point(3, 213);
            this.countValueLbl.Name = "countValueLbl";
            this.countValueLbl.Size = new System.Drawing.Size(0, 15);
            this.countValueLbl.TabIndex = 6;
            // 
            // lastIdLbl
            // 
            this.lastIdLbl.AutoSize = true;
            this.lastIdLbl.Location = new System.Drawing.Point(3, 228);
            this.lastIdLbl.Name = "lastIdLbl";
            this.lastIdLbl.Size = new System.Drawing.Size(153, 30);
            this.lastIdLbl.TabIndex = 5;
            this.lastIdLbl.Text = "Id последнего введенного элемента";
            // 
            // lastIdValueLbl
            // 
            this.lastIdValueLbl.AutoSize = true;
            this.lastIdValueLbl.Location = new System.Drawing.Point(3, 258);
            this.lastIdValueLbl.Name = "lastIdValueLbl";
            this.lastIdValueLbl.Size = new System.Drawing.Size(0, 15);
            this.lastIdValueLbl.TabIndex = 7;
            // 
            // cashierGrid
            // 
            this.cashierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashierGrid.Location = new System.Drawing.Point(0, 0);
            this.cashierGrid.Name = "cashierGrid";
            this.cashierGrid.RowTemplate.Height = 25;
            this.cashierGrid.Size = new System.Drawing.Size(425, 416);
            this.cashierGrid.TabIndex = 4;
            // 
            // cashierControl1
            // 
            cashier2.FirstName = "";
            cashier2.Id = 0;
            cashier2.MiddleName = "";
            cashier2.Surname = "";
            this.cashierControl1.Cashier = cashier2;
            this.cashierControl1.Location = new System.Drawing.Point(3, 224);
            this.cashierControl1.Name = "cashierControl1";
            this.cashierControl1.Size = new System.Drawing.Size(107, 97);
            this.cashierControl1.TabIndex = 7;
            // 
            // CashierControlLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cashierGrid);
            this.Name = "CashierControlLab2";
            this.Size = new System.Drawing.Size(425, 416);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.CashierControl cashierControl;
        private System.Windows.Forms.Button addCashierBtn;
        private System.Windows.Forms.Button updateLstBtn;
        private System.Windows.Forms.DataGridView cashierGrid;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label lastIdLbl;
        private System.Windows.Forms.Label countValueLbl;
        private System.Windows.Forms.Label lastIdValueLbl;
        private Controls.CashierControl cashierControl1;
    }
}
