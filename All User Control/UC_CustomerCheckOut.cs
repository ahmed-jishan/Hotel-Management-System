using System;
using System.Data;
using System.Windows.Forms;

namespace Last_Project.All_User_Control
{

    public partial class UC_CustomerCheckOut : UserControl
    {
        DBAccess con = new DBAccess();
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                GridView1.Rows.Clear();
            }
            else
            {

                con.dataGet("Select name,roomno,roomtype,checkin,checkout,phone From details where name like '%" + txtName.Text + "%' ");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                GridView1.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    int n = GridView1.Rows.Add();
                    GridView1.Rows[n].Cells["dgSl"].Value = n + 1;
                    GridView1.Rows[n].Cells["dgName"].Value = row["name"].ToString();
                    GridView1.Rows[n].Cells["dgRoomNo"].Value = row["roomno"].ToString();
                    GridView1.Rows[n].Cells["dgType"].Value = row["roomtype"].ToString();
                    GridView1.Rows[n].Cells["dgCheckin"].Value = row["checkin"].ToString();
                    GridView1.Rows[n].Cells["dgCheckout"].Value = row["checkout"].ToString();
                    GridView1.Rows[n].Cells["dgPhone"].Value = row["phone"].ToString();
                }
            }
        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridView1.Rows[e.RowIndex];
            txtName2.Text= row.Cells[1].Value.ToString();
            txtRoomno.Text= row.Cells[2].Value.ToString();
            txtCheckOut.Text= row.Cells[5].Value.ToString();

        }


        //CHECK OUT
         private void btnCheckout_Click(object sender, EventArgs e)
         {
             DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
             if (dialogResult == DialogResult.Yes)
             {
                 con.dataSend("Delete from details where roomno ='" + txtRoomno.Text + "' and name='" + txtName2.Text + "'");
                 con.dataSend("Delete from Payment where roomno ='" + txtRoomno.Text + "' and name='" + txtName2.Text + "'");
                 con.dataSend("Delete from Feedback where roomno ='" + txtRoomno.Text + "' and name='" + txtName2.Text + "'");
                 MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 txtCheckOut.ResetText();
                 txtRoomno.Clear();
                 txtName2.Clear();
                // LoadData();

             }
         }
    }
}
