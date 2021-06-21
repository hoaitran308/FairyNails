using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairyNails
{
    public partial class CheckinForm : Form
    {
        DBDataContext db;
        public CheckinForm()
        {
            InitializeComponent();
            process2CheckinControl1.Hide();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1) timerFadeIn.Stop();
            Opacity += .2;
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .2;
        }

        private void powerOffCheckin_Click(object sender, EventArgs e)
        {
            timerFadeOut.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 3;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 4;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 5;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 6;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 7;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 8;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 9;
        }

        private void label0_Click(object sender, EventArgs e)
        {
            phoneNumber.Text += 0;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            phoneNumber.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            db = new DBDataContext();
            List<Customer> listCustomer = (from c in db.Customers
                                           select c).ToList<Customer>();
            bool exist = false;
            foreach (Customer cus in listCustomer)
                if (cus.cellphone == phoneNumber.Text)
                { exist = true;
                    process2CheckinControl1.customerId = cus.id;
                }
            process2CheckinControl1.phoneNumber = phoneNumber.Text;
            if (!exist)
            {
                process2CheckinControl1.ReLoadProcess();
            }
            else
            {
                process2CheckinControl1.ReLoadProcess2();
            }
            process2CheckinControl1.Show();
            process2CheckinControl1.BringToFront();
            phoneNumber.Text = "";
        }

        private void iconControlPanel_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            var form2 = new FairyNailsForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
