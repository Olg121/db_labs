using db.DbModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db.Controls
{
    public partial class CashierControl : UserControl
    {
        private int id = 0; 
        public Cashier Cashier
        {
            get  
            {

                return
                    new()
                    {
                        FirstName = firstNameTB.Text,
                        Surname = surnameTB.Text,
                        MiddleName = middleNameTB.Text,
                        Id = id
                    };
            }
            set 
            {
                id = value.Id;
                firstNameTB.Text = value.FirstName;
                surnameTB.Text = value.Surname; 
                middleNameTB.Text = value.MiddleName; 
            }
        }
        public CashierControl()
        {
            InitializeComponent();
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
