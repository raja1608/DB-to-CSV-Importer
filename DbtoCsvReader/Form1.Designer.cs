namespace DbtoCsvReader
{
    partial class Form1
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
            this.lblSqlQuery = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbllog1 = new System.Windows.Forms.Label();
            this.lbllog2 = new System.Windows.Forms.Label();
            this.lbllog3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRowsImported = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSqlQuery
            // 
            this.lblSqlQuery.AutoSize = true;
            this.lblSqlQuery.Location = new System.Drawing.Point(12, 49);
            this.lblSqlQuery.Name = "lblSqlQuery";
            this.lblSqlQuery.Size = new System.Drawing.Size(59, 13);
            this.lblSqlQuery.TabIndex = 0;
            this.lblSqlQuery.Text = "SQL Query";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(109, 46);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(471, 102);
            this.txtQuery.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(109, 172);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(97, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(287, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(483, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbllog1
            // 
            this.lbllog1.AutoSize = true;
            this.lbllog1.Location = new System.Drawing.Point(12, 270);
            this.lbllog1.Name = "lbllog1";
            this.lbllog1.Size = new System.Drawing.Size(0, 13);
            this.lbllog1.TabIndex = 5;
            // 
            // lbllog2
            // 
            this.lbllog2.AutoSize = true;
            this.lbllog2.Location = new System.Drawing.Point(12, 302);
            this.lbllog2.Name = "lbllog2";
            this.lbllog2.Size = new System.Drawing.Size(0, 13);
            this.lbllog2.TabIndex = 6;
            // 
            // lbllog3
            // 
            this.lbllog3.AutoSize = true;
            this.lbllog3.Location = new System.Drawing.Point(12, 332);
            this.lbllog3.Name = "lbllog3";
            this.lbllog3.Size = new System.Drawing.Size(0, 13);
            this.lbllog3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of Rows Imported:";
            // 
            // lblRowsImported
            // 
            this.lblRowsImported.AutoSize = true;
            this.lblRowsImported.Location = new System.Drawing.Point(151, 236);
            this.lblRowsImported.Name = "lblRowsImported";
            this.lblRowsImported.Size = new System.Drawing.Size(0, 13);
            this.lblRowsImported.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 376);
            this.Controls.Add(this.lblRowsImported);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllog3);
            this.Controls.Add(this.lbllog2);
            this.Controls.Add(this.lbllog1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblSqlQuery);
            this.Name = "Form1";
            this.Text = "DB to CSV Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSqlQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbllog1;
        private System.Windows.Forms.Label lbllog2;
        private System.Windows.Forms.Label lbllog3;
        private System.Windows.Forms.Label lblRowsImported;
        private System.Windows.Forms.Label label1;
    }
}

