

using db.Controls;
namespace db.Forms
{
    using Controls;
    partial class LabsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.secondLabBtn = new System.Windows.Forms.Button();
            this.thirdLabBtn = new System.Windows.Forms.Button();
            this.fouthLabBtn = new System.Windows.Forms.Button();
            this.fifthLabBtn = new System.Windows.Forms.Button();
            this.labPanel = new System.Windows.Forms.Panel();
            this.ninethLab = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.secondLabBtn);
            this.flowLayoutPanel1.Controls.Add(this.thirdLabBtn);
            this.flowLayoutPanel1.Controls.Add(this.fouthLabBtn);
            this.flowLayoutPanel1.Controls.Add(this.fifthLabBtn);
            this.flowLayoutPanel1.Controls.Add(this.ninethLab);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(826, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // secondLabBtn
            // 
            this.secondLabBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondLabBtn.Location = new System.Drawing.Point(3, 3);
            this.secondLabBtn.Name = "secondLabBtn";
            this.secondLabBtn.Size = new System.Drawing.Size(102, 23);
            this.secondLabBtn.TabIndex = 1;
            this.secondLabBtn.Text = "Лаба2";
            this.secondLabBtn.UseVisualStyleBackColor = true;
            this.secondLabBtn.Click += new System.EventHandler(this.secondLabBtn_Click);
            // 
            // thirdLabBtn
            // 
            this.thirdLabBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.thirdLabBtn.Location = new System.Drawing.Point(3, 32);
            this.thirdLabBtn.Name = "thirdLabBtn";
            this.thirdLabBtn.Size = new System.Drawing.Size(102, 23);
            this.thirdLabBtn.TabIndex = 2;
            this.thirdLabBtn.Text = "Лаба3";
            this.thirdLabBtn.UseVisualStyleBackColor = true;
            this.thirdLabBtn.Click += new System.EventHandler(this.thirdLabBtn_Click);
            // 
            // fouthLabBtn
            // 
            this.fouthLabBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.fouthLabBtn.Location = new System.Drawing.Point(3, 61);
            this.fouthLabBtn.Name = "fouthLabBtn";
            this.fouthLabBtn.Size = new System.Drawing.Size(102, 23);
            this.fouthLabBtn.TabIndex = 3;
            this.fouthLabBtn.Text = "Лаба4";
            this.fouthLabBtn.UseVisualStyleBackColor = true;
            this.fouthLabBtn.Click += new System.EventHandler(this.fouthLabBtn_Click);
            // 
            // fifthLabBtn
            // 
            this.fifthLabBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.fifthLabBtn.Location = new System.Drawing.Point(3, 90);
            this.fifthLabBtn.Name = "fifthLabBtn";
            this.fifthLabBtn.Size = new System.Drawing.Size(102, 23);
            this.fifthLabBtn.TabIndex = 4;
            this.fifthLabBtn.Text = "Лаба5";
            this.fifthLabBtn.UseVisualStyleBackColor = true;
            // 
            // labPanel
            // 
            this.labPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPanel.Location = new System.Drawing.Point(0, 0);
            this.labPanel.Name = "labPanel";
            this.labPanel.Size = new System.Drawing.Size(826, 450);
            this.labPanel.TabIndex = 1;
            // 
            // ninethLab
            // 
            this.ninethLab.Dock = System.Windows.Forms.DockStyle.Top;
            this.ninethLab.Location = new System.Drawing.Point(3, 119);
            this.ninethLab.Name = "ninethLab";
            this.ninethLab.Size = new System.Drawing.Size(102, 23);
            this.ninethLab.TabIndex = 5;
            this.ninethLab.Text = "Лаба9";
            this.ninethLab.UseVisualStyleBackColor = true;
            this.ninethLab.Click += new System.EventHandler(this.ninethLab_Click);
            // 
            // LabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.labPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LabsForm";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button secondLabBtn;
        private System.Windows.Forms.Button thirdLabBtn;
        private System.Windows.Forms.Button fouthLabBtn;
        private System.Windows.Forms.Button fifthLabBtn;
        private System.Windows.Forms.Panel labPanel;
        private System.Windows.Forms.Button ninethLab;
    }
}

