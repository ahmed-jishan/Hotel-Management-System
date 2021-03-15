
namespace Last_Project.All_User_Control
{
    partial class UC_FoodMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rBreakfast = new System.Windows.Forms.RadioButton();
            this.rLaunch = new System.Windows.Forms.RadioButton();
            this.rDinner = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.fName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fRoomno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 64);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(457, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 41;
            this.label1.Text = "Food Zone";
            // 
            // rBreakfast
            // 
            this.rBreakfast.AutoSize = true;
            this.rBreakfast.Location = new System.Drawing.Point(40, 104);
            this.rBreakfast.Name = "rBreakfast";
            this.rBreakfast.Size = new System.Drawing.Size(103, 24);
            this.rBreakfast.TabIndex = 3;
            this.rBreakfast.TabStop = true;
            this.rBreakfast.Text = "Breakfast";
            this.rBreakfast.UseVisualStyleBackColor = true;
            this.rBreakfast.CheckedChanged += new System.EventHandler(this.rBreakfast_CheckedChanged);
            // 
            // rLaunch
            // 
            this.rLaunch.AutoSize = true;
            this.rLaunch.Location = new System.Drawing.Point(390, 104);
            this.rLaunch.Name = "rLaunch";
            this.rLaunch.Size = new System.Drawing.Size(87, 24);
            this.rLaunch.TabIndex = 4;
            this.rLaunch.TabStop = true;
            this.rLaunch.Text = "Launch";
            this.rLaunch.UseVisualStyleBackColor = true;
            this.rLaunch.CheckedChanged += new System.EventHandler(this.rLaunch_CheckedChanged);
            // 
            // rDinner
            // 
            this.rDinner.AutoSize = true;
            this.rDinner.Location = new System.Drawing.Point(745, 104);
            this.rDinner.Name = "rDinner";
            this.rDinner.Size = new System.Drawing.Size(81, 24);
            this.rDinner.TabIndex = 5;
            this.rDinner.TabStop = true;
            this.rDinner.Text = "Dinner";
            this.rDinner.UseVisualStyleBackColor = true;
            this.rDinner.CheckedChanged += new System.EventHandler(this.rDinner_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Location = new System.Drawing.Point(40, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 383);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Pancakes",
            "Egg Parotha",
            "Alu Parotha",
            "Boiled Eggs",
            "Berry Quinoa Muffins",
            "Egg and Cheese Sandwich",
            "Flip French Toast",
            "Nectarine Bruschetta",
            "Mushroom and Spinach Bread Pudding",
            "Sausage and Egg Casserole"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(227, 383);
            this.checkedListBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkedListBox2);
            this.panel3.Location = new System.Drawing.Point(390, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 383);
            this.panel3.TabIndex = 7;
            this.panel3.Visible = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Ham sandwich",
            "Cheese sandwich",
            "Tuna mayo sandwich",
            "Egg mayo sandwich",
            "Superfood salad",
            "Spicy chicken wrap",
            "Jacket potato with filling",
            "Fish and chips"});
            this.checkedListBox2.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(224, 383);
            this.checkedListBox2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkedListBox3);
            this.panel4.Location = new System.Drawing.Point(745, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 383);
            this.panel4.TabIndex = 7;
            this.panel4.Visible = false;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox3.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Oven-Baked French Bread Pizzas",
            "Easiest One-Pot Beef with Broccoli",
            "Black Bean–Stuffed Sweet Potatoes",
            "Instant Pot Veggie-Packed Mac \'n\' Cheese",
            "Sheet Pan Sausage & Veggies",
            "Ramen",
            "Pesto Chicken Bake"});
            this.checkedListBox3.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(224, 383);
            this.checkedListBox3.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.AutoRoundedCorners = true;
            this.btnOrder.BorderRadius = 23;
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.Turquoise;
            this.btnOrder.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Location = new System.Drawing.Point(745, 575);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(224, 49);
            this.btnOrder.TabIndex = 54;
            this.btnOrder.Text = "Order";
            this.btnOrder.Visible = false;
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(91, 592);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(55, 20);
            this.fName.TabIndex = 55;
            this.fName.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Name:";
            // 
            // fRoomno
            // 
            this.fRoomno.AutoSize = true;
            this.fRoomno.Location = new System.Drawing.Point(393, 592);
            this.fRoomno.Name = "fRoomno";
            this.fRoomno.Size = new System.Drawing.Size(72, 20);
            this.fRoomno.TabIndex = 57;
            this.fRoomno.Text = "RoomNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "RoomNo:";
            // 
            // fPrice
            // 
            this.fPrice.AutoSize = true;
            this.fPrice.Location = new System.Drawing.Point(586, 592);
            this.fPrice.Name = "fPrice";
            this.fPrice.Size = new System.Drawing.Size(44, 20);
            this.fPrice.TabIndex = 59;
            this.fPrice.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Price";
            // 
            // UC_FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fRoomno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rDinner);
            this.Controls.Add(this.rLaunch);
            this.Controls.Add(this.rBreakfast);
            this.Controls.Add(this.panel1);
            this.Name = "UC_FoodMenu";
            this.Size = new System.Drawing.Size(1048, 640);
            this.Load += new System.EventHandler(this.UC_FoodMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rDinner;
        private System.Windows.Forms.RadioButton rLaunch;
        private System.Windows.Forms.RadioButton rBreakfast;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fRoomno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fPrice;
    }
}
