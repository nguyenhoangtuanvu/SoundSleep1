using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSoundSleep
{
    public partial class frmdetail : Form
    {
        public delegate void EDITDATA(string profile, string stthour, string sttminute, string endhour, string endminute);
        public EDITDATA editeddata;

        public string profile;
        public string stthour, sttminute;
        public string endhour, endminute;
        public frmdetail()
        {
            InitializeComponent();
        }
        // ham constructor nhan data tu listbax form1.
        public frmdetail(string pro, string stth, string sttm, string endh, string endm)
        {
            InitializeComponent();
            this.profile = pro;
            this.stthour = stth;
            this.sttminute = sttm;
            this.endhour = endh;
            this.endminute = endm;
        }
  
/*        public void GETDATA(string pro, string stth, string sttm, string endh, string endm)
        {
            profile = pro;
            stthour = stth;
            sttminute = sttm;
            endhour = endh;
            endminute = endm;
        }*/

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtprodt.Text.Length > 0)
            {
                if (editeddata != null)
                    editeddata(txtprodt.Text,
                    cbb1.SelectedItem.ToString(),
                    cbb2.SelectedItem.ToString(),
                    cbb3.SelectedItem.ToString(),
                    cbb4.SelectedItem.ToString());

            }
            else
            {
                MessageBox.Show("please input full information!");
            }
            this.Dispose();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

        }

        private void frmdetail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                cbb1.Items.Add(i);
            }
            for (int j = 0; j <= 50; j = j + 10)
            {
                cbb2.Items.Add(j);
            }
            for (int a = 0; a <= 24; a++)
            {
                cbb3.Items.Add(a);
            }
            for (int b = 0; b <= 50; b = b + 10)
            {
                cbb4.Items.Add(b);
            }

            txtprodt.Text = profile;
            cbb1.Text = stthour;
            cbb2.Text = sttminute;
            cbb3.Text = endhour;
            cbb4.Text = endminute;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
