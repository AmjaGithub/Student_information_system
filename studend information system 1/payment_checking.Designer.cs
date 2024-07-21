
namespace studend_information_system_1
{
    partial class payment_Checking
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
            this.labelspd = new System.Windows.Forms.Label();
            this.labelesin = new System.Windows.Forms.Label();
            this.textBoxesin = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelspd
            // 
            this.labelspd.BackColor = System.Drawing.Color.Tan;
            this.labelspd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelspd.ForeColor = System.Drawing.Color.Maroon;
            this.labelspd.Location = new System.Drawing.Point(109, 15);
            this.labelspd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelspd.Name = "labelspd";
            this.labelspd.Size = new System.Drawing.Size(376, 41);
            this.labelspd.TabIndex = 0;
            this.labelspd.Text = "Student Payment Deatails";
            this.labelspd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelspd.Click += new System.EventHandler(this.labelspd_Click);
            // 
            // labelesin
            // 
            this.labelesin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelesin.ForeColor = System.Drawing.Color.Maroon;
            this.labelesin.Location = new System.Drawing.Point(68, 93);
            this.labelesin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelesin.Name = "labelesin";
            this.labelesin.Size = new System.Drawing.Size(206, 46);
            this.labelesin.TabIndex = 1;
            this.labelesin.Text = "Enter Student Id Number";
            this.labelesin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxesin
            // 
            this.textBoxesin.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxesin.Location = new System.Drawing.Point(292, 98);
            this.textBoxesin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxesin.Multiline = true;
            this.textBoxesin.Name = "textBoxesin";
            this.textBoxesin.Size = new System.Drawing.Size(266, 41);
            this.textBoxesin.TabIndex = 2;
            // 
            // buttonok
            // 
            this.buttonok.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonok.ForeColor = System.Drawing.Color.Maroon;
            this.buttonok.Location = new System.Drawing.Point(220, 174);
            this.buttonok.Margin = new System.Windows.Forms.Padding(2);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(117, 41);
            this.buttonok.TabIndex = 3;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = false;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 171);
            this.dataGridView1.TabIndex = 4;
            // 
            // payment_Checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(600, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxesin);
            this.Controls.Add(this.labelesin);
            this.Controls.Add(this.labelspd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "payment_Checking";
            this.Text = "payment_Checking";
            this.Load += new System.EventHandler(this.payment_Checking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelspd;
        private System.Windows.Forms.Label labelesin;
        private System.Windows.Forms.TextBox textBoxesin;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}