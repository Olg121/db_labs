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

namespace db.Lab9
{
    public partial class CashiersControl : UserControl
    {
        public CashiersControl()
        {
            InitializeComponent();
            mainPanel.Controls.Remove(saveCancelPanel);
            RefreshGridData();
            // cashierGrid.SelectionChanged += SelectedRowChanged;
        }

        public bool IsCrudMode = true;

        public void SelectedRowChanged(object obj, EventArgs ea)
        {
            if (obj is Cashier cashier && IsCrudMode)
            {
                cashierControl1.Cashier = cashier;
            }
        }

        public void RefreshGridData(string filter = null)
        {
           var data = LinqExprs.GetCashiers(filter);
            cashierGrid.Cashiers = data;
            cashierGrid.Refresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var selectedCashier = cashierGrid.GetSelectedCashier(); 

            if (selectedCashier is not null)
            {
                SetUpdateMode();
                cashierControl1.Cashier = selectedCashier;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            LinqExprs.UpdateCashier(cashierControl1.Cashier);
            SetCrudMode();
            RefreshGridData();
            cashierControl1.Cashier = null;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshGridData(filterTB.Text);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            LinqExprs.DeleteCashier(cashierGrid.GetSelectedCashier());
            RefreshGridData();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            LinqExprs.InsertCashier(cashierControl1.Cashier);
            RefreshGridData();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            SetCrudMode();
            cashierControl1.Cashier = null;
        }

        private void SetCrudMode()
        {
            mainPanel.Controls.Remove(saveCancelPanel);
            mainPanel.Controls.Remove(filterPanel);
            mainPanel.Controls.Add(crudPanel);
            IsCrudMode = true;
        }

        private void SetUpdateMode()
        {
            mainPanel.Controls.Add(saveCancelPanel);
            mainPanel.Controls.Add(filterPanel);
            mainPanel.Controls.Remove(crudPanel);
            IsCrudMode = false;

        }
    }
}
