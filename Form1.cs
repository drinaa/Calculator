using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float x = 0, res = 0f;
        char c;
        bool eq, zn=false;

        private void calc(float a)
        {
            switch (c)
            {
                case '+':
                    res += a;
                    textBox1.Text = res.ToString();
                    zn = true;
                    break;
                case '-':
                    res -= a;
                    textBox1.Text = res.ToString();
                    zn = true;
                    break;
                case '*':
                    res *= a;
                    textBox1.Text = res.ToString();
                    zn = true;
                    break;
                case '/':
                    res /= a;
                    textBox1.Text = res.ToString();
                    zn = true;
                    break;

                default:
                    break;
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true) { 
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 1;
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
                textBox1.Text = textBox1.Text + 2;
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 3;
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 4;
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 5;
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 6;
        }
        private void but7_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 7;
        }

        private void but8_Click(object sender, EventArgs e)
        {

            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 8;
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 9;
        }
        private void but0_Click(object sender, EventArgs e)
        {
            if (!(label1.Text.Contains("+")) && !(label1.Text.Contains("-")) && !(label1.Text.Contains("*")) && !(label1.Text.Contains("/")))
            {
                label1.Text = "";
            }
            if (zn == true)
            {
                textBox1.Clear();
                zn = false;
            }
            textBox1.Text = textBox1.Text + 0;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            zn = false;
            if ((label1.Text == "") | (eq == true))
            {
                if (textBox1.Text != "")
                {
                    x = float.Parse(textBox1.Text);
                    res = x;
                    c = '+';
                    textBox1.Clear();
                    label1.Text += x.ToString() + "+";
                    eq = false;
                }
            }
            else
            {
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
                calc(x);
                c = '+';
                label1.Text += x.ToString() + "+";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "") | (eq == true))
            {
                if (textBox1.Text != "")
                {
                    x = float.Parse(textBox1.Text);
                    res = x;
                    c = '-';
                    textBox1.Clear();
                    label1.Text += x.ToString() + "-";
                    eq = false;
                }
            }
            else
            {
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
                calc(x);
                c = '-';
                label1.Text += x.ToString() + "-";
            }
        }

        private void multip_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "") | (eq == true))
            {
                if (textBox1.Text != "")
                {
                    x = float.Parse(textBox1.Text);
                    res = x;
                    c = '*';
                    textBox1.Clear();
                    label1.Text += x.ToString() + "*";
                    eq = false;
                }
            }
            else
            {
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
                calc(x);
                c = '*';
                label1.Text += x.ToString() + "*";
            }
        }

        private void dev_Click(object sender, EventArgs e)
        {
            if ((label1.Text == "") | (eq == true))
            {
                if (textBox1.Text != "")
                {
                    x = float.Parse(textBox1.Text);
                    res = x;
                    c = '/';
                    textBox1.Clear();
                    label1.Text += x.ToString() + "/";
                    eq = false;
                }
            }
            else
            {
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
                calc(x);
                c = '/';
                label1.Text += x.ToString() + "/";
            }
         }



        

        private void equ_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                x = float.Parse(textBox1.Text);
                calc(x);
                label1.Text += x.ToString() + "=";
                textBox1.Text = res.ToString();
                eq = true;
                zn = false;
                Clipboard.SetText(res.ToString());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '+')
            {
                plus_Click(sender, e);
                textBox1.Clear();
            }
            if (e.KeyChar == '-')
            {
                minus_Click(sender, e);
                textBox1.Clear();
            }
            if (e.KeyChar == '*')
            {
                multip_Click(sender, e);
                textBox1.Clear();
            }
            if (e.KeyChar == '/')
            {
                dev_Click(sender, e);
                textBox1.Clear();
            }
            if (e.KeyChar == '=')
            {
                equ_Click(sender, e);
                
            }
            if ((e.KeyChar == ',')| (e.KeyChar == '.'))
            {
                if (textBox1.Text.IndexOf(',') == -1)
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but7_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            res = 0f;
        }














    }
}
