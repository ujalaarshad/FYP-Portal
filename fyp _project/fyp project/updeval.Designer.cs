namespace fyp_project
{
    partial class updeval
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
            this.comboBoxeval = new System.Windows.Forms.ComboBox();
            this.comboBoxgrp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 56;
            // 
            // comboBoxeval
            // 
            this.comboBoxeval.FormattingEnabled = true;
            this.comboBoxeval.Location = new System.Drawing.Point(132, 65);
            this.comboBoxeval.Name = "comboBoxeval";
            this.comboBoxeval.Size = new System.Drawing.Size(121, 21);
            this.comboBoxeval.TabIndex = 55;
            // 
            // comboBoxgrp
            // 
            this.comboBoxgrp.FormattingEnabled = true;
            this.comboBoxgrp.Location = new System.Drawing.Point(132, 28);
            this.comboBoxgrp.Name = "comboBoxgrp";
            this.comboBoxgrp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxgrp.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Evaluation Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Obtained Marks";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(96, 205);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 50;
            this.btnadd.Text = "Update";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(23, 68);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(66, 13);
            this.lbllname.TabIndex = 49;
            this.lbllname.Text = "EvaluationId";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(23, 31);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(45, 13);
            this.lblfname.TabIndex = 48;
            this.lblfname.Text = "GroupId";
            // 
            // updeval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 261);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxeval);
            this.Controls.Add(this.comboBoxgrp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Name = "updeval";
            this.Text = "updeval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxeval;
        private System.Windows.Forms.ComboBox comboBoxgrp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
    }
}