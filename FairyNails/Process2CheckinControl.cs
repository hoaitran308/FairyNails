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
    public partial class Process2CheckinControl : UserControl
    {
        public string customerFullName;
        public bool customerGender;
        public DateTime customerBirthday;
        public int serviceId;
        public double opacity;
        public string phoneNumber;
        public int customerId;
        DBDataContext db;
        public Process2CheckinControl()
        {
            InitializeComponent();
            phoneNumber = "";
            customerId = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // done name
            customerFullName = textbox1.Text;
            button1.Visible = false;
            textbox1.Visible = false;

            // show gender
            button2.Visible = true;
            comboBox1.Visible = true;
            label11.Text = "Please select your gender\nYour info will not be shared";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // done gender
            customerGender = comboBox1.Text == "Male";
            button2.Visible = false;
            comboBox1.Visible = false;

            // show birthday
            dateTimePicker1.Visible = true;
            button3.Visible = true;
            label11.Text = "Please choose your birthday\nYour info will not be shared";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // done birthday
            customerBirthday = dateTimePicker1.Value;
            dateTimePicker1.Visible = false;
            button3.Visible = false;

            // show services
            comboBox3.Visible = true;
            label2.Visible = true;
            button4.Visible = true;
            comboBox4.Visible = true;
            label6.Visible = true;
            label6.Visible = true;
            comboBox4.Visible = true;
            label11.Text = "Please choose service you want to experience\nYour info will not be shared";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // done service
            serviceId = Convert.ToInt32(comboBox3.SelectedValue);
            label11.Visible = false;
            comboBox3.Visible = false;
            label2.Visible = false;
            button4.Visible = false;
            label3.Visible = false;
            comboBox4.Visible = false;
            label6.Visible = false;
            comboBox4.Visible = false;

            db = new DBDataContext();
            if (customerId == 0)
            {
                Customer customer = new Customer();
                customer.name = customerFullName;
                customer.sex = customerGender;
                customer.cellphone = phoneNumber;
                customer.birthday = customerBirthday;
                db.Customers.InsertOnSubmit(customer);
                db.SubmitChanges();
                customerId = (from c in db.Customers
                              where c.cellphone == phoneNumber
                              select c).Single<Customer>().id;
            }
            else
            {
                customerFullName = (from c in db.Customers
                                    where c.cellphone == phoneNumber
                                    select c).Single<Customer>().name;
            }

            // done all, insert to database
            Work work = new Work();
            work.service_id = Convert.ToInt32(comboBox3.SelectedValue);
            work.staff_id = Convert.ToInt32(comboBox4.SelectedValue);
            work.status = 0;
            work.customer_id = customerId;
            work.time = DateTime.Now;
            db.Works.InsertOnSubmit(work);
            db.SubmitChanges();

            // back to home
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = customerFullName;
            label5.Visible = true;
            pictureBox1.Visible = true;

            
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (opacity <= 0)
            {
                timer1.Stop();
                ReLoadProcess();
                this.Hide();
            }
            opacity -= .2;
        }

        private void Process2CheckinControl_Load(object sender, EventArgs e)
        {
            db = new DBDataContext();

            // load  services
            var listServices = from s in db.Services
                               select s;
            comboBox3.DataSource = listServices;
            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "id";

            // load staff
            var listStaff = from s in db.Staffs
                            select s;
            comboBox4.DataSource = listStaff;
            comboBox4.DisplayMember = "name";
            comboBox4.ValueMember = "id";
        }
        public void ReLoadProcess2()
        {
            comboBox3.Visible = true;
            label2.Visible = true;
            button4.Visible = true;
            label6.Visible = true;
            comboBox4.Visible = true;
            opacity = 1;
            label11.Text = "Please choose service you want to experience\nYour info will not be shared";
            label11.Visible = false;
            button1.Visible = false;
            textbox1.Visible = false;
            button2.Visible = false;
            comboBox1.Visible = false;
            dateTimePicker1.Visible = false;
            button3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = false;

        }
        public void ReLoadProcess()
        {
            opacity = 1;
            label11.Text = "Please enter your full name\nYour info will not be shared";
            label11.Visible = true;
            button1.Visible = true;
            textbox1.Visible = true;
            button2.Visible = false;
            comboBox1.Visible = false;
            dateTimePicker1.Visible = false;
            button3.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = false;
            label6.Visible = false;
            comboBox4.Visible = false;
            customerId = 0;
        }

    }
}
