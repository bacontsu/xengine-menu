using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace xEngine
{
    public partial class Form1 : Form
    {
        bool busy = false;
        bool settingBool = false;
        int settingOpen = 0;

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
          //  this.BackColor = Color.Gray;
           // this.TransparencyKey = Color.Gray; //dont mind this i was trying chroma key but its cropping like poo poo
            //TopMost = true;
           // Process.Start("start.bat");

        }
        public class FormProvider   //this handles the setting windows so i can show/hide it
        {
            public static Setting setting
            {
                get
                {
                    if (_mainMenu == null)
                    {
                        _mainMenu = new Setting();
                        
                    }
                    return _mainMenu;
                }
            }
            private static Setting _mainMenu;
}


        public class exitShow  //this handles the exit window
        {
            public static Exit exitPage
            {
                get
                {
                    if (_exitPage == null)
                    {
                        _exitPage = new Exit();
                    }
                    return _exitPage;
                }
            }
            private static Exit _exitPage;
        }



            public void MoveHighlight(int yTarget, int yCurrent) 
            //this moves the white thing by calculating the distance and changes it slowly
            //note : theres might another efficient way for doing this but well im using this for now :p
        {
            highlighter.Show();
            if (!busy)
            {

                busy = true;
                if (yTarget > yCurrent)
                {

                    for (int i = 0; i < (yTarget - yCurrent); i++)
                    {
                        Task.Delay(100);
                        highlighter.Top++;

                    }
                    busy = false;
                }
                else
                {
                    for (int i = 0; i < (yCurrent - yTarget); i++)
                    {
                        Task.Delay(100);
                        highlighter.Top--;

                    }
                    busy = false;

                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            highlighter.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            exitShow.exitPage.Owner = this;
            exitShow.exitPage.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Process.Start("start.bat"); //just use a bat file to start the game lol i have no idea why those code downwards freezes the app
            Application.Exit();
            /*
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "start.bat";
            p.StartInfo.Arguments = "-console";
            p.Start();
            p.WaitForExit();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            */
        }


        private void benchBtn_Click(object sender, EventArgs e)
        {

        }



        private void benchBtn_MouseEnter(object sender, EventArgs e)
        {
            MoveHighlight(benchBtn.Top, highlighter.Top);
        }

        private void startBtn_MouseEnter(object sender, EventArgs e)
        {
            MoveHighlight(startBtn.Top, highlighter.Top);
        }

        private void settingBtn_MouseEnter(object sender, EventArgs e)
        {
            MoveHighlight(settingBtn.Top, highlighter.Top);
        }

        private void discordBtn_MouseEnter(object sender, EventArgs e)
        {
            MoveHighlight(discordBtn.Top, highlighter.Top);
        }

        private void quitBtn_MouseEnter(object sender, EventArgs e)
        {
            MoveHighlight(quitBtn.Top, highlighter.Top);
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            highlighter.Hide();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            highlighter.Hide();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            FormProvider.setting.Owner = this;
            //FormProvider.setting.Opa
            FormProvider.setting.Show();
            

       
        }

        private void benchBtn_MouseLeave(object sender, EventArgs e)
        {
            Task.Delay(10).Wait();
            highlighter.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e) //fading effect when you open it
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }

            Opacity += 0.1;
        }
    }

        
}
