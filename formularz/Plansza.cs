using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularz
{
    public partial class Plansza : Form
    {

        int krok = 5;
        private Objects.Player player1;
        public Plansza()
        {
            InitializeComponent();
            pictureBox2.BringToFront();

            AddControl();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Plansza_KeyPress);

        }
        private void AddControl()
        {
            this.player1 = new formularz.Objects.Player();
            this.player1.Location = new System.Drawing.Point(126, 106);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(81, 75);
            this.player1.TabIndex = 3;
            this.Controls.Add(this.player1);
        }
        private void Plansza_KeyPress(object sender, KeyPressEventArgs e)
        {
            Klawiatura k = (Klawiatura)e.KeyChar;
            bool czyDotyka = player1.Bounds.IntersectsWith(pictureBox2.Bounds);
            switch (k)
            {
                case Klawiatura.w:
                    player1.Top -= krok;
                    if (czyDotyka)
                        pictureBox2.Top -= krok+2;
                break;

                case Klawiatura.s:
                    player1.Top += krok;
                   if (czyDotyka)
                        pictureBox2.Top += krok+2;
                    break;

                case Klawiatura.a:
                    player1.Left -= krok;
                    if (czyDotyka)
                        pictureBox2.Left -= krok+2;
                    break;

                case Klawiatura.d:
                    player1.Top -= krok;
                        
                     if (czyDotyka)
                    pictureBox2.Left += krok+2;
                    break;
            }
            if (pictureBox2.Location.X == pictureBox3.Location.X 
                && pictureBox2.Location.Y==pictureBox3.Location.Y)
                MessageBox.Show("wygrana");
                
        }


        public enum Klawiatura
        {
            spacja = 0x20,
                w = 0x77,
                s = 0x73,
                a = 0x61,
                d = 0x64,
                e = 0x65,
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
