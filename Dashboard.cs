using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
            Movingpanel.Left = btnCustomerRegistration.Left + 8;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
            Movingpanel.Left = btnCustomerDetails.Left + 8;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
            Movingpanel.Left = btnCheckOut.Left + 8;
        }

       // private void btnAddroom_Click(object sender, EventArgs e)
        //{
           // Movingpanel.Left = btnAddroom.Left + 8;
       // }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
            Movingpanel.Left = btnEmployee.Left + 8;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
