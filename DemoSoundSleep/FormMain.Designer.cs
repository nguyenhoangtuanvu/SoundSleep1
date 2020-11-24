
namespace DemoSoundSleep
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelectBreak = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(326, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelectBreak
            // 
            this.btnSelectBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectBreak.Location = new System.Drawing.Point(416, 270);
            this.btnSelectBreak.Name = "btnSelectBreak";
            this.btnSelectBreak.Size = new System.Drawing.Size(98, 33);
            this.btnSelectBreak.TabIndex = 1;
            this.btnSelectBreak.Text = "Select Break";
            this.btnSelectBreak.UseVisualStyleBackColor = true;
            this.btnSelectBreak.Click += new System.EventHandler(this.btnSelectBreak_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(531, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l
            // 
            this.l.Dock = System.Windows.Forms.DockStyle.Top;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.l.FormattingEnabled = true;
            this.l.ItemHeight = 20;
            this.l.Location = new System.Drawing.Point(0, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(612, 264);
            this.l.TabIndex = 4;
            this.l.SelectedIndexChanged += new System.EventHandler(this.l_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 315);
            this.Controls.Add(this.l);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSelectBreak);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormMain";
            this.Text = "Set Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelectBreak;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox l;
    }
}

