namespace fyp_project
{
    partial class Addproject
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
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(140, 126);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 42;
            this.btnadd.Text = "Insert";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(140, 37);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(114, 20);
            this.txtdesc.TabIndex = 41;
            this.txtdesc.TextChanged += new System.EventHandler(this.txtdesc_TextChanged);
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(140, 83);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(114, 20);
            this.txttitle.TabIndex = 39;
            this.txttitle.TextChanged += new System.EventHandler(this.txttitle_TextChanged);
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(31, 40);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(60, 13);
            this.lblcontact.TabIndex = 38;
            this.lblcontact.Text = "Description";
            this.lblcontact.Click += new System.EventHandler(this.lblcontact_Click);
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(31, 86);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(27, 13);
            this.lblfname.TabIndex = 36;
            this.lblfname.Text = "Title";
            this.lblfname.Click += new System.EventHandler(this.lblfname_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(333, 150);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Addproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lblfname);
            this.Name = "Addproject";
            this.Text = "Addproject";
            this.Load += new System.EventHandler(this.Addproject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}