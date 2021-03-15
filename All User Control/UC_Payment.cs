using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last_Project.All_User_Control
{
    public partial class UC_Payment : UserControl
    {
        DBAccess con = new DBAccess();
        public UC_Payment()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                btnPay.Show();
                Box1.Hide();              
                panel1.Show();
                btnTaka.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnPay.Hide();
            panel1.Hide();
            Box1.Show();
            btnTaka.Show();
        }

        private void UC_Payment_Load(object sender, EventArgs e)
        {
            LoadInfo();
            if (label17.Text == "Paid")
            {
                radioButton1.Hide();
                radioButton2.Hide();
            }
        }

        private void LoadInfo()
        {
            con.dataGet("Select * from details Where name = '" + username.name + "' and roomno = '" + username.roomno + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                label9.Text = row["name"].ToString();
                label8.Text = row["phone"].ToString();
                label14.Text = row["bed"].ToString();
                label15.Text = row["roomtype"].ToString();
                label16.Text = row["roomno"].ToString();
                label17.Text = row["price"].ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == "" )
            {
                MessageBox.Show("Enter the amount first then click Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(label17.Text != guna2TextBox3.Text)
            {
                MessageBox.Show("Enter the Right amount first then click Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.dataSend("Update details Set price = 'Paid' Where name = '" + username.name + "' and roomno = '" + username.roomno + "'");
                con.dataSend("Update Payment Set status = 'Paid' Where name = '" + username.name + "' and roomno = '" + username.roomno + "'");
                MessageBox.Show("Paid Successfully");
                label17.Text = "Paid";
            }
        }

        private void btnTaka_Click(object sender, EventArgs e)
        {
            if(Box1.Text == "")
            {
                MessageBox.Show("Enter the amount first then click Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(label17.Text != Box1.Text)
            {
                MessageBox.Show("Enter the Right amount first then click Payment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.dataSend("Update details Set price = 'Paid' Where name = '" + username.name + "' and roomno = '" + username.roomno + "'");
                con.dataSend("Update Payment Set status = 'Paid' Where name = '" + username.name + "' and roomno = '" + username.roomno + "'");
                MessageBox.Show("Paid Successfully");
                label17.Text = "Paid";
            }
        }
    }
}
