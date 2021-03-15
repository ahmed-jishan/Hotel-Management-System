using System;
using System.Data;
using System.Windows.Forms;

namespace Last_Project.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        DBAccess newobj = new DBAccess();
        DataTable dtReg = new DataTable();
        public UC_Employee()
        {
            InitializeComponent();
        }
        DBAccess con = new DBAccess();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string variables = "eid,ename,mobile,gender,emailid,username,password"; /*Database Column Name*/
            string values = "'" +textid.Text + "','" +txtName.Text + "','" + txtMobile.Text + "','" + txtGender.Text + "','" + txtEmail.Text + "','" + txtUsername.Text + "','" +txtPassword.Text + "'"; //TextBox

            con.dataSend("INSERT INTO employee(" + variables + ")  values ( " + values + " )");


            MessageBox.Show("Record Saved Successfully");
            ClearData();
           
        }
        private void ClearData()
        {
            textid.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void tabemployee_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.dataGet("Select * from [employee]");
            DataTable dt = new DataTable();
            con.sda.Fill(dt);
            GridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int n = GridView1.Rows.Add();
                GridView1.Rows[n].Cells["dgSL"].Value = row["eid"].ToString();
                GridView1.Rows[n].Cells["dgName"].Value = row["ename"].ToString();
                GridView1.Rows[n].Cells["dgMobile"].Value = row["mobile"].ToString();
                GridView1.Rows[n].Cells["dgGender"].Value = row["gender"].ToString();
                GridView1.Rows[n].Cells["dgEmail"].Value = row["emailid"].ToString();
                GridView1.Rows[n].Cells["dgUsername"].Value = row["username"].ToString();
                GridView1.Rows[n].Cells["dgPassword"].Value = row["password"].ToString();
            }
        }
 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Delete", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.dataSend("Delete from employee where eid='" + txtId.Text + "'");
                MessageBox.Show("Delete Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               //LoadData();

            }
        }
    }        
    
}
