using System;

namespace modul03_103022300121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] value =  new int[2];
        private string pertama;
        private string kedua = "-1";
        private string ketiga = "-1";

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = pertama + "1";
                label1.Text = label1.Text + "1";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "2";
                label1.Text = label1.Text + "2";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "3";
                label1.Text = label1.Text + "3";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "4";
                label1.Text = label1.Text + "4";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "5";
                label1.Text = label1.Text + "5";
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "6";
                label1.Text = label1.Text + "6";
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "7";
                label1.Text = label1.Text + "7";
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "8";
                label1.Text = label1.Text + "8";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "9";
                label1.Text = label1.Text + "9";
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (kedua == "-1" || ketiga == "-1" ||  pertama == "0")
            {
                pertama = "0";
                label1.Text = label1.Text + "0";
            }
            
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (ketiga == "-1")
            {
                ketiga = pertama;
                pertama = "0";
                label1.Text = label1.Text + "+";
            }else if(kedua == "-1")
            {
                kedua = pertama;
                pertama = "0";
                label1.Text = label1.Text + "+";
            }
            

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (kedua != "-1" || ketiga != "-1")
            {
                int hasil = Convert.ToInt32(pertama) + Convert.ToInt32(kedua) + Convert.ToInt32(ketiga);
                label1.Text = label1.Text + "=" + Convert.ToString(hasil);
            }
            
        }
    }
}
