using CourseWorkProject.Controls;
using InternetShop.Forms;
using labs.Grids;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetShop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
  

        private Control _welcomeControl;

        private void Form1_Load(object sender, EventArgs e)
        {
            _welcomeControl = new WelcomeControl() { Dock = DockStyle.Fill };
          //  Controls.Clear();
           // Controls.Add(_welcomeControl);
            (_welcomeControl as WelcomeControl).ControlClickedEventHandler += _welcomeControl_Click;
        }

        private void _welcomeControl_Click(object sender, EventArgs e)
        {
            Controls.Remove(_welcomeControl);
            Controls.Add(mainPanel);
        }

        private void cashiersBtn_Click(object sender, EventArgs e)
        {
            var cashiersForm = new CashierGrid();
            cashiersForm.ShowDialog();
        }

        
        private void productsSellHistoryBtn_Click(object sender, EventArgs e)
        {
            var form = new SellHistoryGrid();
            form.ShowDialog();
        }
    }
}
