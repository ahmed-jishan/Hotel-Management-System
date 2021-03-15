using System;
using System.Data;
using System.Windows.Forms;

namespace Last_Project.All_User_Control
{
    public partial class UC_CustomerFeedback : UserControl
    {
        DBAccess newobj = new DBAccess();
        DataTable dtReg = new DataTable();
        public UC_CustomerFeedback()
        {
            InitializeComponent();
        }
        DBAccess con = new DBAccess();
        private void btnSend_Click(object sender, EventArgs e)
        {
            string variables = "name,roomno,opinion"; /*Database Column Name*/
            string values = "'" + txtName.Text + "','" + txtRoomno.Text + "','" + txtFeedback.Text + "'"; //TextBox
            con.dataSend("INSERT INTO Feedback(" + variables + ")  values ( " + values + " )");
            MessageBox.Show("Record Saved Successfully");
            ClearData();
        }
        private void ClearData()
        {
            txtName.Clear();
            txtRoomno.Clear();
            txtFeedback.Clear();
        }
    }
}
