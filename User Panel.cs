using System;
using System.Data;
using System.Windows.Forms;

namespace Last_Project
{
    public partial class User_Panel : Form
    {
        public User_Panel()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
        DBAccess con = new DBAccess();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.dataGet("Select * from details where name ='" + txtUsername.Text + "' and roomno = '" + txtPassword.Text + "' ");
            DataTable dt = new DataTable();

            con.sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    username.name = row["name"].ToString();
                    username.roomno = row["roomno"].ToString();
                }
                this.Hide();
                UserMenu frm = new UserMenu();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Name & Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
