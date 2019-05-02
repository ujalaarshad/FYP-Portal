namespace fyp_project
{
    partial class UpdateEvaluation
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
            this.txtnamep = new System.Windows.Forms.TextBox();
            this.txttotalwei = new System.Windows.Forms.TextBox();
            this.txttmarks = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Location = new System.Drawing.Point(115, 183);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 42;
            this.btnadd.Text = "Update";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtnamep
            // 
            this.txtnamep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnamep.Location = new System.Drawing.Point(140, 55);
            this.txtnamep.Name = "txtnamep";
            this.txtnamep.Size = new System.Drawing.Size(114, 20);
            this.txtnamep.TabIndex = 41;
            // 
            // txttotalwei
            // 
            this.txttotalwei.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalwei.Location = new System.Drawing.Point(140, 141);
            this.txttotalwei.Name = "txttotalwei";
            this.txttotalwei.Size = new System.Drawing.Size(114, 20);
            this.txttotalwei.TabIndex = 40;
            // 
            // txttmarks
            // 
            this.txttmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttmarks.Location = new System.Drawing.Point(140, 101);
            this.txttmarks.Name = "txttmarks";
            this.txttmarks.Size = new System.Drawing.Size(114, 20);
            this.txttmarks.TabIndex = 39;
            // 
            // lblcontact
            // 
            this.lblcontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(31, 58);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(35, 13);
            this.lblcontact.TabIndex = 38;
            this.lblcontact.Text = "Name";
            // 
            // lbllname
            // 
            this.lbllname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(31, 141);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(86, 13);
            this.lbllname.TabIndex = 37;
            this.lbllname.Text = "Total Weightage";
            // 
            // lblfname
            // 
            this.lblfname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(31, 104);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(63, 13);
            this.lblfname.TabIndex = 36;
            this.lblfname.Text = "Total Marks";
            // 
            // UpdateEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnamep);
            this.Controls.Add(this.txttotalwei);
            this.Controls.Add(this.txttmarks);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Name = "UpdateEvaluation";
            this.Text = "UpdateEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtnamep;
        private System.Windows.Forms.TextBox txttotalwei;
        private System.Windows.Forms.TextBox txttmarks;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
    }
}