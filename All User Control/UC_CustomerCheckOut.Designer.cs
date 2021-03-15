
namespace Last_Project.All_User_Control
{
    partial class UC_CustomerCheckOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.dgSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Customer Check Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(496, 116);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(353, 47);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 42;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToAddRows = false;
            this.GridView1.AllowUserToDeleteRows = false;
            this.GridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSl,
            this.dgName,
            this.dgRoomNo,
            this.dgType,
            this.dgCheckin,
            this.dgCheckout,
            this.dgPhone});
            this.GridView1.Location = new System.Drawing.Point(23, 214);
            this.GridView1.Name = "GridView1";
            this.GridView1.ReadOnly = true;
            this.GridView1.RowHeadersWidth = 62;
            this.GridView1.RowTemplate.Height = 28;
            this.GridView1.Size = new System.Drawing.Size(1228, 426);
            this.GridView1.TabIndex = 43;
            this.GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellContentClick);
            // 
            // dgSl
            // 
            this.dgSl.HeaderText = "SL. No.";
            this.dgSl.MinimumWidth = 8;
            this.dgSl.Name = "dgSl";
            this.dgSl.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.MinimumWidth = 8;
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgRoomNo
            // 
            this.dgRoomNo.HeaderText = "Room No";
            this.dgRoomNo.MinimumWidth = 8;
            this.dgRoomNo.Name = "dgRoomNo";
            this.dgRoomNo.ReadOnly = true;
            // 
            // dgType
            // 
            this.dgType.HeaderText = "Room Type";
            this.dgType.MinimumWidth = 8;
            this.dgType.Name = "dgType";
            this.dgType.ReadOnly = true;
            // 
            // dgCheckin
            // 
            this.dgCheckin.HeaderText = "Check In";
            this.dgCheckin.MinimumWidth = 8;
            this.dgCheckin.Name = "dgCheckin";
            this.dgCheckin.ReadOnly = true;
            // 
            // dgCheckout
            // 
            this.dgCheckout.HeaderText = "Check Out";
            this.dgCheckout.MinimumWidth = 8;
            this.dgCheckout.Name = "dgCheckout";
            this.dgCheckout.ReadOnly = true;
            // 
            // dgPhone
            // 
            this.dgPhone.HeaderText = "Phone";
            this.dgPhone.MinimumWidth = 8;
            this.dgPhone.Name = "dgPhone";
            this.dgPhone.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 661);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(376, 661);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Room No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Check Out";
            // 
            // txtName2
            // 
            this.txtName2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName2.DefaultText = "";
            this.txtName2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName2.DisabledState.Parent = this.txtName2;
            this.txtName2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName2.FocusedState.Parent = this.txtName2;
            this.txtName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtName2.ForeColor = System.Drawing.Color.Black;
            this.txtName2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName2.HoverState.Parent = this.txtName2;
            this.txtName2.Location = new System.Drawing.Point(23, 690);
            this.txtName2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName2.Name = "txtName2";
            this.txtName2.PasswordChar = '\0';
            this.txtName2.PlaceholderText = "Enter Full Name";
            this.txtName2.SelectedText = "";
            this.txtName2.ShadowDecoration.Parent = this.txtName2;
            this.txtName2.Size = new System.Drawing.Size(252, 47);
            this.txtName2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName2.TabIndex = 47;
            // 
            // txtRoomno
            // 
            this.txtRoomno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomno.DefaultText = "";
            this.txtRoomno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomno.DisabledState.Parent = this.txtRoomno;
            this.txtRoomno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomno.FocusedState.Parent = this.txtRoomno;
            this.txtRoomno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtRoomno.ForeColor = System.Drawing.Color.Black;
            this.txtRoomno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomno.HoverState.Parent = this.txtRoomno;
            this.txtRoomno.Location = new System.Drawing.Point(380, 690);
            this.txtRoomno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRoomno.Name = "txtRoomno";
            this.txtRoomno.PasswordChar = '\0';
            this.txtRoomno.PlaceholderText = "Enter Full Name";
            this.txtRoomno.SelectedText = "";
            this.txtRoomno.ShadowDecoration.Parent = this.txtRoomno;
            this.txtRoomno.Size = new System.Drawing.Size(258, 47);
            this.txtRoomno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomno.TabIndex = 48;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.CheckedState.Parent = this.txtCheckOut;
            this.txtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckOut.HoverState.Parent = this.txtCheckOut;
            this.txtCheckOut.Location = new System.Drawing.Point(697, 697);
            this.txtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ShadowDecoration.Parent = this.txtCheckOut;
            this.txtCheckOut.Size = new System.Drawing.Size(234, 40);
            this.txtCheckOut.TabIndex = 67;
            this.txtCheckOut.Value = new System.DateTime(2021, 2, 18, 2, 46, 46, 952);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoRoundedCorners = true;
            this.btnCheckout.BorderRadius = 22;
            this.btnCheckout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnCheckout.BorderThickness = 1;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCheckout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckout.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.CheckedState.Parent = this.btnCheckout;
            this.btnCheckout.CustomImages.Parent = this.btnCheckout;
            this.btnCheckout.FillColor = System.Drawing.Color.White;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.HoverState.Parent = this.btnCheckout;
            this.btnCheckout.Location = new System.Drawing.Point(1021, 690);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ShadowDecoration.Parent = this.btnCheckout;
            this.btnCheckout.Size = new System.Drawing.Size(189, 46);
            this.btnCheckout.TabIndex = 77;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_CustomerCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.txtRoomno);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_CustomerCheckOut";
            this.Size = new System.Drawing.Size(1279, 799);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtName2;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomno;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhone;
    }
}
