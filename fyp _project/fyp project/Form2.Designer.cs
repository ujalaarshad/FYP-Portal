namespace fyp_project
{
    partial class frmstudentupdate
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
            this.btnupdate = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // txtregno
            // 
            this.txtregno.Location = new System.Drawing.Point(86, 200);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(100, 20);
            this.txtregno.TabIndex = 47;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(1, 200);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(73, 13);
            this.lblRegNo.TabIndex = 46;
            this.lblRegNo.Text = "Registration #";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(86, 127);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 45;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(111, 235);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 44;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(86, 156);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 20);
            this.txtgender.TabIndex = 43;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(86, 91);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 42;
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(86, 57);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(100, 20);
            this.txtcon.TabIndex = 41;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(86, 31);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(100, 20);
            this.txtlast.TabIndex = 40;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(86, 2);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 39;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(0, 163);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 38;
            this.lblgender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(0, 133);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 37;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(2, 98);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 36;
            this.lblemail.Text = "Email";
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(-2, 64);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(44, 13);
            this.lblcontact.TabIndex = 35;
            this.lblcontact.Text = "Contact";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(-2, 34);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(58, 13);
            this.lbllname.TabIndex = 34;
            this.lbllname.Text = "Last Name";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(0, 2);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(57, 13);
            this.lblfname.TabIndex = 33;
            this.lblfname.Text = "First Name";
            // 
            // frmstudentupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.txtregno);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.btnupdate);
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
            this.Name = "frmstudentupdate";
            this.Text = "Update student information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtregno;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Button btnupdate;
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
    }
}