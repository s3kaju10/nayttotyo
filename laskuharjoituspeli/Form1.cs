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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laskuharjoituspeli
{
    public partial class Laskuharjoituspeli : Form
    {
        Form2 form2 = new Form2();
        DateTime currentDate = DateTime.Now;



        public Laskuharjoituspeli()
        {


            InitializeComponent();
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Check if a specific date is today
            DateTime dateToCheck = new DateTime(2023, 1, 1);
            bool isToday = dateToCheck.Date == currentDate.Date;

            // Get the data to send
            string dataToSend = currentDate.ToShortDateString();

            // Open Form2 and set the TextBox value
            
            form2.ReceivedData = dataToSend;
            form2.Show();

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
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            playerresult1.Visible = false;
            playerresult2.Visible = false;
            playerresult3.Visible = false;
            replay.Visible = false;
            checkbtn.Visible = false;
            close.Visible = true;



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

        int pnumbers1;
        int pnumbers2;
        int pnumbers3;
        int pnumbers4;
        int pnumbers5;
        int pnumbers6;
        int pnumbers7;
        int pnumbers8;
        int pnumbers9;
        int pnumbers10;

        int ringhta = 0;    /* if player gives right answer "ringht! + 1 under the checkbtn"*/



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
        {                                                       /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "2";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "2";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "2";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "2";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "2";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "2";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "2";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "2";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "2";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "2";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "2";

                }

            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "3";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "3";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "3";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "3";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "3";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "3";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "3";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "3";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "3";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "3";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "3";

                }

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {                                 /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "4";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "4";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "4";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "4";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "4";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "4";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "4";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "4";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "4";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "4";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "4";

                }

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {                                    /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "5";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "5";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "5";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "5";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "5";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "5";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "5";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "5";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "5";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "5";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "5";

                }

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {                                       /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "6";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "6";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "6";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "6";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "6";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "6";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "6";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "6";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "6";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "6";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "6";

                }

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {                                           /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "7";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "7";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "7";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "7";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "7";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "7";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "7";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "7";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "7";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "7";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "7";

                }

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {                                               /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "8";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "8";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "8";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "8";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "8";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "8";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "8";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "8";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "8";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "8";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "8";

                }

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {                                               /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "9";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "9";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "9";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "9";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "9";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "9";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "9";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "9";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "9";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "9";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "9";

                }

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {                                                /* value of number button*/
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "0";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "0";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "0";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "0";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "0";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "0";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "0";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "0";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "0";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "0";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "0";

                }

            }
        }

        private void easybtn_Click(object sender, EventArgs e)
        {

            string choose = "easy";                 /* the player chooses difficulty level easy */


            for (int j = 0; j < amount; j++)
            {
                values[j] = random.Next(1, 7);

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
                    if (result1 >= 10)
                    {
                        textBox1.MaxLength = 2;

                    }
                    else if (result1 < 10)
                    {
                        textBox1.MaxLength = 1;
                    }
                    if (result2 >= 10)
                    {
                        textBox2.MaxLength = 2;
                    }
                    else if (result2 < 10)
                    {
                        textBox2.MaxLength = 1;
                    }
                    if (result3 >= 10)
                    {
                        textBox3.MaxLength = 2;
                    }
                    else if (result3 < 10)
                    {
                        textBox3.MaxLength = 1;
                    }
                    if (result4 >= 10)
                    {
                        textBox4.MaxLength = 2;
                    }
                    else if (result4 < 10)
                    {
                        textBox4.MaxLength = 1;
                    }
                    if (result5 >= 10)
                    {
                        textBox5.MaxLength = 2;
                    }
                    else if (result5 < 10)
                    {
                        textBox5.MaxLength = 1;
                    }
                    if (result6 >= 10)
                    {
                        textBox6.MaxLength = 2;
                    }
                    else if (result6 < 10)
                    {
                        textBox6.MaxLength = 1;
                    }
                    if (result7 >= 10)
                    {
                        textBox7.MaxLength = 2;
                    }
                    else if (result7 < 10)
                    {
                        textBox7.MaxLength = 1;
                    }
                    if (result8 >= 10)
                    {
                        textBox8.MaxLength = 2;
                    }
                    else if (result8 < 10)
                    {
                        textBox8.MaxLength = 1;
                    }
                    if (result9 >= 10)
                    {
                        textBox9.MaxLength = 2;
                    }
                    else if (result9 < 10)
                    {
                        textBox9.MaxLength = 1;
                    }
                    if (result10 >= 10)
                    {
                        textBox10.MaxLength = 2;
                    }
                    else if (result10 < 10)
                    {
                        textBox10.MaxLength = 1;
                    }


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

        private void hardbtn_Click(object sender, EventArgs e)
        {                                          /* the player chooses difficulty level hard */
            string choose = "hard";

            for (int i = 0; i < amount; i++)
            {
                values[i] = random.Next(5, 12);


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

                    if (result1 >= 10)
                    {
                        textBox1.MaxLength = 2;

                    }
                    else if (result1 < 10)
                    {
                        textBox1.MaxLength = 1;
                    }
                    if (result2 >= 10)
                    {
                        textBox2.MaxLength = 2;
                    }
                    else if (result2 < 10)
                    {
                        textBox2.MaxLength = 1;
                    }
                    if (result3 >= 10)
                    {
                        textBox3.MaxLength = 2;
                    }
                    else if (result3 < 10)
                    {
                        textBox3.MaxLength = 1;
                    }
                    if (result4 >= 10)
                    {
                        textBox4.MaxLength = 2;
                    }
                    else if (result4 < 10)
                    {
                        textBox4.MaxLength = 1;
                    }
                    if (result5 >= 10)
                    {
                        textBox5.MaxLength = 2;
                    }
                    else if (result5 < 10)
                    {
                        textBox5.MaxLength = 1;
                    }
                    if (result6 >= 10)
                    {
                        textBox6.MaxLength = 2;
                    }
                    else if (result6 < 10)
                    {
                        textBox6.MaxLength = 1;
                    }
                    if (result7 >= 10)
                    {
                        textBox7.MaxLength = 2;
                    }
                    else if (result7 < 10)
                    {
                        textBox7.MaxLength = 1;
                    }
                    if (result8 >= 10)
                    {
                        textBox8.MaxLength = 2;
                    }
                    else if (result8 < 10)
                    {
                        textBox8.MaxLength = 1;
                    }
                    if (result9 >= 10)
                    {
                        textBox9.MaxLength = 2;
                    }
                    else if (result9 < 10)
                    {
                        textBox9.MaxLength = 1;
                    }
                    if (result10 >= 10)
                    {
                        textBox10.MaxLength = 2;
                    }
                    else if (result10 < 10)
                    {
                        textBox10.MaxLength = 1;
                    }




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

        private void checkbtn_Click(object sender, EventArgs e)
        {


            if (plusbtn.Visible == true || plusminusbtn.Visible == true)
            {
                pnumbers1 = int.Parse(textBox1.Text);                    // if the plus button is visible, the program enters the numbers given by the player
                pnumbers2 = int.Parse(textBox2.Text);
                pnumbers3 = int.Parse(textBox3.Text);
                pnumbers4 = int.Parse(textBox4.Text);
                pnumbers5 = int.Parse(textBox5.Text);

                if (result1 == pnumbers1)                      /* the program checks whether the numbers given by the player are correct.
                                                                if the result is correct the text box turns green and if wrong the text box turns red.
                                                                  ohjelma laskee oikeiden vastausten luku määrää muuttuujaan ringhta*/
                {
                    textBox1.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result1 != pnumbers1)
                {
                    textBox1.BackColor = Color.Red;
                }
                if (result2 == pnumbers2)
                {
                    textBox2.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result2 != pnumbers2)
                {
                    textBox2.BackColor = Color.Red;
                }
                if (result3 == pnumbers3)
                {
                    textBox3.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result3 != pnumbers3)
                {
                    textBox3.BackColor = Color.Red;
                }
                if (result4 == pnumbers4)
                {
                    textBox4.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result4 != pnumbers4)
                {
                    textBox4.BackColor = Color.Red;
                }
                if (result5 == pnumbers5)
                {
                    textBox5.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result5 != pnumbers5)
                {
                    textBox5.BackColor = Color.Red;
                }
                if (plusbtn.Visible == true && ringhta >= 4)        /*when the program has calculated how many answers the player
                                                                    * has calculated correctly, the program finally gives feedback to the player. */
                {
                    pictureBox1.Visible = true;
                    playerresult1.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/5".ToString();    
                    playerresult1.Visible = true;
                }
                if (plusbtn.Visible == true && ringhta < 4 && ringhta >= 2)
                {
                    pictureBox2.Visible = true;
                    playerresult2.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/5".ToString();
                    playerresult2.Visible = true;
                }
                if (plusbtn.Visible == true && ringhta < 2)
                {
                    pictureBox3.Visible = true;
                    playerresult3.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/5".ToString();
                    playerresult3.Visible = true;
                }
            }
            if (minusbtn.Visible == true || plusminusbtn.Visible == true && plusbtn.Visible == false)
            {
                pnumbers6 = int.Parse(textBox6.Text);
                pnumbers7 = int.Parse(textBox7.Text);
                pnumbers8 = int.Parse(textBox8.Text);
                pnumbers9 = int.Parse(textBox9.Text);
                pnumbers10 = int.Parse(textBox10.Text);


                if (result6 == pnumbers6)
                {
                    textBox6.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result6 != pnumbers6)
                {
                    textBox6.BackColor = Color.Red;
                }
                if (result7 == pnumbers7)
                {
                    textBox7.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result7 != pnumbers7)
                {
                    textBox7.BackColor = Color.Red;
                }
                if (result8 == pnumbers8)
                {
                    textBox8.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result8 != pnumbers8)
                {
                    textBox8.BackColor = Color.Red;
                }
                if (result9 == pnumbers9)
                {
                    textBox9.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result9 != pnumbers9)
                {
                    textBox9.BackColor = Color.Red;
                }
                if (result10 == pnumbers10)
                {
                    textBox10.BackColor = Color.Green;
                    ringhta++;
                }
                else if (result10 != pnumbers10)
                {
                    textBox10.BackColor = Color.Red;
                }
                if (minusbtn.Visible == true && ringhta >= 4)
                {
                    pictureBox1.Visible = true;
                    playerresult1.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/5".ToString();
                    playerresult1.Visible = true;
                }
                if (minusbtn.Visible == true && ringhta < 4 && ringhta >= 2)
                {
                    pictureBox2.Visible = true;
                    playerresult2.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/5".ToString();
                    playerresult2.Visible = true;
                }
                if (minusbtn.Visible == true && ringhta < 2)
                {
                    pictureBox3.Visible = true;
                    playerresult3.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/5".ToString();
                    playerresult3.Visible = true;
                }
                if (plusminusbtn.Visible == true && ringhta >= 7)
                {
                    pictureBox1.Visible = true;
                    playerresult1.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/10".ToString();
                    playerresult1.Visible = true;
                }
                if (plusminusbtn.Visible == true && ringhta < 7 && ringhta >= 4)
                {
                    pictureBox2.Visible = true;
                    playerresult2.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/10".ToString();
                    playerresult2.Visible = true;
                }
                if (plusminusbtn.Visible == true && ringhta < 4)
                {
                    pictureBox3.Visible = true;
                    playerresult3.Text = "vastasit oikein ".ToString() + ringhta.ToString() + "/10".ToString();
                    playerresult3.Visible = true;
                }
               

            }
            
            string dataToSend = ringhta.ToString() ;            
            form2.ReceivedData =  dataToSend;
            form2.Show();
            replay.Visible = true;
            plusbtn.Visible = false;
            minusbtn.Visible = false;
            plusminusbtn.Visible = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == textBox1.MaxLength)
            {
                textBox2.Focus();

            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (plusbtn.Visible == true || plusminusbtn.Visible == true || minusbtn.Visible == true)
            {
                if (minusbtn.Visible == true && textBox6.TextLength < result6.ToString().Length)
                {
                    textBox6.Text += "1";
                }

                else if (minusbtn.Visible == false && textBox1.TextLength < result1.ToString().Length)
                {
                    textBox1.Text += "1";
                }

                else if (minusbtn.Visible == false && textBox2.TextLength < result2.ToString().Length)
                {
                    textBox2.Text += "1";

                }
                else if (minusbtn.Visible == false && textBox3.TextLength < result3.ToString().Length)
                {
                    textBox3.Text += "1";

                }
                else if (minusbtn.Visible == false && textBox4.TextLength < result4.ToString().Length)
                {
                    textBox4.Text += "1";

                }
                else if (minusbtn.Visible == false && textBox5.TextLength < result5.ToString().Length)
                {
                    textBox5.Text += "1";

                }
                else if (textBox6.Text == "")
                {
                    textBox6.Text += "1";
                }

                else if (textBox6.TextLength >= result6.ToString().Length && textBox7.TextLength < result7.ToString().Length || plusminusbtn.Visible == true && textBox5.Text != "" && textBox7.TextLength < result7.ToString().Length)
                {
                    textBox7.Text += "1";

                }
                else if (minusbtn.Visible == true && textBox8.TextLength < result8.ToString().Length || plusminusbtn.Visible == true && textBox7.Text != "" && textBox8.TextLength < result8.ToString().Length)
                {
                    textBox8.Text += "1";

                }
                else if (minusbtn.Visible == true && textBox9.TextLength < result9.ToString().Length || plusminusbtn.Visible == true && textBox8.Text != "" && textBox9.TextLength < result9.ToString().Length)
                {
                    textBox9.Text += "1";

                }
                else if (minusbtn.Visible == true && textBox10.TextLength < result10.ToString().Length || plusminusbtn.Visible == true && textBox9.Text != "" && textBox10.TextLength < result10.ToString().Length)
                {
                    textBox10.Text += "1";

                }

            }
        }









        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text.Length == textBox2.MaxLength)
            {
                textBox3.Focus();
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == textBox3.MaxLength)
            {
                textBox4.Focus();
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == textBox4.MaxLength)
            {
                textBox5.Focus();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (plusbtn.Visible == true && textBox5.TextLength == result5.ToString().Length)
            {
                checkbtn.Visible = true;
            }
            if (minusbtn.Visible == true && textBox5.TextLength == result5.ToString().Length)
            {
                checkbtn.Visible = true;
            }
            if (textBox5.Text.Length == textBox5.MaxLength)
            {
                textBox6.Focus();
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == textBox6.MaxLength)
            {
                textBox7.Focus();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == textBox7.MaxLength)
            {
                textBox8.Focus();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == textBox8.MaxLength)
            {
                textBox9.Focus();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == textBox9.MaxLength)
            {
                textBox10.Focus();
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            if (plusminusbtn.Visible == true || minusbtn.Visible == true && textBox10.TextLength == result10.ToString().Length)
            {
                checkbtn.Visible = true;
            }
        }

        private void replay_Click(object sender, EventArgs e)
        {
                                                                    /* Replay button hides the buttons and the number lbl and the result boxes and changes 
                                                                     * the color of the result boxes to normal and finally the for loop clears the tables*/
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
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            playerresult1.Visible = false;
            playerresult2.Visible = false;
            playerresult3.Visible = false;
            plusbtn.Visible = true;
            minusbtn.Visible = true;
            plusminusbtn.Visible = true;
            textBox1.Text= "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox1.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            textBox3.BackColor = SystemColors.Control;
            textBox4.BackColor = SystemColors.Control;
            textBox5.BackColor = SystemColors.Control;
            textBox6.BackColor = SystemColors.Control;
            textBox7.BackColor = SystemColors.Control;
            textBox8.BackColor = SystemColors.Control;
            textBox9.BackColor = SystemColors.Control;
            textBox10.BackColor = SystemColors.Control;
            checkbtn.BackColor = SystemColors.Control;
            ringhta = 0;
            replay.Visible = false;
            checkbtn.Visible = false;

            for (int j = 0; j < amount; j++)
            {
                values[j] = 0;                          // the table is cleared

            }


                }

        private void close_Click(object sender, EventArgs e)
        {
            /* jatka tästä*/
            string path = "\\tulostallennus\\" + "txt" ;
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(currentDate.ToString());
            /* tämän yläpuolella ei toimi*/


            form2.ReceivedData += "vastasit oikein".ToString();
            form2.ReceivedData += currentDate.ToString();

            string ReadText = File.ReadAllText("testi22.txt");  // Read the contents of the file
            
            Console.WriteLine(form2.ReceivedData);  // Output the content
            

            string writeText = form2.ReceivedData.ToString();  // Create a text string
            File.WriteAllText("testi22.txt", writeText);  // Create a file and write the content of writeText to it
            Close();
        }
    }
}



























