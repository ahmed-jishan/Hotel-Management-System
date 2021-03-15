
namespace Last_Project
{
    partial class UserMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            this.Spanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.StoggleBtn = new System.Windows.Forms.Button();
            this.SPtimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_CustomerFeedback1 = new Last_Project.All_User_Control.UC_CustomerFeedback();
            this.uC_Payment1 = new Last_Project.All_User_Control.UC_Payment();
            this.uC_FoodMenu1 = new Last_Project.All_User_Control.UC_FoodMenu();
            this.uC_Help1 = new Last_Project.All_User_Control.UC_Help();
            this.Spanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spanel
            // 
            this.Spanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Spanel.Controls.Add(this.button5);
            this.Spanel.Controls.Add(this.btnLogout);
            this.Spanel.Controls.Add(this.button4);
            this.Spanel.Controls.Add(this.button3);
            this.Spanel.Controls.Add(this.btnPayment);
            this.Spanel.Controls.Add(this.btnFood);
            this.Spanel.Controls.Add(this.StoggleBtn);
            this.Spanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Spanel.Location = new System.Drawing.Point(0, 0);
            this.Spanel.Name = "Spanel";
            this.Spanel.Size = new System.Drawing.Size(300, 640);
            this.Spanel.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Cyan;
            this.button5.Location = new System.Drawing.Point(0, 543);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 94);
            this.button5.TabIndex = 21;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(300, 93);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 71);
            this.button4.TabIndex = 19;
            this.button4.Text = "Feedback";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 77);
            this.button3.TabIndex = 18;
            this.button3.Text = "Help";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(0, 195);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(300, 107);
            this.btnPayment.TabIndex = 17;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Location = new System.Drawing.Point(0, 95);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(300, 100);
            this.btnFood.TabIndex = 16;
            this.btnFood.Text = "Food Menu";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // StoggleBtn
            // 
            this.StoggleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StoggleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoggleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoggleBtn.Image = ((System.Drawing.Image)(resources.GetObject("StoggleBtn.Image")));
            this.StoggleBtn.Location = new System.Drawing.Point(0, 0);
            this.StoggleBtn.Name = "StoggleBtn";
            this.StoggleBtn.Size = new System.Drawing.Size(300, 95);
            this.StoggleBtn.TabIndex = 15;
            this.StoggleBtn.UseVisualStyleBackColor = false;
            this.StoggleBtn.Click += new System.EventHandler(this.StoggleBtn_Click);
            // 
            // SPtimer
            // 
            this.SPtimer.Tick += new System.EventHandler(this.SPtimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.uC_Help1);
            this.panel1.Controls.Add(this.uC_CustomerFeedback1);
            this.panel1.Controls.Add(this.uC_Payment1);
            this.panel1.Controls.Add(this.uC_FoodMenu1);
            this.panel1.Location = new System.Drawing.Point(306, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 640);
            this.panel1.TabIndex = 15;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // uC_CustomerFeedback1
            // 
            this.uC_CustomerFeedback1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerFeedback1.Location = new System.Drawing.Point(0, 3);
            this.uC_CustomerFeedback1.Name = "uC_CustomerFeedback1";
            this.uC_CustomerFeedback1.Size = new System.Drawing.Size(1048, 640);
            this.uC_CustomerFeedback1.TabIndex = 2;
            this.uC_CustomerFeedback1.Visible = false;
            // 
            // uC_Payment1
            // 
            this.uC_Payment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_Payment1.Location = new System.Drawing.Point(0, 3);
            this.uC_Payment1.Name = "uC_Payment1";
            this.uC_Payment1.Size = new System.Drawing.Size(1048, 640);
            this.uC_Payment1.TabIndex = 1;
            this.uC_Payment1.Visible = false;
            // 
            // uC_FoodMenu1
            // 
            this.uC_FoodMenu1.BackColor = System.Drawing.Color.White;
            this.uC_FoodMenu1.Location = new System.Drawing.Point(0, 3);
            this.uC_FoodMenu1.Name = "uC_FoodMenu1";
            this.uC_FoodMenu1.Size = new System.Drawing.Size(1048, 634);
            this.uC_FoodMenu1.TabIndex = 0;
            this.uC_FoodMenu1.Visible = false;
            // 
            // uC_Help1
            // 
            this.uC_Help1.BackColor = System.Drawing.Color.White;
            this.uC_Help1.Location = new System.Drawing.Point(-3, -3);
            this.uC_Help1.Name = "uC_Help1";
            this.uC_Help1.Size = new System.Drawing.Size(1048, 640);
            this.uC_Help1.TabIndex = 3;
            this.uC_Help1.Visible = false;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Spanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Spanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Spanel;
        private System.Windows.Forms.Button StoggleBtn;
        private System.Windows.Forms.Timer SPtimer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.UC_FoodMenu uC_FoodMenu1;
        private System.Windows.Forms.Button button5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.UC_Payment uC_Payment1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.UC_CustomerFeedback uC_CustomerFeedback1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.UC_Help uC_Help1;
    }
}