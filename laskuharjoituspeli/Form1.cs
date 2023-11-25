using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laskuharjoituspeli
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            {
                int lukujenmaara = 20;
                int[] luvut = new int[lukujenmaara];
                Random random = new Random();
                for (int i = 0; i < lukujenmaara; i++)
                {

                    luvut[i] = random.Next(1, 20);

                    if ((luvut[0] < luvut[1] || luvut[2] < luvut[3] || luvut[4] < luvut[5] || luvut[6] < luvut[7]
                        || luvut[8] < luvut[9] || luvut[10] < luvut[11] || luvut[12] < luvut[13] || luvut[14] < luvut[15]
                        || luvut[16] < luvut[17] || luvut[18] < luvut[19]))
                    {
                        i--;
                        { }
                    }
                    else

                    nmb1lbl.Text = (luvut[0].ToString());
                    nmb2lbl.Text = (luvut[1].ToString());
                    nmb3lbl.Text = (luvut[2].ToString());
                    nmb4lbl.Text = (luvut[3].ToString());
                    nmb5lbl.Text = (luvut[4].ToString());
                    nmb6lbl.Text = (luvut[5].ToString());
                    nmb7lbl.Text = (luvut[6].ToString());
                    nmb8lbl.Text = (luvut[7].ToString());
                    nmb9lbl.Text = (luvut[8].ToString());
                    nmb10lbl.Text = (luvut[9].ToString());
                    nmb11lbl.Text = (luvut[10].ToString());
                    nmb12lbl.Text = (luvut[11].ToString());
                    nmb13lbl.Text = (luvut[12].ToString());
                    nmb14lbl.Text = (luvut[13].ToString());
                    nmb15lbl.Text = (luvut[14].ToString());
                    nmb16lbl.Text = (luvut[15].ToString());
                    nmb17lbl.Text = (luvut[16].ToString());
                    nmb18lbl.Text = (luvut[17].ToString());
                    nmb19lbl.Text = (luvut[18].ToString());
                    nmb20lbl.Text = (luvut[19].ToString());


                }
                /* numbers , plus and minus sings are hidden*/

                nmb1lbl.Visible = false;
                nmb2lbl.Visible = false;
                nmb3lbl.Visible = false;
                nmb4lbl.Visible = false;
                nmb5lbl.Visible = false;
                nmb6lbl.Visible = false;
                nmb7lbl.Visible = false;
                nmb8lbl.Visible = false;
                nmb9lbl.Visible = false;
                nmb10lbl.Visible = false;
                nmb11lbl.Visible = false;
                nmb12lbl.Visible = false;
                nmb13lbl.Visible = false;
                nmb14lbl.Visible = false;
                nmb15lbl.Visible = false;
                nmb16lbl.Visible = false;
                nmb17lbl.Visible = false;
                nmb18lbl.Visible = false;
                nmb19lbl.Visible = false;
                nmb20lbl.Visible = false;
                plus1lbl.Visible = false;
                plus2lbl.Visible = false;
                plus3lbl.Visible = false;
                plus4lbl.Visible = false;
                plus5lbl.Visible = false;
                minus1lbl.Visible = false;
                minus2lbl.Visible = false;
                minus3lbl.Visible = false;
                minus4lbl.Visible = false;
                minus5lbl.Visible = false;
                ilbl1.Visible = false;
                ilbl2.Visible = false;
                ilbl3.Visible = false;
                ilbl4.Visible = false;
                ilbl5.Visible = false;
                ilbl6.Visible = false;
                ilbl7.Visible = false;
                ilbl8.Visible = false;
                ilbl9.Visible = false;
                ilbl10.Visible = false;
                plusbtn.Visible = false;
                minusbtn.Visible = false;
                plusminusbtn.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                checkbtn.Visible = false;
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
                btn6.Visible = false;
                btn7.Visible = false;
                btn8.Visible = false;
                btn9.Visible = false;
                btn0.Visible = false;  


            }

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            plusbtn.Visible = true;
            minusbtn.Visible = true;
            plusminusbtn.Visible = true;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            /* The numbers and plus signs are displayed*/
            nmb1lbl.Visible = true; 
            nmb2lbl.Visible = true;
            nmb3lbl.Visible = true;
            nmb4lbl.Visible = true;
            nmb5lbl.Visible = true;
            nmb6lbl.Visible = true;
            nmb7lbl.Visible = true;
            nmb8lbl.Visible = true;
            nmb9lbl.Visible = true;
            nmb10lbl.Visible = true;
            plus1lbl.Visible = true; 
            plus2lbl.Visible = true;
            plus3lbl.Visible = true;
            plus4lbl.Visible = true;
            plus5lbl.Visible = true;
            ilbl1.Visible = true;
            ilbl2.Visible = true;
            ilbl3.Visible = true;
            ilbl4.Visible = true;
            ilbl5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;
            btn0.Visible = true;
            minusbtn.Visible = false;
            plusminusbtn.Visible = false;
            }
            

        

        private void minusbtn_Click(object sender, EventArgs e)
        {
            /* The numbers and minus signs are displayed*/
            nmb11lbl.Visible = true;
            nmb12lbl.Visible = true;
            nmb13lbl.Visible = true;
            nmb14lbl.Visible = true;
            nmb15lbl.Visible = true;
            nmb16lbl.Visible = true;
            nmb17lbl.Visible = true;
            nmb18lbl.Visible = true;
            nmb19lbl.Visible = true;
            nmb20lbl.Visible = true;
            minus1lbl.Visible = true;
            minus2lbl.Visible = true;
            minus3lbl.Visible = true;
            minus4lbl.Visible = true;
            minus5lbl.Visible = true;
            ilbl6.Visible = true;
            ilbl7.Visible = true;
            ilbl8.Visible = true;
            ilbl9.Visible = true;
            ilbl10.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            plusbtn.Visible = false;
            plusbtn.Visible = false;
            plusminusbtn.Visible = false;
        }

        private void plusminusbtn_Click(object sender, EventArgs e)
        {
            /* The numbers and plus signs are displayed*/
            nmb1lbl.Visible = true;
            nmb2lbl.Visible = true;
            nmb3lbl.Visible = true;
            nmb4lbl.Visible = true;
            nmb5lbl.Visible = true;
            nmb6lbl.Visible = true;
            nmb7lbl.Visible = true;
            nmb8lbl.Visible = true;
            nmb9lbl.Visible = true;
            nmb10lbl.Visible = true;
            nmb11lbl.Visible = true;
            nmb12lbl.Visible = true;
            nmb13lbl.Visible = true;
            nmb14lbl.Visible = true;
            nmb15lbl.Visible = true;
            nmb16lbl.Visible = true;
            nmb17lbl.Visible = true;
            nmb18lbl.Visible = true;
            nmb19lbl.Visible = true;
            nmb20lbl.Visible = true;
            plus1lbl.Visible = true;
            plus2lbl.Visible = true;
            plus3lbl.Visible = true;
            plus4lbl.Visible = true;
            plus5lbl.Visible = true;
            minus1lbl.Visible = true;
            minus2lbl.Visible = true;
            minus3lbl.Visible = true;
            minus4lbl.Visible = true;
            minus5lbl.Visible = true;
            ilbl1.Visible = true;
            ilbl2.Visible = true;
            ilbl3.Visible = true;
            ilbl4.Visible = true;
            ilbl5.Visible = true;
            ilbl6.Visible = true;
            ilbl7.Visible = true;
            ilbl8.Visible = true;
            ilbl9.Visible = true;
            ilbl10.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            plusbtn.Visible = false;
            minusbtn.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

    }
    }

