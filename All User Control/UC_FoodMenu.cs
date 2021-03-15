using System;
using System.Data;
using System.Windows.Forms;

namespace Last_Project.All_User_Control
{
    public partial class UC_FoodMenu : UserControl
    {
        DBAccess con = new DBAccess();
        public UC_FoodMenu()
        {
            InitializeComponent();
        }

        private void rBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            btnOrder.Show();
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
        }

        private void rLaunch_CheckedChanged(object sender, EventArgs e)
        {
            btnOrder.Show();
            panel3.Show();
            panel2.Hide();
            panel4.Hide();
        }

        private void rDinner_CheckedChanged(object sender, EventArgs e)
        {
            btnOrder.Show();
            panel4.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void UC_FoodMenu_Load(object sender, EventArgs e)
        {
            Loadinfo();
        }
        private void Loadinfo()
        {
            con.dataGet("Select * from details Where name = '" + username.name + "' and roomno = '" + username.roomno + "'");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                fName.Text = row["name"].ToString(); 
                fRoomno.Text = row["roomno"].ToString();
                
            }
        }
    }
}
