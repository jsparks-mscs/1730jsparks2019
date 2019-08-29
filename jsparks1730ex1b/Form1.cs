using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsparks1730ex1b
{
    public partial class Form1 : Form
    {
        private object txtDiscountPercent;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e, object txtDiscountPrecent)
        {

            txtDiscountamount.Text =
               (Convert.ToDecimal(txtSubtotal.Text)
               * Convert.ToDecimal(txtDiscountprecent.Text) / 100).ToString("0.00");
            txtTotal.Text = 
                (Convert.ToDecimal(txtSubtotal.Text)
               - Convert.ToDecimal(txtDiscountamount.Text) / 100).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    internal class txtDiscountprecent
    {
        public static object Text { get; internal set; }
    }
}
