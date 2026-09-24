using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSemester_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int StudentID= int.Parse (txtstudentid.Text);
            String StudentDept = txtdepartment.Text;
            String studentSemester = txtSemester.Text;

            string displaylbl = name + " " + StudentID + " " + StudentDept + " " + studentSemester;
            lbloutput.Text = displaylbl;



                }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Text = "";
            txtSemester.Text = string.Empty;

            lbloutput.Text = string.Empty;
        }
    }
}
