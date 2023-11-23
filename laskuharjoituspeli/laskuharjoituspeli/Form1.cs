using System;
using System.Windows.Forms;

namespace laskuharjoituspeli
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            {
                for (int time = 0; time < 20; time++)
                {
                    Random random = new Random(); /* random number for nmb1lbl to nmb20lbl */
                    int randomNumber = random.Next(1, 20);
                    nmb1lbl.Text = (randomNumber.ToString());

                   
                    int randomNumber1 = random.Next(1, 20);
                    nmb2lbl.Text = (randomNumber1.ToString());
                    int randomNumber2 = random.Next(1, 20);
                    nmb3lbl.Text = (randomNumber2.ToString());
                    int randomNumber3 = random.Next(1, 20);
                    nmb4lbl.Text = (randomNumber3.ToString());
                    int randomNumber4 = random.Next(1, 20);
                    nmb5lbl.Text = (randomNumber4.ToString());
                    int randomNumber5 = random.Next(1, 20);
                    nmb6lbl.Text = (randomNumber5.ToString());
                    int randomNumber6 = random.Next(1, 20);
                    nmb7lbl.Text = (randomNumber6.ToString());
                    int randomNumber7 = random.Next(1, 20);
                    nmb8lbl.Text = (randomNumber7.ToString());
                    int randomNumber8 = random.Next(1, 20);
                    nmb9lbl.Text = (randomNumber8.ToString());
                    int randomNumber9 = random.Next(1, 20);
                    nmb10lbl.Text = (randomNumber9.ToString());
                    int randomNumber10 = random.Next(1, 20);
                    nmb11lbl.Text = (randomNumber10.ToString());
                    int randomNumber11 = random.Next(1, 20);
                    nmb12lbl.Text = (randomNumber11.ToString());
                    int randomNumber12 = random.Next(1, 20);
                    nmb13lbl.Text = (randomNumber12.ToString());
                    int randomNumber13 = random.Next(1, 20);
                    nmb14lbl.Text = (randomNumber13.ToString());
                    int randomNumber14 = random.Next(1, 20);
                    nmb15lbl.Text = (randomNumber14.ToString());
                    int randomNumber15 = random.Next(1, 20);
                    nmb16lbl.Text = (randomNumber15.ToString());
                    int randomNumber16 = random.Next(1, 20);
                    nmb17lbl.Text = (randomNumber16.ToString());
                    int randomNumber17 = random.Next(1, 20);
                    nmb18lbl.Text = (randomNumber17.ToString());
                    int randomNumber18 = random.Next(1, 20);
                    nmb19lbl.Text = (randomNumber18.ToString());
                    int randomNumber19 = random.Next(1, 20);
                    nmb20lbl.Text = (randomNumber19.ToString());
                    time++;
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
                plusbtn.Visible = false;
                minusbtn.Visible = false;
                plusminusbtn.Visible = false;
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
            plusbtn.Visible = false;
            minusbtn.Visible = false;

        } 
       
    }
    }

