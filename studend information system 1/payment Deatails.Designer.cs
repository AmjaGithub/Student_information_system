
namespace studend_information_system_1
{
    partial class payment_confirm
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
            this.labelpc = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelname = new System.Windows.Forms.Label();
            this.labelrn = new System.Windows.Forms.Label();
            this.labeltfp = new System.Windows.Forms.Label();
            this.labeldor = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxrn = new System.Windows.Forms.TextBox();
            this.textBoxtfp = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelpc
            // 
            this.labelpc.BackColor = System.Drawing.Color.Tan;
            this.labelpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpc.ForeColor = System.Drawing.Color.Maroon;
            this.labelpc.Location = new System.Drawing.Point(1, 0);
            this.labelpc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelpc.Name = "labelpc";
            this.labelpc.Size = new System.Drawing.Size(599, 58);
            this.labelpc.TabIndex = 0;
            this.labelpc.Text = "Payment Deatails";
            this.labelpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.29032F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.70968F));
            this.tableLayoutPanel1.Controls.Add(this.labelname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelrn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labeltfp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labeldor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxrn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxtfp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(68, 118);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 166);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelname
            // 
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.Maroon;
            this.labelname.Location = new System.Drawing.Point(2, 0);
            this.labelname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(187, 41);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "Student Id";
            this.labelname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelname.Click += new System.EventHandler(this.labelname_Click);
            // 
            // labelrn
            // 
            this.labelrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrn.ForeColor = System.Drawing.Color.Maroon;
            this.labelrn.Location = new System.Drawing.Point(2, 41);
            this.labelrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelrn.Name = "labelrn";
            this.labelrn.Size = new System.Drawing.Size(187, 41);
            this.labelrn.TabIndex = 0;
            this.labelrn.Text = "Recepit Number";
            this.labelrn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeltfp
            // 
            this.labeltfp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltfp.ForeColor = System.Drawing.Color.Maroon;
            this.labeltfp.Location = new System.Drawing.Point(2, 82);
            this.labeltfp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltfp.Name = "labeltfp";
            this.labeltfp.Size = new System.Drawing.Size(187, 41);
            this.labeltfp.TabIndex = 0;
            this.labeltfp.Text = "Tuition Fees Paid";
            this.labeltfp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeldor
            // 
            this.labeldor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldor.ForeColor = System.Drawing.Color.Maroon;
            this.labeldor.Location = new System.Drawing.Point(2, 123);
            this.labeldor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldor.Name = "labeldor";
            this.labeldor.Size = new System.Drawing.Size(187, 41);
            this.labeldor.TabIndex = 0;
            this.labeldor.Text = "Date Of Receipt";
            this.labeldor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(193, 2);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(270, 37);
            this.textBoxname.TabIndex = 1;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxrn
            // 
            this.textBoxrn.Location = new System.Drawing.Point(193, 43);
            this.textBoxrn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxrn.Multiline = true;
            this.textBoxrn.Name = "textBoxrn";
            this.textBoxrn.Size = new System.Drawing.Size(270, 37);
            this.textBoxrn.TabIndex = 1;
            this.textBoxrn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxtfp
            // 
            this.textBoxtfp.Location = new System.Drawing.Point(193, 84);
            this.textBoxtfp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtfp.Multiline = true;
            this.textBoxtfp.Name = "textBoxtfp";
            this.textBoxtfp.Size = new System.Drawing.Size(270, 37);
            this.textBoxtfp.TabIndex = 1;
            this.textBoxtfp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 29);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(380, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ".";
            // 
            // payment_confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelpc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "payment_confirm";
            this.Text = "payment_Deatails";
            this.Load += new System.EventHandler(this.payment_confirm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelrn;
        private System.Windows.Forms.Label labeltfp;
        private System.Windows.Forms.Label labeldor;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxrn;
        private System.Windows.Forms.TextBox textBoxtfp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}