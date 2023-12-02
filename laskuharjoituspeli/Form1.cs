using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laskuharjoituspeli
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();









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
            easybtn.Visible = false;
            hardbtn.Visible = false;




        }
        static int amount = 20;
        int[] values = new int[amount];
        Random random = new Random();
        int result1;
        int result2;
        int result3;
        int result4;
        int result5;
        int result6;
        int result7;
        int result8;
        int result9;
        int result10;



        private void startbtn_Click(object sender, EventArgs e)
        {                                   /* game start*/
            plusbtn.Visible = true;
            minusbtn.Visible = true;
            plusminusbtn.Visible = true;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            /* the player chooses plus option and
            The numbers and plus signs are displayed*/
            minusbtn.Visible = false;
            plusminusbtn.Visible = false;
            easybtn.Visible = true;
            hardbtn.Visible = true;
            startbtn.Visible = false;





        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            /* the player chooses minus option and
           The numbers and minus signs are displayed*/
            hardbtn.Visible = true;
            easybtn.Visible = true;
            plusbtn.Visible = false;
            plusminusbtn.Visible = false;
            startbtn.Visible = false;
        }

        private void plusminusbtn_Click(object sender, EventArgs e)
        {                                   /* the player chooses plus and minus option*/
            /* The numbers and plus signs are displayed*/
            hardbtn.Visible = true;
            easybtn.Visible = true;
            plusbtn.Visible = false;
            minusbtn.Visible = false;
            startbtn.Visible = false;

        }


        private void btn2_Click(object sender, EventArgs e)
        {

            textBox1.Text += "2";               /* value of number button*/
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";               /* value of number button*/
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";               /* value of number button*/
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";               /* value of number button*/
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";               /* value of number button*/
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";               /* value of number button*/
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";               /* value of number button*/
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";               /* value of number button*/
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";               /* value of number button*/
        }

        private void easybtn_Click(object sender, EventArgs e)
        {

            string choose = "easy";                 /* the player chooses difficulty level easy */


            for (int j = 0; j < amount; j++)
            {
                values[j] = random.Next(1, 10);

                if ((values[0] < values[1] || values[2] < values[3] || values[4] < values[5] || values[6] < values[7]
                || values[8] < values[9] || values[10] < values[11] || values[12] < values[13] || values[14] < values[15]
                || values[16] < values[17] || values[18] < values[19])) /* let's compare the values ​​so that every other number is smaller in the table,
                                                                                 * because in minus calculations the difference must not be negative. */
                {
                    j--;
                    { }
                }
                else
                {
                    nmb1lbl.Text = (values[0].ToString());
                    nmb2lbl.Text = (values[1].ToString());
                    nmb3lbl.Text = (values[2].ToString());
                    nmb4lbl.Text = (values[3].ToString());
                    nmb5lbl.Text = (values[4].ToString());
                    nmb6lbl.Text = (values[5].ToString());
                    nmb7lbl.Text = (values[6].ToString());
                    nmb8lbl.Text = (values[7].ToString());
                    nmb9lbl.Text = (values[8].ToString());
                    nmb10lbl.Text = (values[9].ToString());
                    nmb11lbl.Text = (values[10].ToString());
                    nmb12lbl.Text = (values[11].ToString());
                    nmb13lbl.Text = (values[12].ToString());
                    nmb14lbl.Text = (values[13].ToString());
                    nmb15lbl.Text = (values[14].ToString());
                    nmb16lbl.Text = (values[15].ToString());
                    nmb17lbl.Text = (values[16].ToString());
                    nmb18lbl.Text = (values[17].ToString());
                    nmb19lbl.Text = (values[18].ToString());
                    nmb20lbl.Text = (values[19].ToString());

                    result1 = values[0] + values[1];
                    result2 = values[2] + values[3];
                    result3 = values[4] + values[5];
                    result4 = values[6] + values[7];
                    result5 = values[8] + values[9];
                    result6 = values[10] - values[11];
                    result7 = values[12] - values[13];
                    result8 = values[14] - values[15];
                    result9 = values[16] - values[17];
                    result10 = values[18] - values[19];
                }

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
                easybtn.Visible = false;
                hardbtn.Visible = false;
                startbtn.Visible = false;



                if (plusbtn.Visible)                    /* if the plus option is selected the game will show the numbers and signs for plus counts */
                {
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
                    checkbtn.Visible = true;

                }
                else if (minusbtn.Visible)                      /* if the minus option is selected, the game will display numbers and signs for minus counts*/
                {
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
                    ilbl6.Visible = true;
                    ilbl7.Visible = true;
                    ilbl8.Visible = true;
                    ilbl9.Visible = true;
                    ilbl10.Visible = true;
                    minus1lbl.Visible = true;
                    minus2lbl.Visible = true;
                    minus3lbl.Visible = true;
                    minus4lbl.Visible = true;
                    minus5lbl.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    checkbtn.Visible = true;
                }
                else
                {
                    /* when player clicks plusminus button the game opens a plus and minus field for calculations  */
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
                    ilbl6.Visible = true;
                    ilbl7.Visible = true;
                    ilbl8.Visible = true;
                    ilbl9.Visible = true;
                    ilbl10.Visible = true;
                    minus1lbl.Visible = true;
                    minus2lbl.Visible = true;
                    minus3lbl.Visible = true;
                    minus4lbl.Visible = true;
                    minus5lbl.Visible = true;
                    checkbtn.Visible = true;
                }

            }

        }

        private void hardbtn_Click(object sender, EventArgs e)
        {                                          /* the player chooses difficulty level hard */
            string choose = "hard";

            for (int i = 0; i < amount; i++)
            {
                values[i] = random.Next(1, 20);


                if ((values[0] < values[1] || values[2] < values[3] || values[4] < values[5] || values[6] < values[7]
                || values[8] < values[9] || values[10] < values[11] || values[12] < values[13] || values[14] < values[15]
                || values[16] < values[17] || values[18] < values[19])) /* let's compare the values ​​so that every other number is smaller in the table,
                                                                                 * because in minus calculations the difference must not be negative. */
                {
                    i--;
                    { }
                }
                else
                {

                    nmb1lbl.Text = (values[0].ToString());          /* the drawn numbers are entered on invoices */
                    nmb2lbl.Text = (values[1].ToString());
                    nmb3lbl.Text = (values[2].ToString());
                    nmb4lbl.Text = (values[3].ToString());
                    nmb5lbl.Text = (values[4].ToString());
                    nmb6lbl.Text = (values[5].ToString());
                    nmb7lbl.Text = (values[6].ToString());
                    nmb8lbl.Text = (values[7].ToString());
                    nmb9lbl.Text = (values[8].ToString());
                    nmb10lbl.Text = (values[9].ToString());
                    nmb11lbl.Text = (values[10].ToString());
                    nmb12lbl.Text = (values[11].ToString());
                    nmb13lbl.Text = (values[12].ToString());
                    nmb14lbl.Text = (values[13].ToString());
                    nmb15lbl.Text = (values[14].ToString());
                    nmb16lbl.Text = (values[15].ToString());
                    nmb17lbl.Text = (values[16].ToString());
                    nmb18lbl.Text = (values[17].ToString());
                    nmb19lbl.Text = (values[18].ToString());
                    nmb20lbl.Text = (values[19].ToString());


                    result1 = values[0] + values[1];
                    result2 = values[2] + values[3];
                    result3 = values[4] + values[5];
                    result4 = values[6] + values[7];
                    result5 = values[8] + values[9];
                    result6 = values[10] - values[11];
                    result7 = values[12] - values[13];
                    result8 = values[14] - values[15];
                    result9 = values[16] - values[17];
                    result10 = values[18] - values[19];






                }
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
                easybtn.Visible = false;
                hardbtn.Visible = false;
                startbtn.Visible = false;



                if (plusbtn.Visible)                    /* if the plus option is selected the game will show the numbers and signs for plus counts */
                {
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
                    checkbtn.Visible = true;

                }
                else if (minusbtn.Visible)                      /* if the minus option is selected, the game will display numbers and signs for minus counts*/
                {
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
                    ilbl6.Visible = true;
                    ilbl7.Visible = true;
                    ilbl8.Visible = true;
                    ilbl9.Visible = true;
                    ilbl10.Visible = true;
                    minus1lbl.Visible = true;
                    minus2lbl.Visible = true;
                    minus3lbl.Visible = true;
                    minus4lbl.Visible = true;
                    minus5lbl.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                    checkbtn.Visible = true;
                }
                else
                {
                    /* when player clicks plusminus button the game opens a plus and minus field for calculations  */
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
                    ilbl6.Visible = true;
                    ilbl7.Visible = true;
                    ilbl8.Visible = true;
                    ilbl9.Visible = true;
                    ilbl10.Visible = true;
                    minus1lbl.Visible = true;
                    minus2lbl.Visible = true;
                    minus3lbl.Visible = true;
                    minus4lbl.Visible = true;
                    minus5lbl.Visible = true;
                    checkbtn.Visible = true;
                }


            }

        }

        private void checkbtn_Click(object sender, EventArgs e)
        {



            int pnumbers1 = int.Parse(textBox1.Text);
            int pnumbers2 = int.Parse(textBox2.Text);
            int pnumbers3 = int.Parse(textBox3.Text);
            int pnumbers4 = int.Parse(textBox4.Text);
            int pnumbers5 = int.Parse(textBox5.Text);
            int pnumbers6 = int.Parse(textBox6.Text);
            int pnumbers7 = int.Parse(textBox7.Text);
            int pnumbers8 = int.Parse(textBox8.Text);
            int pnumbers9 = int.Parse(textBox9.Text);
            int pnumbers10 = int.Parse(textBox10.Text);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 2;

            textBox1.Focus();

            if (result1 < 10 && textBox1.TextLength == 1 || result1 >= 10 && textBox1.TextLength == 2)
            {
                textBox2.Focus();


            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 2;

            textBox2.Focus();

            if (result2 < 10 && textBox2.TextLength == 1 || result2 >= 10 && textBox2.TextLength == 2)
            {

                textBox3.Focus();

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 2;

            textBox3.Focus();
            if (textBox3.TextLength == 1 && result3 < 10 || textBox3.TextLength == 2 && result3 >= 10)
            {
                textBox4.Focus();

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.MaxLength = 2;

            textBox4.Focus();
            if (textBox4.TextLength == 1 && result4 < 10 || textBox4.TextLength == 2 && result4 >= 10)
            {
                textBox5.Focus();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 2;

            textBox5.Focus();
            if (textBox5.TextLength == 1 && result5 < 10 || textBox5.TextLength == 2 && result5 >= 10)
            {
                textBox6.Focus();

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 2;

            textBox6.Focus();
            if (textBox6.TextLength == 1 && result6 < 10 || textBox6.TextLength == 2 && result6 >= 10)
            {
                textBox7.Focus();

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.MaxLength = 2;

            textBox7.Focus();
            if (textBox7.TextLength == 1 && result7 < 10 || textBox7.TextLength == 2 && result7 >= 10)
            {
                textBox8.Focus();

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 2;

            textBox8.Focus();
            if (textBox8.TextLength == 1 && result8 < 10 || textBox8.TextLength == 2 && result8 >= 10)
            {
                textBox9.Focus();

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.MaxLength = 2;

            textBox9.Focus();
            if (textBox9.TextLength == 1 && result9 < 10 || textBox9.TextLength == 2 && result9 >= 10)
            {
                textBox10.Focus();

            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.MaxLength = 2;

            textBox10.Focus();

        }
    }
}



























