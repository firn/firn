using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TEXTCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void lostF()
        {
            jianpan.Focus();
        }

        private void jianpan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ss = e.KeyChar;
            switch (ss)
            {
                case '0': number0.PerformClick(); break;
                case '1': number1.PerformClick(); break;
                case '2': number2.PerformClick(); break;
                case '3': number3.PerformClick(); break;
                case '4': number4.PerformClick(); break;
                case '5': number5.PerformClick(); break;
                case '6': number6.PerformClick(); break;
                case '7': number7.PerformClick(); break;
                case '8': number8.PerformClick(); break;
                case '9': number9.PerformClick(); break;
                case '+': btnadd.PerformClick(); break;
                case '-': btnsub.PerformClick(); break;
                case '*': btnmul.PerformClick(); break;
                case '/': btndiv.PerformClick(); break;
                case '.': btnpoint.PerformClick(); break;
            }
            if(ss ==(char)8)
                backspace.PerformClick();
        }

        private void jianpan_Click(object sender, EventArgs e)
        {
            btnsum.PerformClick();
        }

        double[] operand =new double[3];
        bool isContinue = true;
        string[] calc = new string[2];
        int i = 0, j = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (isContinue && txtNowInput.Text != "0")
                {
                    txtNowInput.Text += btn.Text;
                }
                else
                {
                    isContinue = true;
                    txtNowInput.Text = btn.Text;
                }
            }
            lostF();
        }

        private void number0_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number1_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number2_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number3_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number4_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number5_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number6_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number7_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number8_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void number9_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (calc[j] == "÷" && txtNowInput.Text == "0")
                return;
            int numberx=0;
            for (int k = 0; k < txtNowInput.Text.Length; k++)
            {
                if (txtNowInput.Text[k] == '0' || txtNowInput.Text[k] == '.')
                    numberx++;
            }
            if (numberx == txtNowInput.Text.Length && txtNowInput.Text.Length>1)
                return;
            if (txtNowInput.Text[txtNowInput.Text.Length - 1] == '.')
                return;

            if (calc[j] == null)
            {
                txtAllInput.Text = "";
                txtAllInput.Text += txtNowInput.Text;
                txtAllInput.Text += "+";
                operand[i] = Convert.ToDouble(txtNowInput.Text);
                calc[j] = "+";
                txtNowInput.Text = "0";
                return;
            }
            txtAllInput.Text += txtNowInput.Text;
            txtAllInput.Text += "+";
            operand[i+1] = Convert.ToDouble(txtNowInput.Text);
            for (; j >= 0; j--, i--)
            {
                switch (calc[j])
                {
                    case "+":
                        operand[i] = operand[i] + operand[i + 1]; break;
                    case "-":
                        operand[i] = operand[i] - operand[i + 1]; break;
                    case "×":
                        operand[i] = operand[i] * operand[i + 1]; break;
                    case "÷":
                        operand[i] = operand[i] / operand[i + 1]; break;
                }
            }
            j++; i++;
            calc[j] = "+";
            txtNowInput.Text = "0";

            //how.Text = operand[0] + "," + operand[1];
            lostF();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (calc[j] == "÷" && txtNowInput.Text == "0")
                return;
            int numberx = 0;
            for (int k = 0; k < txtNowInput.Text.Length; k++)
            {
                if (txtNowInput.Text[k] == '0' || txtNowInput.Text[k] == '.')
                    numberx++;
            }
            if (numberx == txtNowInput.Text.Length && txtNowInput.Text.Length > 1)
                return;
            if (txtNowInput.Text[txtNowInput.Text.Length - 1] == '.')
                return;

            if (calc[j] == null)
            {
                txtAllInput.Text = "";
                txtAllInput.Text += txtNowInput.Text;
                txtAllInput.Text += "-";
                operand[i] = Convert.ToDouble(txtNowInput.Text);
                calc[j] = "-";
                txtNowInput.Text = "0";
                return;
            }
            txtAllInput.Text += txtNowInput.Text;
            txtAllInput.Text += "-";
            operand[i + 1] = Convert.ToDouble(txtNowInput.Text);
            for (; j >= 0; j--, i--)
            {
                switch (calc[j])
                {
                    case "+":
                        operand[i] = operand[i] + operand[i + 1]; break;
                    case "-":
                        operand[i] = operand[i] - operand[i + 1]; break;
                    case "×":
                        operand[i] = operand[i] * operand[i + 1]; break;
                    case "÷":
                        operand[i] = operand[i] / operand[i + 1]; break;
                }
            }
            j++; i++;
            calc[j] = "-";
            txtNowInput.Text = "0";

            //how.Text = operand[0] + "," + operand[1];
            lostF();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (calc[j] == "÷" && txtNowInput.Text == "0")
                return;
            int numberx = 0;
            for (int k = 0; k < txtNowInput.Text.Length; k++)
            {
                if (txtNowInput.Text[k] == '0' || txtNowInput.Text[k] == '.')
                    numberx++;
            }
            if (numberx == txtNowInput.Text.Length && txtNowInput.Text.Length > 1)
                return;
            if (txtNowInput.Text[txtNowInput.Text.Length - 1] == '.')
                return;

            if (calc[j] == null)
            {
                txtAllInput.Text = "";
                txtAllInput.Text += txtNowInput.Text;
                txtAllInput.Text += "×";
                operand[i] = Convert.ToDouble(txtNowInput.Text);
                calc[j] = "×";
                txtNowInput.Text = "0";
                return;
            }

            txtAllInput.Text += txtNowInput.Text;
            txtAllInput.Text += "×";
            operand[i + 1] = Convert.ToDouble(txtNowInput.Text);
            switch (calc[j])
            {
                case "+":
                    j++;i++; break;
                case "-":
                    j++;i++; break;
                case "×":
                    operand[i] = operand[i] * operand[i + 1]; break;
                case "÷":
                    operand[i] = operand[i] / operand[i + 1]; break;
            }
            calc[j] = "×";
            txtNowInput.Text = "0";

            //how.Text = operand[0] + "," + operand[1];
            lostF();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (calc[j] == "÷" && txtNowInput.Text == "0")
                return;
            int numberx = 0;
            for (int k = 0; k < txtNowInput.Text.Length; k++)
            {
                if (txtNowInput.Text[k] == '0' || txtNowInput.Text[k] == '.')
                    numberx++;
            }
            if (numberx == txtNowInput.Text.Length && txtNowInput.Text.Length > 1)
                return;
            if (txtNowInput.Text[txtNowInput.Text.Length - 1] == '.')
                return;

            if (calc[j] == null)
            {
                txtAllInput.Text = "";
                txtAllInput.Text += txtNowInput.Text;
                txtAllInput.Text += "÷";
                operand[i] = Convert.ToDouble(txtNowInput.Text);
                calc[j] = "÷";
                txtNowInput.Text = "0";
                return;
            }
            txtAllInput.Text += txtNowInput.Text;
            txtAllInput.Text += "÷";
            operand[i + 1] = Convert.ToDouble(txtNowInput.Text);
            switch (calc[j])
            {
                case "+":
                    j++; i++; break;
                case "-":
                    j++; i++; break;
                case "×":
                    operand[i] = operand[i] * operand[i + 1]; break;
                case "÷":
                    operand[i] = operand[i] / operand[i + 1]; break;
            }
            calc[j] = "÷";
            txtNowInput.Text = "0";

            //how.Text = operand[0] + "," + operand[1];
            lostF();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            if (calc[j] == "÷" && txtNowInput.Text == "0")
                return;
            int numberx = 0;
            for (int k = 0; k < txtNowInput.Text.Length; k++)
            {
                if (txtNowInput.Text[k] == '0' || txtNowInput.Text[k] == '.')
                    numberx++;
            }
            if (numberx == txtNowInput.Text.Length && txtNowInput.Text.Length > 1)
                return;
            if (txtNowInput.Text[txtNowInput.Text.Length - 1] == '.')
                return;

            txtAllInput.Text += txtNowInput.Text;
            txtAllInput.Text += "=";
            if (calc[j] == null)
            {
                return;
            }
            operand[i + 1] = Convert.ToDouble(txtNowInput.Text);
            for (; j >= 0; j--, i--)
            {
                switch (calc[j])
                {
                    case "+":
                        operand[i] = operand[i] + operand[i + 1]; break;
                    case "-":
                        operand[i] = operand[i] - operand[i + 1]; break;
                    case "×":
                        operand[i] = operand[i] * operand[i + 1]; break;
                    case "÷":
                        operand[i] = operand[i] / operand[i + 1]; break;
                }
            }
            txtNowInput.Text = operand[0]+"";
            calc[0] = null;
            i = j = 0;
            isContinue = false;
            //how.Text = operand[0] + "," + operand[1];
            lostF();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            txtNowInput.Text = txtNowInput.Text.Substring(0, txtNowInput.Text.Length - 1);
            if (txtNowInput.Text == "" || txtNowInput.Text == "-")
                txtNowInput.Text = "0";

            lostF();
        }

        private void cancal_Click(object sender, EventArgs e)
        {
            txtNowInput.Text = "0";
            txtAllInput.Clear();
            i = j = 0;
            calc[0] = null;

            lostF();
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            String kk = txtNowInput.Text;
            for (int i = 0; i < kk.Length; i++) 
            {
                if (kk[i] == '.')
                    return;
            }
            txtNowInput.Text += ".";
            isContinue = true;

            lostF();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            if (txtNowInput.Text[0] == '0')
                return;
            if (txtNowInput.Text[0] != '-')
            {
                txtNowInput.Text = "-" + txtNowInput.Text;
                return;
            }
            txtNowInput.Text = txtNowInput.Text.Replace("-", "");


            lostF();
        }

    }
}
