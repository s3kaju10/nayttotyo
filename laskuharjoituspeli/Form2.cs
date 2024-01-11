using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laskuharjoituspeli
{
    public partial class Form2 : Form
    {
        public string ReceivedData
        {
            get { return form2textbox.Text; }
            set { form2textbox.Text = value; }
        }


        public Form2()
        {
            InitializeComponent();

        }

        
    }
}
