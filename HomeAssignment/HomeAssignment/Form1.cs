using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            String dayof_week, Name_of_the_Month, Numeric_Day, Year, Full_Date;

            //initial values of variable

            dayof_week=txtdayoftheweek.Text;
            Name_of_the_Month=txtdayofthemonth.Text;
            Numeric_Day = txtmonth.Text;
            Year = txtyear.Text;
            Full_Date = txtyear.Text;

            //stage 2 =process-concatination

            Full_Date = dayof_week + "," + Name_of_the_Month + "," + Numeric_Day + "," + Year + "," + Full_Date;

            //stage 3 the output using label

            lbloutput.Text = Full_Date;




        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing 
            txtdayoftheweek.Clear();
            txtdayofthemonth.Text ="";
            txtmonth.Clear();
            txtyear.Text=string.Empty;

            //clearing label

            lbloutput.Text = string.Empty;

            //lbloutput.Text
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // form close using this keyword  and close function 
           this.Close();
        }
    }
}
