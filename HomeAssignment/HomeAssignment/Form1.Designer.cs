namespace HomeAssignment
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
            this.lbldayoftheweek = new System.Windows.Forms.Label();
            this.lbldayofthemonth = new System.Windows.Forms.Label();
            this.lblnumericofthemonth = new System.Windows.Forms.Label();
            this.lbltheyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldayoftheweek
            // 
            this.lbldayoftheweek.AutoSize = true;
            this.lbldayoftheweek.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayoftheweek.Location = new System.Drawing.Point(124, 48);
            this.lbldayoftheweek.Name = "lbldayoftheweek";
            this.lbldayoftheweek.Size = new System.Drawing.Size(243, 26);
            this.lbldayoftheweek.TabIndex = 0;
            this.lbldayoftheweek.Text = "Enter day of the week:";
            // 
            // lbldayofthemonth
            // 
            this.lbldayofthemonth.AutoSize = true;
            this.lbldayofthemonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayofthemonth.Location = new System.Drawing.Point(97, 98);
            this.lbldayofthemonth.Name = "lbldayofthemonth";
            this.lbldayofthemonth.Size = new System.Drawing.Size(282, 26);
            this.lbldayofthemonth.TabIndex = 1;
            this.lbldayofthemonth.Text = "Enter Name of the Month:";
            // 
            // lblnumericofthemonth
            // 
            this.lblnumericofthemonth.AutoSize = true;
            this.lblnumericofthemonth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumericofthemonth.Location = new System.Drawing.Point(12, 145);
            this.lblnumericofthemonth.Name = "lblnumericofthemonth";
            this.lblnumericofthemonth.Size = new System.Drawing.Size(364, 26);
            this.lblnumericofthemonth.TabIndex = 2;
            this.lblnumericofthemonth.Text = "Enter the Numeric Of The Month:";
            // 
            // lbltheyear
            // 
            this.lbltheyear.AutoSize = true;
            this.lbltheyear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltheyear.Location = new System.Drawing.Point(205, 191);
            this.lbltheyear.Name = "lbltheyear";
            this.lbltheyear.Size = new System.Drawing.Size(177, 26);
            this.lbltheyear.TabIndex = 3;
            this.lbltheyear.Text = "Enter The Year:";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(12, 250);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(773, 69);
            this.lbloutput.TabIndex = 4;
            this.lbloutput.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.Location = new System.Drawing.Point(397, 47);
            this.txtdayoftheweek.Multiline = true;
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(259, 35);
            this.txtdayoftheweek.TabIndex = 5;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(397, 192);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(259, 35);
            this.txtyear.TabIndex = 7;
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(397, 146);
            this.txtmonth.Multiline = true;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(259, 35);
            this.txtmonth.TabIndex = 8;
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(397, 99);
            this.txtdayofthemonth.Multiline = true;
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(259, 35);
            this.txtdayofthemonth.TabIndex = 9;
            // 
            // btnshowdate
            // 
            this.btnshowdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(12, 336);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(186, 79);
            this.btnshowdate.TabIndex = 11;
            this.btnshowdate.Text = "Show Date";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(250, 336);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(186, 79);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(470, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 79);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lbltheyear);
            this.Controls.Add(this.lblnumericofthemonth);
            this.Controls.Add(this.lbldayofthemonth);
            this.Controls.Add(this.lbldayoftheweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayoftheweek;
        private System.Windows.Forms.Label lbldayofthemonth;
        private System.Windows.Forms.Label lblnumericofthemonth;
        private System.Windows.Forms.Label lbltheyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnClose;
    }
}

