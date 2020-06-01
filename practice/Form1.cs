using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count, equalsflag;

        public void disable()
        {
            textBox1.Enabled = false; // disable display
            button1.Show(); //ON button is displayed
            button2.Hide(); //Hide off button

            //disable all other buttons while off
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;

        }

        public void enable()
        {
            textBox1.Enabled = true; // enable display
            button1.Hide(); //ON button is displayed
            button2.Show(); //Hide off button

            //enable all other buttons while off
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //ON button
        {
            enable();
        }

        private void button5_Click(object sender, EventArgs e) //addition button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "0";
            textBox1.ForeColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "1";
            textBox1.ForeColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "2";
            textBox1.ForeColor = Color.Red;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "3";
            textBox1.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "4";
            textBox1.ForeColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "5";
            textBox1.ForeColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "6";
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "7";
            textBox1.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "8";
            textBox1.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (equalsflag == 1)
            {
                textBox1.Text = ""; //clear display
                equalsflag = 0;
            }
            textBox1.Text = textBox1.Text + "9";
            textBox1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e) //Off button
        {
            disable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; //clear display
        }

        private void button12_Click(object sender, EventArgs e) //subtraction button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button15_Click(object sender, EventArgs e) //multiplication buttono
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button18_Click(object sender, EventArgs e) //division button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button20_Click(object sender, EventArgs e) //equals button
        {
            compute();
            label1.Text = ""; //clear label
            equalsflag = 1;
        }

        private void button3_Click(object sender, EventArgs e) //backspace
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            
            for(int i=0; i<length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        public void compute()
        {
            switch(count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text); 
                    textBox1.Text = ans.ToString();  //converts float into string
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text); 
                    textBox1.Text = ans.ToString();  //converts float into string
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text); 
                    textBox1.Text = ans.ToString();  //converts float into string
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();  //converts float into string
                    break;
            }


        }
    }  
}
