using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Eskom__Prepaid_Electricity
{
    public partial class frmEskom : Form
    {
        public frmEskom()
        {
            InitializeComponent();
        }

        private void frmEskom_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            double amount = 0;
            string meterNumber = txtMeterNumber.Text;




            if (meterNumber.Length < 10 ) {
                
                MessageBox.Show("Incorrect Meter number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                amount = Convert.ToDouble(txtAmount.Text.Trim());

                if (amount >= 20)
                {
                    MessageBox.Show("Good");

                    double vat = amount * 0.15;
                    double purchace = amount - vat;

                    //1 unit = R2.35
                    double total =  purchace / 2.35; //  format to 2 decimal

                    //Create token 
                    Random rand = new Random();

                    int t1, t2, t3, t4, t5;
                    t1 = rand.Next(1000, 10000);
                    t2 = rand.Next(1000, 10000);
                    t3 = rand.Next(1000, 10000);
                    t4 = rand.Next(1000, 10000);
                    t5 = rand.Next(1000, 10000);

                    lblToken.Text = t1.ToString() + " " + t2.ToString() + " " +t3.ToString() + " " + t4.ToString() + " " + t5.ToString();
                    lblUnit.Text = total.ToString() + " Kwh";
                    lblVat.Text =  vat.ToString();


                }
                else
                {
                    MessageBox.Show("Minimum purchase amount is R20.000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /*Forces user to only inout Numeric Data*/
        private void txtMeterNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
           /* if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}
