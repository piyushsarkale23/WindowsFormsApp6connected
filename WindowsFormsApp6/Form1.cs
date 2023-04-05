using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("idiot");
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if(txt1.Text =="1")
            {
                MessageBox.Show("good");
            }
            if (txt2.Text == "ooo")
            {
                MessageBox.Show("goodnnn");
            }
        }
    }
}
