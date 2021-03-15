using System;
using System.Data;
using System.Windows.Forms;

namespace Last_Project
{
    public partial class Form1 : Form
    {
        DBAccess newobj = new DBAccess();
        DataTable dtReg = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DBAccess con = new DBAccess();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from admin where Name ='" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "' ");
            DataTable dt = new DataTable();

            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Dashboard frm = new Dashboard();
                frm.Show();
            }
            else

            {
                MessageBox.Show("Invalid Name & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                User_Panel frm = new User_Panel();
                frm.Show();
            
        }
    }
}
