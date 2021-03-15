
namespace Last_Project.All_User_Control
{
    partial class UC_CustomerRegistration
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
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GridView2 = new System.Windows.Forms.DataGridView();
            this.dgSl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRoomno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            this.SuspendLayout();
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
            this.txtName.Location = new System.Drawing.Point(16, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(353, 47);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 41;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Phone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Customer Registration";
            // 
            // txtContact
            // 
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.Parent = this.txtContact;
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.FocusedState.Parent = this.txtContact;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.HoverState.Parent = this.txtContact;
            this.txtContact.Location = new System.Drawing.Point(16, 159);
            this.txtContact.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderText = "Enter Contact Number";
            this.txtContact.SelectedText = "";
            this.txtContact.ShadowDecoration.Parent = this.txtContact;
            this.txtContact.Size = new System.Drawing.Size(353, 47);
            this.txtContact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtContact.TabIndex = 42;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGender.FocusedState.Parent = this.txtGender;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.HoverState.Parent = this.txtGender;
            this.txtGender.ItemHeight = 30;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.txtGender.ItemsAppearance.Parent = this.txtGender;
            this.txtGender.Location = new System.Drawing.Point(16, 344);
            this.txtGender.Name = "txtGender";
            this.txtGender.ShadowDecoration.Parent = this.txtGender;
            this.txtGender.Size = new System.Drawing.Size(353, 36);
            this.txtGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGender.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nationality";
            // 
            // txtNationality
            // 
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.Parent = this.txtNationality;
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.FocusedState.Parent = this.txtNationality;
            this.txtNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNationality.ForeColor = System.Drawing.Color.Black;
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.HoverState.Parent = this.txtNationality;
            this.txtNationality.Location = new System.Drawing.Point(16, 243);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.PlaceholderText = "Nationality";
            this.txtNationality.SelectedText = "";
            this.txtNationality.ShadowDecoration.Parent = this.txtNationality;
            this.txtNationality.Size = new System.Drawing.Size(353, 47);
            this.txtNationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNationality.TabIndex = 45;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.CheckedState.Parent = this.txtCheckOut;
            this.txtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckOut.HoverState.Parent = this.txtCheckOut;
            this.txtCheckOut.Location = new System.Drawing.Point(412, 336);
            this.txtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.ShadowDecoration.Parent = this.txtCheckOut;
            this.txtCheckOut.Size = new System.Drawing.Size(353, 40);
            this.txtCheckOut.TabIndex = 66;
            this.txtCheckOut.Value = new System.DateTime(2021, 2, 18, 2, 46, 46, 952);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(408, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 65;
            this.label9.Text = "Check Out";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.CheckedState.Parent = this.txtCheckIn;
            this.txtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckIn.HoverState.Parent = this.txtCheckIn;
            this.txtCheckIn.Location = new System.Drawing.Point(412, 246);
            this.txtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ShadowDecoration.Parent = this.txtCheckIn;
            this.txtCheckIn.Size = new System.Drawing.Size(353, 40);
            this.txtCheckIn.TabIndex = 64;
            this.txtCheckIn.Value = new System.DateTime(2021, 2, 18, 2, 46, 46, 952);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(412, 159);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Complete Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(353, 47);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "Check In";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Address";
            // 
            // txtDob
            // 
            this.txtDob.CheckedState.Parent = this.txtDob;
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDob.HoverState.Parent = this.txtDob;
            this.txtDob.Location = new System.Drawing.Point(412, 62);
            this.txtDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDob.Name = "txtDob";
            this.txtDob.ShadowDecoration.Parent = this.txtDob;
            this.txtDob.Size = new System.Drawing.Size(353, 46);
            this.txtDob.TabIndex = 60;
            this.txtDob.Value = new System.DateTime(2021, 2, 18, 2, 58, 37, 157);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Date of Birth";
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
            this.txtRoomno.Location = new System.Drawing.Point(839, 239);
            this.txtRoomno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRoomno.Name = "txtRoomno";
            this.txtRoomno.PasswordChar = '\0';
            this.txtRoomno.PlaceholderText = "Room No";
            this.txtRoomno.SelectedText = "";
            this.txtRoomno.ShadowDecoration.Parent = this.txtRoomno;
            this.txtRoomno.Size = new System.Drawing.Size(353, 47);
            this.txtRoomno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomno.TabIndex = 74;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(839, 329);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(355, 47);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(835, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 21);
            this.label13.TabIndex = 72;
            this.label13.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(837, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 71;
            this.label12.Text = "Room No";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Transparent;
            this.txtType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.FocusedState.Parent = this.txtType;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.HoverState.Parent = this.txtType;
            this.txtType.ItemHeight = 30;
            this.txtType.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.txtType.ItemsAppearance.Parent = this.txtType;
            this.txtType.Location = new System.Drawing.Point(839, 147);
            this.txtType.Name = "txtType";
            this.txtType.ShadowDecoration.Parent = this.txtType;
            this.txtType.Size = new System.Drawing.Size(353, 36);
            this.txtType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtType.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(835, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 21);
            this.label11.TabIndex = 69;
            this.label11.Text = "Room Type";
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.Transparent;
            this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBed.FocusedState.Parent = this.txtBed;
            this.txtBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBed.ForeColor = System.Drawing.Color.Black;
            this.txtBed.HoverState.Parent = this.txtBed;
            this.txtBed.ItemHeight = 30;
            this.txtBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txtBed.ItemsAppearance.Parent = this.txtBed;
            this.txtBed.Location = new System.Drawing.Point(841, 61);
            this.txtBed.Name = "txtBed";
            this.txtBed.ShadowDecoration.Parent = this.txtBed;
            this.txtBed.Size = new System.Drawing.Size(353, 36);
            this.txtBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtBed.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(837, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 21);
            this.label10.TabIndex = 67;
            this.label10.Text = "Bed";
            // 
            // GridView2
            // 
            this.GridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSl,
            this.dgName,
            this.dgPhoneNo,
            this.dgNationality,
            this.dgGender,
            this.dgDoB,
            this.dgAddress,
            this.dgCheckin,
            this.dgCheckout,
            this.dgBed,
            this.dgRoomtype,
            this.dgRoomno,
            this.dgPrice});
            this.GridView2.Location = new System.Drawing.Point(16, 414);
            this.GridView2.Name = "GridView2";
            this.GridView2.RowHeadersWidth = 62;
            this.GridView2.RowTemplate.Height = 28;
            this.GridView2.Size = new System.Drawing.Size(961, 342);
            this.GridView2.TabIndex = 75;
            this.GridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView2_CellContentClick);
            // 
            // dgSl
            // 
            this.dgSl.HeaderText = "SL";
            this.dgSl.MinimumWidth = 8;
            this.dgSl.Name = "dgSl";
            this.dgSl.Width = 150;
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.MinimumWidth = 8;
            this.dgName.Name = "dgName";
            this.dgName.Width = 150;
            // 
            // dgPhoneNo
            // 
            this.dgPhoneNo.HeaderText = "Phone No";
            this.dgPhoneNo.MinimumWidth = 8;
            this.dgPhoneNo.Name = "dgPhoneNo";
            this.dgPhoneNo.Width = 150;
            // 
            // dgNationality
            // 
            this.dgNationality.HeaderText = "Nationality";
            this.dgNationality.MinimumWidth = 8;
            this.dgNationality.Name = "dgNationality";
            this.dgNationality.Width = 150;
            // 
            // dgGender
            // 
            this.dgGender.HeaderText = "Gender";
            this.dgGender.MinimumWidth = 8;
            this.dgGender.Name = "dgGender";
            this.dgGender.Width = 150;
            // 
            // dgDoB
            // 
            this.dgDoB.HeaderText = "Date Of Birth";
            this.dgDoB.MinimumWidth = 8;
            this.dgDoB.Name = "dgDoB";
            this.dgDoB.Width = 150;
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.MinimumWidth = 8;
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.Width = 150;
            // 
            // dgCheckin
            // 
            this.dgCheckin.HeaderText = "Check In";
            this.dgCheckin.MinimumWidth = 8;
            this.dgCheckin.Name = "dgCheckin";
            this.dgCheckin.Width = 150;
            // 
            // dgCheckout
            // 
            this.dgCheckout.HeaderText = "Check Out";
            this.dgCheckout.MinimumWidth = 8;
            this.dgCheckout.Name = "dgCheckout";
            this.dgCheckout.Width = 150;
            // 
            // dgBed
            // 
            this.dgBed.HeaderText = "Bed";
            this.dgBed.MinimumWidth = 8;
            this.dgBed.Name = "dgBed";
            this.dgBed.Width = 150;
            // 
            // dgRoomtype
            // 
            this.dgRoomtype.HeaderText = "Roome Type";
            this.dgRoomtype.MinimumWidth = 8;
            this.dgRoomtype.Name = "dgRoomtype";
            this.dgRoomtype.Width = 150;
            // 
            // dgRoomno
            // 
            this.dgRoomno.HeaderText = "Room No";
            this.dgRoomno.MinimumWidth = 8;
            this.dgRoomno.Name = "dgRoomno";
            this.dgRoomno.Width = 150;
            // 
            // dgPrice
            // 
            this.dgPrice.HeaderText = "Price";
            this.dgPrice.MinimumWidth = 8;
            this.dgPrice.Name = "dgPrice";
            this.dgPrice.Width = 150;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BorderRadius = 22;
            this.btnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.Color.Cyan;
            this.btnUpdate.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(1005, 511);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(189, 46);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AutoRoundedCorners = true;
            this.btnAddRoom.BorderRadius = 22;
            this.btnAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAddRoom.BorderThickness = 1;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Location = new System.Drawing.Point(1005, 414);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(189, 46);
            this.btnAddRoom.TabIndex = 76;
            this.btnAddRoom.Text = "Registration";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.GridView2);
            this.Controls.Add(this.txtRoomno);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContact);
            this.Name = "UC_CustomerRegistration";
            this.Size = new System.Drawing.Size(1279, 799);
            this.Load += new System.EventHandler(this.UC_CustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckOut;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckIn;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDob;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomno;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox txtType;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GridView2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRoomno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrice;
    }
}
