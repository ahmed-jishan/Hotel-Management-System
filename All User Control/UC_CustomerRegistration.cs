using System;
using System.Data;
using System.Windows.Forms;

namespace Last_Project.All_User_Control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        DBAccess newobj = new DBAccess();
        DataTable dtReg = new DataTable();
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        DBAccess con = new DBAccess();
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string variables = "name,phone,nationality,gender,dob,address,checkin,checkout,bed,roomtype,roomno,price"; /*Database Column Name*/
            string values = "'" + txtName.Text + "','" + txtContact.Text + "','" + txtNationality.Text + "','" + txtGender.Text + "','" + txtDob.Text + "','" + txtAddress.Text + "','" + txtCheckIn.Text + "','" + txtCheckOut.Text + "','" + txtBed.Text + "','" + txtType.Text + "','" + txtRoomno.Text + "','" + txtPrice.Text + "'"; //TextBox
            con.dataSend("INSERT INTO details(" + variables + ")  values ( " + values + " )");

            string s = "Due";
            string var = "name,roomno,status";
            string val = "'" + txtName.Text + "','" + txtRoomno.Text + "','" + s + "'";
            con.dataSend("insert into Payment(" + var + ") values (" + val + ")");

            MessageBox.Show("Record Saved Successfully");
             ClearData();
             LoadData();
        }
        private void ClearData()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtCheckOut.ResetText();
            txtBed.SelectedIndex = -1;
            txtType.SelectedIndex = -1;
            txtRoomno.Clear();
            txtPrice.Clear();
        }

        private void LoadData()
        {
            con.dataGet("Select * from [details]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            GridView2.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = GridView2.Rows.Add();
                GridView2.Rows[n].Cells["dgSL"].Value = n + 1;
                GridView2.Rows[n].Cells["dgName"].Value = row["name"].ToString();
                GridView2.Rows[n].Cells["dgPhoneNo"].Value = row["phone"].ToString();
                GridView2.Rows[n].Cells["dgNationality"].Value = row["nationality"].ToString();
                GridView2.Rows[n].Cells["dgGender"].Value = row["gender"].ToString();
                GridView2.Rows[n].Cells["dgDoB"].Value = row["dob"].ToString();
                GridView2.Rows[n].Cells["dgAddress"].Value = row["address"].ToString();
                GridView2.Rows[n].Cells["dgCheckin"].Value = row["checkin"].ToString();
                GridView2.Rows[n].Cells["dgCheckout"].Value = row["checkout"].ToString();
                GridView2.Rows[n].Cells["dgBed"].Value = row["bed"].ToString();
                GridView2.Rows[n].Cells["dgRoomtype"].Value = row["roomtype"].ToString();
                GridView2.Rows[n].Cells["dgRoomno"].Value = row["roomno"].ToString();
                GridView2.Rows[n].Cells["dgPrice"].Value = row["price"].ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Update", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("UPDATE details SET  phone ='" + txtContact.Text + "', nationality='" + txtNationality.Text + "',gender='" + txtGender.Text + "',dob='" + txtDob.Text + "',address='" + txtAddress.Text + "',checkin='" + txtCheckIn.Text + "',checkout='" + txtCheckOut.Text + "',bed='" + txtBed.Text + "',roomtype='" +txtType.Text + "',price='" + txtPrice.Text + "' where name = '"+txtName.Text+ "' and roomno='" + txtRoomno.Text + "'");
                MessageBox.Show("Update Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
        }

        private void GridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridView2.Rows[e.RowIndex];
            txtName.Text = row.Cells[1].Value.ToString();
            txtContact.Text = row.Cells[2].Value.ToString();
            txtNationality.Text= row.Cells[3].Value.ToString();
            txtGender.Text= row.Cells[4].Value.ToString();
            txtDob.Text= row.Cells[5].Value.ToString();
            txtAddress.Text = row.Cells[6].Value.ToString();
            txtCheckIn.Text = row.Cells[7].Value.ToString();
            txtCheckOut.Text= row.Cells[8].Value.ToString();
            txtBed.Text= row.Cells[9].Value.ToString();
            txtType.Text = row.Cells[10].Value.ToString();
            txtRoomno.Text = row.Cells[11].Value.ToString();
            txtPrice.Text=row.Cells[12].Value.ToString();
        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
