using System;
using System.Windows.Forms;

namespace Last_Project
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }



        //Sliding Pannel code starts from here

        bool isSpanelExpanded;
        const int MaxSliderWidth = 200;
        const int MinSliderWidth = 100;

        private void StoggleBtn_Click(object sender, EventArgs e)
        {
            if (isSpanelExpanded)
            {
                //retract panel
            }
            SPtimer.Start();
        }

        private void SPtimer_Tick(object sender, EventArgs e)
        {
            if (isSpanelExpanded)
            {
                //retract panel
                Spanel.Width -= 30;
                if (Spanel.Width <= MinSliderWidth)
                {
                    // Stop retract
                    isSpanelExpanded = false;
                    SPtimer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                Spanel.Width += 30;
                if (Spanel.Width >= MaxSliderWidth)
                {
                    //stop retrack
                    isSpanelExpanded = true;
                    SPtimer.Stop();

                    this.Refresh();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            { 
             this.Hide();
             Form1 frm = new Form1();
             frm.Show();
             }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            uC_FoodMenu1.Visible = true;
            uC_FoodMenu1.BringToFront();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           uC_Payment1.Visible = true;
           uC_Payment1.BringToFront();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uC_CustomerFeedback1.Visible = true;
            uC_CustomerFeedback1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           uC_Help1.Visible = true;
           uC_Help1.BringToFront();
        }
    }
}
