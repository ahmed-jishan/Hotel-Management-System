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
    public partial class UC_CustomerDetails : UserControl
    {
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void sGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DBAccess con = new DBAccess();
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                sGridView.Rows.Clear();
            }
            else
            {
                con.dataGet("Select details.name,details.roomno,phone,nationality,gender,dob,address,checkin,checkout,bed,roomtype,price,Feedback.opinion from [details],[Feedback] Where details.name = Feedback.name and details.roomno = Feedback.roomno and details.name like '%" + txtName.Text + "%'");
                DataTable dt = new DataTable();
                con.sda.Fill(dt);
                sGridView.Rows.Clear();
                if (dt.Rows.Count < 0)
                {
                    MessageBox.Show("There is no customer with this name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        //MessageBox.Show(row["name"].ToString());
                        int n = sGridView.Rows.Add();
                        sGridView.Rows[n].Cells["dgSL"].Value = n + 1;
                        sGridView.Rows[n].Cells["dgName"].Value = row["name"].ToString();
                        sGridView.Rows[n].Cells["dgPhoneNo"].Value = row["phone"].ToString();
                        sGridView.Rows[n].Cells["dgNationality"].Value = row["nationality"].ToString();
                        sGridView.Rows[n].Cells["dgGender"].Value = row["gender"].ToString();
                        sGridView.Rows[n].Cells["dgDoB"].Value = row["dob"].ToString();
                        sGridView.Rows[n].Cells["dgAddress"].Value = row["address"].ToString();
                        sGridView.Rows[n].Cells["dgCheckin"].Value = row["checkin"].ToString();
                        sGridView.Rows[n].Cells["dgCheckout"].Value = row["checkout"].ToString();
                        sGridView.Rows[n].Cells["dgBed"].Value = row["bed"].ToString();
                        sGridView.Rows[n].Cells["dgRoomtype"].Value = row["roomtype"].ToString();
                        sGridView.Rows[n].Cells["dgRoomno"].Value = row["roomno"].ToString();
                        sGridView.Rows[n].Cells["dgPrice"].Value = row["price"].ToString();
                        sGridView.Rows[n].Cells["dgFeedback"].Value = row["opinion"].ToString();
                    }
                }
            }
        }
    }
}
