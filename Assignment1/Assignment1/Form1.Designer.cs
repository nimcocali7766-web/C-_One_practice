namespace Assignment1
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
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lbstudentid = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(45, 49);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(209, 34);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // lbldepartment
            // 
            this.lbldepartment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(45, 156);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(224, 26);
            this.lbldepartment.TabIndex = 4;
            this.lbldepartment.Text = "Enter the department";
            // 
            // lbstudentid
            // 
            this.lbstudentid.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstudentid.Location = new System.Drawing.Point(45, 106);
            this.lbstudentid.Name = "lbstudentid";
            this.lbstudentid.Size = new System.Drawing.Size(224, 26);
            this.lbstudentid.TabIndex = 5;
            this.lbstudentid.Text = "Enter The Student ID";
            // 
            // lblSemester
            // 
            this.lblSemester.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(45, 210);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(224, 26);
            this.lblSemester.TabIndex = 6;
            this.lblSemester.Text = "Enter the Semester";
            this.lblSemester.Click += new System.EventHandler(this.lblSemester_Click);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(243, 47);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(274, 36);
            this.txtname.TabIndex = 7;
            this.txtname.Text = "naima";
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnshowinfo.Location = new System.Drawing.Point(49, 373);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(203, 53);
            this.btnshowinfo.TabIndex = 12;
            this.btnshowinfo.Text = "Show Information";
            this.btnshowinfo.UseVisualStyleBackColor = false;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // txtstudentid
            // 
            this.txtstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentid.Location = new System.Drawing.Point(243, 104);
            this.txtstudentid.Multiline = true;
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(274, 36);
            this.txtstudentid.TabIndex = 13;
            // 
            // txtSemester
            // 
            this.txtSemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSemester.Location = new System.Drawing.Point(243, 208);
            this.txtSemester.Multiline = true;
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(274, 36);
            this.txtSemester.TabIndex = 14;
            // 
            // txtdepartment
            // 
            this.txtdepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdepartment.Location = new System.Drawing.Point(243, 154);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(274, 36);
            this.txtdepartment.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(302, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(49, 266);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(485, 73);
            this.lbloutput.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lbstudentid);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lbstudentid;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbloutput;
    }
}

