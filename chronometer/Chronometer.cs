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
using System.Threading;

namespace chronometer
{
    public partial class Chronometer : Form
    {
        int timeSaniye,
            timeDakika,
            sonSaniye,
            toplamSaniye;
        
        double oran = 0,
            yuzde = 100;
        bool dur = true;
        bool baslamali = false;
        private void buttonBasla_Click(object sender, EventArgs e)
        {
            dur = true;
            buttonDur.Text = ("Dur");
            ZamanAyarla();


        }
        private void beep()
        {
            SoundPlayer audio = new SoundPlayer(chronometer.Properties.Resources.beep);
            audio.Play();
        }

        private void boop()
        {
            SoundPlayer audio = new SoundPlayer(chronometer.Properties.Resources.boop);
            audio.Play();
        }
        private void ZamanAyarla()
        {
            yuzde = 100;
            sonSaniye = Convert.ToInt32(numericUpDownSN.Value);
            timeDakika = Convert.ToInt32(numericUpDownDK.Value);
            toplamSaniye = timeDakika * 60;
            oran = (double)100 / toplamSaniye;
            Console.WriteLine(oran);

            circularProgressBar1.Maximum = toplamSaniye;
            circularProgressBar1.Value = toplamSaniye;
            circularProgressBar1.Minimum = 0;

            if (timeDakika >= 1)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timeDakika = timeDakika - 1;
                timeSaniye = 60;
            }
            else
            {
                timer1.Enabled = false;
            }


        }

        private void buttonDur_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                 baslamali = true;
            }
            if (baslamali)
            {
                if (dur)
                {
                    timer1.Enabled = false;
                    buttonDur.Text = ("Devam");
                    dur = false;
                }
                else
                {
                    timer1.Enabled = true;
                    buttonDur.Text = ("Dur");
                    dur = true;
                }

            }
        }

      


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timer1.Enabled)
            {


                timeSaniye--;
                if (timeSaniye == 0 && timeDakika >= 1)
                {
                    timeDakika = timeDakika - 1;
                    timeSaniye = 60;

                }
                if (timeDakika == 0 && timeSaniye == 0)
                {
                    timer1.Enabled = false;

                }

                if (timeDakika < 1 && timeSaniye < sonSaniye)
                {
                    beep();
                   
                }
                if (timeDakika <= 1 && timeSaniye <= 0)
                {
                    boop();
                }


                toplamSaniye--;
                yuzde = yuzde - oran;
                string new22 = string.Format("{0:#.##}", yuzde);
                labelOran.Text = Convert.ToString(new22 + "%");
                
                
                if (toplamSaniye >= 0)
                {

                    circularProgressBar1.Value = toplamSaniye;
                    circularProgressBar1.Update();
                }
            }


            ZamanGoster();
        }

        private void ZamanGoster()
        {
            textBoxsn.Text = String.Format("{0:00}", timeSaniye);
            textBoxdk.Text = String.Format("{0:00}", timeDakika);
        }
        public Chronometer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            */
            circularProgressBar1.Value = circularProgressBar1.Maximum;
           
            timer1.Enabled = false;
            timer2.Enabled = false;

        }
    }
}


   


