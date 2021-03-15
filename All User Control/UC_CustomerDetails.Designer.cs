
namespace Last_Project.All_User_Control
{
    partial class UC_CustomerDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sGridView = new System.Windows.Forms.DataGridView();
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
            this.dgFeedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Customer Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Search By";
            // 
            // sGridView
            // 
            this.sGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgPrice,
            this.dgFeedback});
            this.sGridView.Location = new System.Drawing.Point(21, 224);
            this.sGridView.Name = "sGridView";
            this.sGridView.RowHeadersWidth = 62;
            this.sGridView.RowTemplate.Height = 28;
            this.sGridView.Size = new System.Drawing.Size(1242, 430);
            this.sGridView.TabIndex = 76;
            this.sGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sGridView_CellContentClick);
            // 
            // dgSl
            // 
            this.dgSl.HeaderText = "SL";
            this.dgSl.MinimumWidth = 8;
            this.dgSl.Name = "dgSl";
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.MinimumWidth = 8;
            this.dgName.Name = "dgName";
            // 
            // dgPhoneNo
            // 
            this.dgPhoneNo.HeaderText = "Phone No";
            this.dgPhoneNo.MinimumWidth = 8;
            this.dgPhoneNo.Name = "dgPhoneNo";
            // 
            // dgNationality
            // 
            this.dgNationality.HeaderText = "Nationality";
            this.dgNationality.MinimumWidth = 8;
            this.dgNationality.Name = "dgNationality";
            // 
            // dgGender
            // 
            this.dgGender.HeaderText = "Gender";
            this.dgGender.MinimumWidth = 8;
            this.dgGender.Name = "dgGender";
            // 
            // dgDoB
            // 
            this.dgDoB.HeaderText = "Date Of Birth";
            this.dgDoB.MinimumWidth = 8;
            this.dgDoB.Name = "dgDoB";
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.MinimumWidth = 8;
            this.dgAddress.Name = "dgAddress";
            // 
            // dgCheckin
            // 
            this.dgCheckin.HeaderText = "Check In";
            this.dgCheckin.MinimumWidth = 8;
            this.dgCheckin.Name = "dgCheckin";
            // 
            // dgCheckout
            // 
            this.dgCheckout.HeaderText = "Check Out";
            this.dgCheckout.MinimumWidth = 8;
            this.dgCheckout.Name = "dgCheckout";
            // 
            // dgBed
            // 
            this.dgBed.HeaderText = "Bed";
            this.dgBed.MinimumWidth = 8;
            this.dgBed.Name = "dgBed";
            // 
            // dgRoomtype
            // 
            this.dgRoomtype.HeaderText = "Roome Type";
            this.dgRoomtype.MinimumWidth = 8;
            this.dgRoomtype.Name = "dgRoomtype";
            // 
            // dgRoomno
            // 
            this.dgRoomno.HeaderText = "Room No";
            this.dgRoomno.MinimumWidth = 8;
            this.dgRoomno.Name = "dgRoomno";
            // 
            // dgPrice
            // 
            this.dgPrice.HeaderText = "Price";
            this.dgPrice.MinimumWidth = 8;
            this.dgPrice.Name = "dgPrice";
            // 
            // dgFeedback
            // 
            this.dgFeedback.HeaderText = "Customer Feedback";
            this.dgFeedback.MinimumWidth = 8;
            this.dgFeedback.Name = "dgFeedback";
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
            this.txtName.Location = new System.Drawing.Point(552, 111);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Full Name";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(353, 47);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 78;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // UC_CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.sGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_CustomerDetails";
            this.Size = new System.Drawing.Size(1279, 799);
            ((System.ComponentModel.ISupportInitialize)(this.sGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView sGridView;
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
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFeedback;
    }
}
