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
        }
        int fnum = 0;
        int snum = 0;
        string op = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdisplay.Enabled= false;
            txtdisplay.Text = "";
            txtdisplay.BackColor = Color.White;
            txtdisplay.ForeColor = Color.Black;

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

    }
}
