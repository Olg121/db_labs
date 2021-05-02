using db.Context;
using db.Controls;
using db.Lab2;
using db.Lab3;
using db.Lab4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db.Forms
{
    public partial class LabsForm : Form
    {
        private Dictionary<string, Control> labByName { get; set; } = new Dictionary<string, Control>();

    
        private const string SECOND_LAB = "second";      
        private const string THIRD_LAB = "third";      
        private const string FOURTH_LAB = "fouth";      
        private const string FIFTH_LAB = "fifth";
        private const string NINETH_LAB = "fifth";


        public LabsForm()
        {
            InitializeComponent();
            labByName.Add(SECOND_LAB, new CashierControlLab2() { Dock = DockStyle.Fill });
            labByName.Add(THIRD_LAB, new Lab3Control() { Dock = DockStyle.Fill });
            labByName.Add(FOURTH_LAB, new DataViewControlLab4() { Dock = DockStyle.Fill });
            labByName.Add(NINETH_LAB, new db.Lab9.CashiersControl() { Dock = DockStyle.Fill });
        }


        private void secondLabBtn_Click(object sender, EventArgs e)
        {
            labPanel.Controls.Clear();
            labPanel.Controls.Add(labByName[SECOND_LAB]);
        }

        private void thirdLabBtn_Click(object sender, EventArgs e)
        {
            labPanel.Controls.Clear();
            labPanel.Controls.Add(labByName[THIRD_LAB]);
        }

        private void fouthLabBtn_Click(object sender, EventArgs e)
        {
            labPanel.Controls.Clear();
            labPanel.Controls.Add(labByName[FOURTH_LAB]);
        }

        private void ninethLab_Click(object sender, EventArgs e)
        {
            labPanel.Controls.Clear();
            labPanel.Controls.Add(labByName[NINETH_LAB]);

        }
    }
}
