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
    public partial class FormMain : Form
    {
        int hour, minute;
        public string profile;
        public string stthour, sttminute;
        public string endhour, endminute;
        public string exx;
        public FormMain()
        {
            InitializeComponent();
        }
        List<ListBreak> listBreaks = new List<ListBreak>();

        // ham nhan data break vua dc khoi tao
        public void GETVALUE(string pro, string stth, string sttm, string endh, string endm)
        {
            profile = pro;
            stthour = stth;
            sttminute = sttm;
            endhour = endh;
            endminute = endm;           

            ListBreak breaks = new ListBreak(profile, stthour, sttminute, endhour, endminute);
            listBreaks.Add(breaks);
            l.Items.Add(breaks.stthour +":"+ breaks.sttminute);
        }
        // ham nhan data  form edit 
        public void GETEDITDATA(string pro, string stth, string sttm, string endh, string endm)
        {
            profile = pro;
            stthour = stth;
            sttminute = sttm;
            endhour = endh;
            endminute = endm;

            ListBreak neww = new ListBreak(profile, stthour, sttminute, endhour, endminute);
            int location = l.SelectedIndex;
            l.Items.RemoveAt(location);
            l.Items.Insert(location, neww.profile);

            listBreaks.RemoveAt(location);
            listBreaks.Insert(location, neww);
        }
        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int location = l.SelectedIndex;
                ListBreak breaks = listBreaks.ElementAt(location);
                frmdetail frdt = new frmdetail(profile, stthour, sttminute, endhour, endminute);
                frdt.editeddata = new frmdetail.EDITDATA(GETEDITDATA);
                frdt.ShowDialog();
            }
            catch { }         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmadd frmadd = new frmadd();
            frmadd.Addbreak = new frmadd.SENDDATA(GETVALUE);
            frmadd.ShowDialog();
        }

        private void btnSelectBreak_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            stthour = stthour + 5;
            if (stthour == hour.ToString() && sttminute == (minute.ToString() + 5))
            {
                MessageBox.Show("time to go to bed");
            }
            //notice();
            //System.Diagnostics.Process.Start("shutdown", "-s -t" + 10);
        }
        void notice()
        {
            
            if (stthour == hour.ToString() && sttminute == minute.ToString())
            {
                SoundSleep ss = new SoundSleep();
                ss.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
