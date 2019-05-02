namespace fyp_project
{
    partial class AddAdvisor
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
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.lbldesig = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.comboBoxsal = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(168, 357);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 49;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(168, 304);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(114, 20);
            this.txtsal.TabIndex = 46;
            // 
            // lbldesig
            // 
            this.lbldesig.AutoSize = true;
            this.lbldesig.Location = new System.Drawing.Point(80, 259);
            this.lbldesig.Name = "lbldesig";
            this.lbldesig.Size = new System.Drawing.Size(63, 13);
            this.lbldesig.TabIndex = 45;
            this.lbldesig.Text = "Designation";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(80, 311);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(36, 13);
            this.lblsalary.TabIndex = 43;
            this.lblsalary.Text = "Salary";
            // 
            // comboBoxsal
            // 
            this.comboBoxsal.FormattingEnabled = true;
            this.comboBoxsal.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.comboBoxsal.Location = new System.Drawing.Point(168, 259);
            this.comboBoxsal.Name = "comboBoxsal";
            this.comboBoxsal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxsal.TabIndex = 50;
            this.comboBoxsal.SelectedIndexChanged += new System.EventHandler(this.comboBoxsal_SelectedIndexChanged);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(168, 181);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 62;
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(168, 210);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 20);
            this.txtgender.TabIndex = 61;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Location = new System.Drawing.Point(168, 145);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(75, 20);
            this.txtemail.TabIndex = 60;
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(168, 111);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(100, 20);
            this.txtcon.TabIndex = 59;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(168, 85);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(100, 20);
            this.txtlast.TabIndex = 58;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(168, 56);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 57;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(82, 217);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 56;
            this.lblgender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(82, 187);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 55;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(84, 152);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 54;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(80, 118);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(44, 13);
            this.lblcontact.TabIndex = 53;
            this.lblcontact.Text = "Contact";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(80, 88);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(58, 13);
            this.lbllname.TabIndex = 52;
            this.lbllname.Text = "Last Name";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(82, 56);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(57, 13);
            this.lblfname.TabIndex = 51;
            this.lblfname.Text = "First Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtlast);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.comboBoxsal);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.lbldesig);
            this.Controls.Add(this.lblsalary);
            this.Name = "AddAdvisor";
            this.Text = "AddAdvisor";
            this.Load += new System.EventHandler(this.AddAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.Label lbldesig;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.ComboBox comboBoxsal;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}