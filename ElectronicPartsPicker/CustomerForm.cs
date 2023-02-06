using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicPartsPicker
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            FrmOrderForm of = new FrmOrderForm();
            of.ShowDialog();
        }
    }
}
