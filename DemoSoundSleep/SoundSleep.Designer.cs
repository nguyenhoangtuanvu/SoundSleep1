
namespace DemoSoundSleep
{
    partial class SoundSleep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundSleep));
            this.ListSong = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListSong
            // 
            this.ListSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListSong.Font = new System.Drawing.Font("Blackadder ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSong.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ListSong.FormattingEnabled = true;
            this.ListSong.ItemHeight = 26;
            this.ListSong.Location = new System.Drawing.Point(0, 0);
            this.ListSong.Name = "ListSong";
            this.ListSong.Size = new System.Drawing.Size(800, 160);
            this.ListSong.TabIndex = 0;
            this.ListSong.SelectedIndexChanged += new System.EventHandler(this.ListSong_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 160);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 290);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // SoundSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.ListSong);
            this.Name = "SoundSleep";
            this.Text = "SoundSleep";
            this.Load += new System.EventHandler(this.SoundSleep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListSong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}