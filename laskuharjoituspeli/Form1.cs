using System;
using System.Net.NetworkInformation;
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

        }

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

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";                /* value of number button*/
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
                                                   /* the player chooses difficulty level easy */
            int amount1 = 20;                    /* the number of places in the table */
            int[] values1 = new int[amount1];
            Random random1 = new Random();       /* let's draw the numbers in the table*/
            for (int i = 0; i < amount1; i++)
            {

                values1[i] = random.Next(1, 10);  /* the drawn numbers are added to the table*/

                if ((values1[0] < values1[1] || values1[2] < values1[3] || values1[4] < values1[5] || values1[6] < values1[7]
                    || values1[8] < values1[9] || values1[10] < values1[11] || values1[12] < values1[13] || values1[14] < values1[15]
                    || values1[16] < values1[17] || values1[18] < values1[19])) /* let's compare the values1 ​​so that every other number is smaller in the table,
                                                                                 * because in minus calculations the difference must not be negative. */
                {
                    i--;
                    { }                                           /* if the condition is not met, the machine draws the value 
                                                                       * according to the condition into the table and does not retrieve the number
                                                                   */
                }
                else

                    nmb1lbl.Text = (values1[0].ToString());          /* the drawn numbers are entered on invoices */
                nmb2lbl.Text = (values1[1].ToString());
                nmb3lbl.Text = (values1[2].ToString());
                nmb4lbl.Text = (values1[3].ToString());
                nmb5lbl.Text = (values1[4].ToString());
                nmb6lbl.Text = (values1[5].ToString());
                nmb7lbl.Text = (values1[6].ToString());
                nmb8lbl.Text = (values1[7].ToString());
                nmb9lbl.Text = (values1[8].ToString());
                nmb10lbl.Text = (values1[9].ToString());
                nmb11lbl.Text = (values1[10].ToString());
                nmb12lbl.Text = (values1[11].ToString());
                nmb13lbl.Text = (values1[12].ToString());
                nmb14lbl.Text = (values1[13].ToString());
                nmb15lbl.Text = (values1[14].ToString());
                nmb16lbl.Text = (values1[15].ToString());
                nmb17lbl.Text = (values1[16].ToString());
                nmb18lbl.Text = (values1[17].ToString());
                nmb19lbl.Text = (values1[18].ToString());
                nmb20lbl.Text = (values1[19].ToString());

                if (plusbtn.Visible)                /* if the plus option is selected the game will show the numbers and signs for plus counts */
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
                }
                else if (minusbtn.Visible)
                {                               /* if the minus option is selected, the game will display numbers and signs for minus counts*/
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
                }
                else
                {                               /* when player clicks plusminus button the game opens a plus and minus field for calculations  */
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
                }

                
                btn1.Visible = true;    /* number buttons open for counts */
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;
                btn5.Visible = true;
                btn6.Visible = true;
                btn7.Visible = true;
                btn8.Visible = true;
                btn9.Visible = true;
                btn0.Visible = true;
                hardbtn.Visible = false;
                startbtn.Visible = false;
                easybtn.Visible = false;

            }
            

        }
    
            private void hardbtn_Click(object sender, EventArgs e)
        {                                           /* the player chooses difficulty level hard */

            int amount2 = 20;                    /* the number of places in the table */
                int[] values2 = new int[amount2];
                Random random2 = new Random();       /* let's draw the numbers in the table*/
            for (int i = 0; i < amount2; i++)
            {

                values2[i] = random.Next(1, 20);  /* the drawn numbers are added to the table*/

                if ((values2[0] < values2[1] || values2[2] < values2[3] || values2[4] < values2[5] || values2[6] < values2[7]
                    || values2[8] < values2[9] || values2[10] < values2[11] || values2[12] < values2[13] || values2[14] < values2[15]
                    || values2[16] < values2[17] || values2[18] < values2[19])) /* let's compare the values ​​so that every other number is smaller in the table,
                                                                                 * because in minus calculations the difference must not be negative. */
                {
                    i--;
                    { }                                           /* if the condition is not met, the machine draws the value 
                                                                       * according to the condition into the table and does not retrieve the number
 */
                }
                else

                    nmb1lbl.Text = (values2[0].ToString());          /* the drawn numbers are entered on invoices */
                nmb2lbl.Text = (values2[1].ToString());
                nmb3lbl.Text = (values2[2].ToString());
                nmb4lbl.Text = (values2[3].ToString());
                nmb5lbl.Text = (values2[4].ToString());
                nmb6lbl.Text = (values2[5].ToString());
                nmb7lbl.Text = (values2[6].ToString());
                nmb8lbl.Text = (values2[7].ToString());
                nmb9lbl.Text = (values2[8].ToString());
                nmb10lbl.Text = (values2[9].ToString());
                nmb11lbl.Text = (values2[10].ToString());
                nmb12lbl.Text = (values2[11].ToString());
                nmb13lbl.Text = (values2[12].ToString());
                nmb14lbl.Text = (values2[13].ToString());
                nmb15lbl.Text = (values2[14].ToString());
                nmb16lbl.Text = (values2[15].ToString());
                nmb17lbl.Text = (values2[16].ToString());
                nmb18lbl.Text = (values2[17].ToString());
                nmb19lbl.Text = (values2[18].ToString());
                nmb20lbl.Text = (values2[19].ToString());

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
                }
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
            }
                }
            }
        }
    


