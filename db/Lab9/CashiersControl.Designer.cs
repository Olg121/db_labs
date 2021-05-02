
namespace db.Lab9
{
    partial class CashiersControl
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
            db.DbModel.Cashier cashier5 = new db.DbModel.Cashier();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashiersControl));
            this.cashierControl1 = new db.Controls.CashierControl();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.crudPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveCancelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cashierGrid = new db.Controls.DataGrids.CashierGrid();
            this.mainPanel.SuspendLayout();
            this.crudPanel.SuspendLayout();
            this.saveCancelPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashierControl1
            // 
            cashier5.FirstName = "";
            cashier5.Id = 0;
            cashier5.MiddleName = "";
            cashier5.Surname = "";
            this.cashierControl1.Cashier = cashier5;
            this.cashierControl1.Location = new System.Drawing.Point(3, 3);
            this.cashierControl1.Name = "cashierControl1";
            this.cashierControl1.Size = new System.Drawing.Size(108, 138);
            this.cashierControl1.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.cashierControl1);
            this.mainPanel.Controls.Add(this.crudPanel);
            this.mainPanel.Controls.Add(this.saveCancelPanel);
            this.mainPanel.Controls.Add(this.filterPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(116, 556);
            this.mainPanel.TabIndex = 2;
            // 
            // crudPanel
            // 
            this.crudPanel.Controls.Add(this.InsertBtn);
            this.crudPanel.Controls.Add(this.deleteBtn);
            this.crudPanel.Controls.Add(this.updateBtn);
            this.crudPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.crudPanel.Location = new System.Drawing.Point(3, 147);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(113, 100);
            this.crudPanel.TabIndex = 9;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(3, 3);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(105, 23);
            this.InsertBtn.TabIndex = 2;
            this.InsertBtn.Text = "Добавить";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(3, 32);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(105, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(3, 61);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(105, 23);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Изменить\r\n";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveCancelPanel
            // 
            this.saveCancelPanel.Controls.Add(this.cancelBtn);
            this.saveCancelPanel.Controls.Add(this.saveBtn);
            this.saveCancelPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.saveCancelPanel.Location = new System.Drawing.Point(3, 253);
            this.saveCancelPanel.Name = "saveCancelPanel";
            this.saveCancelPanel.Size = new System.Drawing.Size(111, 100);
            this.saveCancelPanel.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(3, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(3, 32);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(105, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.filterTB);
            this.filterPanel.Controls.Add(this.button1);
            this.filterPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.filterPanel.Location = new System.Drawing.Point(3, 359);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(111, 64);
            this.filterPanel.TabIndex = 11;
            // 
            // filterTB
            // 
            this.filterTB.Location = new System.Drawing.Point(3, 3);
            this.filterTB.Name = "filterTB";
            this.filterTB.Size = new System.Drawing.Size(105, 23);
            this.filterTB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Фильтровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cashierGrid);
            this.panel1.Controls.Add(this.mainPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 556);
            this.panel1.TabIndex = 3;
            // 
            // cashierGrid
            // 
            this.cashierGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashierGrid.Location = new System.Drawing.Point(116, 0);
            this.cashierGrid.Name = "cashierGrid";
            this.cashierGrid.SelectionChanged = null;
            this.cashierGrid.Size = new System.Drawing.Size(593, 556);
            this.cashierGrid.TabIndex = 3;
            // 
            // CashiersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CashiersControl";
            this.Size = new System.Drawing.Size(709, 556);
            this.mainPanel.ResumeLayout(false);
            this.crudPanel.ResumeLayout(false);
            this.saveCancelPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CashierControl cashierControl1;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel crudPanel;
        private System.Windows.Forms.FlowLayoutPanel saveCancelPanel;
        private Controls.DataGrids.CashierGrid cashierGrid;
        private System.Windows.Forms.FlowLayoutPanel filterPanel;
        private System.Windows.Forms.TextBox filterTB;
        private System.Windows.Forms.Button button1;
    }
}
