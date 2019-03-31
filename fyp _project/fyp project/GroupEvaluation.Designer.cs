namespace fyp_project
{
    partial class GroupEvaluation
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
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxgrp = new System.Windows.Forms.ComboBox();
            this.comboBoxeval = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(104, 255);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 40;
            this.btnadd.Text = "Insert";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(31, 118);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(66, 13);
            this.lbllname.TabIndex = 37;
            this.lbllname.Text = "EvaluationId";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(31, 81);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(45, 13);
            this.lblfname.TabIndex = 36;
            this.lblfname.Text = "GroupId";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Obtained Marks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Evaluation Date";
            // 
            // comboBoxgrp
            // 
            this.comboBoxgrp.FormattingEnabled = true;
            this.comboBoxgrp.Location = new System.Drawing.Point(140, 78);
            this.comboBoxgrp.Name = "comboBoxgrp";
            this.comboBoxgrp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxgrp.TabIndex = 45;
            // 
            // comboBoxeval
            // 
            this.comboBoxeval.FormattingEnabled = true;
            this.comboBoxeval.Location = new System.Drawing.Point(140, 115);
            this.comboBoxeval.Name = "comboBoxeval";
            this.comboBoxeval.Size = new System.Drawing.Size(121, 21);
            this.comboBoxeval.TabIndex = 46;
            this.comboBoxeval.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxeval);
            this.Controls.Add(this.comboBoxgrp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Name = "GroupEvaluation";
            this.Text = "GroupEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxgrp;
        private System.Windows.Forms.ComboBox comboBoxeval;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}