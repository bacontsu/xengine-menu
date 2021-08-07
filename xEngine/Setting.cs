using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xEngine;
using System.IO;
using System.Runtime.InteropServices;


namespace xEngine
{
    public partial class Setting : Form
    {
        //dll import for winapi
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        public Setting()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start(); //starts the fading effect
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            



        }

        private void Setting_Load(object sender, EventArgs e)
        {
            
    }

        private void Setting_Shown(object sender, EventArgs e)
        {
            
        }

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();

           
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //dragging using winapi
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e) //fading effects
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }

            Opacity += 0.1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                
                timer1.Stop();
            }

            Opacity -= 0.1;
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer2.Start();
        }
    }
    }
