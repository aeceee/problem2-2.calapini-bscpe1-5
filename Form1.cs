using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem2_2.calapini_bscpe1_5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < 50)
            {
                textBox2.Text = "It's free!";
            }

            else if (Convert.ToInt32(textBox1.Text) <= 60)
            {
                textBox2.Text = "20 cents";
            }

            else if (Convert.ToInt32(textBox1.Text) <= 70)
            {
                textBox2.Text = "25 cents";
            }

            else if (Convert.ToInt32(textBox1.Text) <= 80)
            {
                textBox2.Text = "30 cents";
            }

            else if (Convert.ToInt32(textBox1.Text) <= 85)
            {
                textBox2.Text = "40 cents";
            }

            else if (Convert.ToInt32(textBox1.Text) <= 90)
            {
                textBox2.Text = "50 cents";
            }

            else if (Convert.ToInt32(textBox1.Text) <= 95)
            {
                textBox2.Text = "55 cents";
            }

            else if (Convert.ToInt32(textBox1.Text) <= 100)
            {
                textBox2.Text = "65 cents";
            }

            else if (Convert.ToInt32(textBox1.Text) > 100)
            {
                textBox2.Text = "75 cents";
            }
        }
    }
}
