using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("COMMENT");
        }
        double fnum = 0;
        double snum = 0;
        string op = "";
        
        void resetall()
        {
            txtdisplay.Text = "";
            op = "";
            fnum = 0;
            snum = 0;
            radDEGREE.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtdisplay.Enabled= false;
            txtdisplay.Text = "";
            txtdisplay.BackColor = Color.White;
            txtdisplay.ForeColor = Color.Black;
            radDEGREE.Checked = true;

        }
        void enabler()
        {
            btnplus.Enabled= true;
            btnminus.Enabled = true;
            btntimes.Enabled = true;
            btndivide.Enabled = true;
        }
        void disabler()
        {
            btnplus.Enabled = false;
            btnminus.Enabled = false;
            btntimes.Enabled = false;
            btndivide.Enabled = false;
        }
        void dis(string x)
        {
            txtdisplay.AppendText(x);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dis("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dis("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dis("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dis("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dis("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dis("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dis("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dis("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dis("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dis("0");
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
           fnum= double.Parse(txtdisplay.Text);
            op = "+";
            txtdisplay.Text = "";
            disabler();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            fnum = double.Parse(txtdisplay.Text);
            op = "-";
            txtdisplay.Text = "";
            disabler();
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            fnum = double.Parse(txtdisplay.Text);
            op = "*";
            txtdisplay.Text = "";
            disabler();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            fnum = double.Parse(txtdisplay.Text);
            op = "/";
            txtdisplay.Text = "";
            disabler();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                snum= double.Parse(txtdisplay.Text);
                double x = fnum + snum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            if (op == "-")
            {
                snum = double.Parse(txtdisplay.Text);
                double x = fnum - snum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            if (op == "*")
            {
                snum = double.Parse(txtdisplay.Text);
                double x = fnum * snum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            if (op == "/")
            {
                snum = double.Parse(txtdisplay.Text);
                double x = fnum / snum;
                txtdisplay.Text = "";
                txtdisplay.AppendText(x.ToString());
            }
            enabler();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetall();
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            double mysin;
            mysin=double.Parse(txtdisplay.Text);
            double ans;
            ans = (mysin * (Math.PI)) / 180;
            txtdisplay.Text = "";
            double finalans = Math.Sin(ans);
            txtdisplay.AppendText(finalans.ToString());
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            double mysin;
            mysin = double.Parse(txtdisplay.Text);
            double ans;
            ans = (mysin * (Math.PI)) / 180;
            txtdisplay.Text = "";
            double finalans = Math.Cos(ans);
            txtdisplay.AppendText(finalans.ToString());
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            double mysin;
            mysin = double.Parse(txtdisplay.Text);
            double ans;
            ans = (mysin * (Math.PI)) / 180;
            txtdisplay.Text = "";
            double finalans = Math.Tan(ans);
            txtdisplay.AppendText(finalans.ToString());
        }

        private void btncsc_Click(object sender, EventArgs e)
        {
            double mysin;
            mysin = double.Parse(txtdisplay.Text);
            double ans;
            ans = (mysin * (Math.PI)) / 180;
            txtdisplay.Text = "";
            double finalans = Math.Sinh(ans);
            txtdisplay.AppendText(finalans.ToString());
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            double mysin;
            mysin = double.Parse(txtdisplay.Text);
            double ans;
            ans = (mysin * (Math.PI)) / 180;
            txtdisplay.Text = "";
            double finalans = Math.Cosh(ans);
            txtdisplay.AppendText(finalans.ToString());
        }

        private void btncot_Click(object sender, EventArgs e)
        {
            double mysin;
            mysin = double.Parse(txtdisplay.Text);
            double ans;
            ans = (mysin * (Math.PI)) / 180;
            txtdisplay.Text = "";
            double finalans = Math.Tanh(ans);
            txtdisplay.AppendText(finalans.ToString());
        }
    }
}
