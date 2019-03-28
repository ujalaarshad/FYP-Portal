namespace fyp_project
{
    partial class ManageEvaluation
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
            this.txtnamep = new System.Windows.Forms.TextBox();
            this.txttotalwei = new System.Windows.Forms.TextBox();
            this.txttmarks = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridViewEVal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEVal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnamep
            // 
            this.txtnamep.Location = new System.Drawing.Point(136, 46);
            this.txtnamep.Name = "txtnamep";
            this.txtnamep.Size = new System.Drawing.Size(114, 20);
            this.txtnamep.TabIndex = 34;
            this.txtnamep.TextChanged += new System.EventHandler(this.txtnamep_TextChanged);
            // 
            // txttotalwei
            // 
            this.txttotalwei.Location = new System.Drawing.Point(136, 132);
            this.txttotalwei.Name = "txttotalwei";
            this.txttotalwei.Size = new System.Drawing.Size(114, 20);
            this.txttotalwei.TabIndex = 33;
            this.txttotalwei.TextChanged += new System.EventHandler(this.txttotalwei_TextChanged);
            // 
            // txttmarks
            // 
            this.txttmarks.Location = new System.Drawing.Point(136, 92);
            this.txttmarks.Name = "txttmarks";
            this.txttmarks.Size = new System.Drawing.Size(114, 20);
            this.txttmarks.TabIndex = 32;
            this.txttmarks.TextChanged += new System.EventHandler(this.txttmarks_TextChanged);
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(27, 49);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(35, 13);
            this.lblcontact.TabIndex = 30;
            this.lblcontact.Text = "Name";
            this.lblcontact.Click += new System.EventHandler(this.lblcontact_Click);
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(27, 132);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(86, 13);
            this.lbllname.TabIndex = 29;
            this.lbllname.Text = "Total Weightage";
            this.lbllname.Click += new System.EventHandler(this.lbllname_Click);
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(27, 95);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(63, 13);
            this.lblfname.TabIndex = 28;
            this.lblfname.Text = "Total Marks";
            this.lblfname.Click += new System.EventHandler(this.lblfname_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(111, 174);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 35;
            this.btnadd.Text = "Insert";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridViewEVal
            // 
            this.dataGridViewEVal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEVal.Location = new System.Drawing.Point(12, 214);
            this.dataGridViewEVal.Name = "dataGridViewEVal";
            this.dataGridViewEVal.Size = new System.Drawing.Size(443, 165);
            this.dataGridViewEVal.TabIndex = 36;
            this.dataGridViewEVal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEVal_CellClick);
            this.dataGridViewEVal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEVal_CellContentClick);
            // 
            // ManageEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 412);
            this.Controls.Add(this.dataGridViewEVal);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnamep);
            this.Controls.Add(this.txttotalwei);
            this.Controls.Add(this.txttmarks);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Name = "ManageEvaluation";
            this.Text = "ManageEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnamep;
        private System.Windows.Forms.TextBox txttotalwei;
        private System.Windows.Forms.TextBox txttmarks;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridViewEVal;
    }
}