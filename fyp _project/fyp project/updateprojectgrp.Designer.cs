namespace fyp_project
{
    partial class updateprojectgrp
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxprj = new System.Windows.Forms.ComboBox();
            this.comboBoxgrp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(74, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxprj
            // 
            this.comboBoxprj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxprj.FormattingEnabled = true;
            this.comboBoxprj.Location = new System.Drawing.Point(97, 48);
            this.comboBoxprj.Name = "comboBoxprj";
            this.comboBoxprj.Size = new System.Drawing.Size(121, 21);
            this.comboBoxprj.TabIndex = 59;
            // 
            // comboBoxgrp
            // 
            this.comboBoxgrp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxgrp.FormattingEnabled = true;
            this.comboBoxgrp.Location = new System.Drawing.Point(97, 86);
            this.comboBoxgrp.Name = "comboBoxgrp";
            this.comboBoxgrp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxgrp.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "AssingnmentDate";
            // 
            // lbllname
            // 
            this.lbllname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(12, 48);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(49, 13);
            this.lbllname.TabIndex = 56;
            this.lbllname.Text = "ProjectId";
            // 
            // lblfname
            // 
            this.lblfname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(12, 89);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(45, 13);
            this.lblfname.TabIndex = 55;
            this.lblfname.Text = "GroupId";
            // 
            // updateprojectgrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 296);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxprj);
            this.Controls.Add(this.comboBoxgrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Name = "updateprojectgrp";
            this.Text = "updateprojectgrp";
            this.Load += new System.EventHandler(this.updateprojectgrp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxprj;
        private System.Windows.Forms.ComboBox comboBoxgrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
    }
}