using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int gravity = 15;
        int pipespeed = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void zamanEvent(object sender, EventArgs e)
        {
            bok.Top += gravity;  //Burada topun aşağı kaymasını sağlamış oluyoruz.
            ust.Left -= pipespeed;
            alt.Left -= pipespeed; // burada pipeların sola doğru kaymasını sağlamış oluyoruz.
            label1.Text = "Score:" + score;


            if (alt.Left < -50)
            {
                alt.Left = 850;
                score++;
            }
                

            if (ust.Left < -50)
            {
                ust.Left = 900;
                score++;
            }
                 
            // Burada pipelar -50 yani gittiğinde tekrardan gelmelerini sağlıyoruz. ileri bir yere konumluyoruz.

            if (bok.Bounds.IntersectsWith(ust.Bounds) || bok.Bounds.IntersectsWith(alt.Bounds) || bok.Bounds.IntersectsWith(zemin.Bounds) )
            {
                zaman.Stop();
                label1.Text +=  "Game OVER!!";  // Burada imageler birbirine değerse oyunu yani timer'ı durdurduk.
                button1.Enabled = true;
                button1.Visible = true;


            }

            if (score >= 8)
                pipespeed = 13;

            if (score >= 20)
                pipespeed = 20;

            if (bok.Top < -25)
            {
                zaman.Stop();
                label1.Text += "Game OVER!!";  // Burada imageler birbirine değerse oyunu yani timer'ı durdurduk.
                button1.Enabled = true;
                button1.Visible = true;

            }


        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zaman.Start();
            gravity = 15;
            pipespeed = 10;
            score = 0;
            bok.Location = new Point(50, 300);
            ust.Location = new Point(526, 12);
            alt.Location = new Point(350, 405);
            button1.Enabled = false;
            button1.Visible = false;
        }
    }
}
