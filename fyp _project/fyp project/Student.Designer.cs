namespace fyp_project
{
    partial class Student
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
            this.txtregno = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.btninsert = new System.Windows.Forms.Button();
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
            // txtregno
            // 
            this.txtregno.Location = new System.Drawing.Point(97, 200);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(100, 20);
            this.txtregno.TabIndex = 32;
            this.txtregno.TextChanged += new System.EventHandler(this.txtregno_TextChanged);
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(12, 200);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(73, 13);
            this.lblRegNo.TabIndex = 31;
            this.lblRegNo.Text = "Registration #";
            this.lblRegNo.Click += new System.EventHandler(this.lblRegNo_Click);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(97, 127);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 30;
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePickerDOB_ValueChanged);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(122, 235);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 29;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(97, 156);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 20);
            this.txtgender.TabIndex = 28;
            this.txtgender.TextChanged += new System.EventHandler(this.txtgender_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(97, 91);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 27;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(97, 57);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(100, 20);
            this.txtcon.TabIndex = 26;
            this.txtcon.TextChanged += new System.EventHandler(this.txtcon_TextChanged);
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(97, 31);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(100, 20);
            this.txtlast.TabIndex = 25;
            this.txtlast.TextChanged += new System.EventHandler(this.txtlast_TextChanged);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(97, 2);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 24;
            this.txtfname.TextChanged += new System.EventHandler(this.txtfname_TextChanged);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(11, 163);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 23;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.lblgender_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(11, 133);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.Click += new System.EventHandler(this.lblDOB_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(13, 98);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 21;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.lblemail_Click);
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(9, 64);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(44, 13);
            this.lblcontact.TabIndex = 20;
            this.lblcontact.Text = "Contact";
            this.lblcontact.Click += new System.EventHandler(this.lblcontact_Click);
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(9, 34);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(58, 13);
            this.lbllname.TabIndex = 19;
            this.lbllname.Text = "Last Name";
            this.lbllname.Click += new System.EventHandler(this.lbllname_Click);
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(11, 2);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(57, 13);
            this.lblfname.TabIndex = 18;
            this.lblfname.Text = "First Name";
            this.lblfname.Click += new System.EventHandler(this.lblfname_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtregno);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.btninsert);
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
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtregno;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Button btninsert;
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