using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace DemoSoundSleep
{
    public partial class SoundSleep : Form
    {
        //List<ListMusic> soundSleeps = new List<ListMusic>();
        //string pathS, Sname;
        string path = @"C:\Users\DELL\source\research\DemoSoundSleep\DemoSoundSleep\Resources\";
        /*SoundPlayer SoundPlayer = new SoundPlayer();*/
        string nameSong;
        public SoundSleep()
        {
            InitializeComponent();
        }

        public void SoundSleep_Load(object sender, EventArgs e)
        {
            string[] pathfiles = Directory.GetFiles(path, "*.mp3");
            foreach (string pathfile in pathfiles)
            {
                string namefile = pathfile.Replace(path, string.Empty);
                //textBox1.Text = Sname; // Sname.mp3 , pathsong = path + Sname
                string name = namefile.Replace(".mp3", string.Empty);
                //ListMusic song = new ListMusic(name);
                // Sname
                ListSong.Items.Add(name);
            }
        }

        private void ListSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int location = ListSong.SelectedIndex;
            nameSong = ListSong.Text;
            Song_relax();
        }
        void Song_relax()
        {
            axWindowsMediaPlayer1.URL = path + nameSong + ".mp3";
        }
    }
}
