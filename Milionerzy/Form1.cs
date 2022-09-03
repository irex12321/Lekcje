using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milionerzy
{
    public partial class Form1 : Form
    {
        string popOdp;
        int numer = 0;
        List<PytanieOpd> pytanieOpds;

        private void Init() 
        {
            string[] Pytania = File.ReadAllLines(@"C:\Users\HP\Desktop\PytaniaMilionerzy.txt");




            pytanieOpds = new List<PytanieOpd>();


            string[] tablica = new string[4];
            tablica[0] = "A. Rok";
            tablica[1] = "B. od 10 do 13 lat";
            tablica[2] = "C. od 3 do 4";
            tablica[3] = "D. od 5 do 8";
            //popOdp = UzupelnijPytanieIOdp("ile żyje pszeciętny pies", tablica, 1);
            PytanieOpd pyt1 = new PytanieOpd("ile żyje pszeciętny pies", tablica, 1);
            pytanieOpds.Add(pyt1);

            string[] tablica2 = new string[4];
            tablica2[0] = "A. 100";
            tablica2[1] = "B. ok 30";
            tablica2[2] = "C. ok 60";
            tablica2[3] = "D. ok 14";
            PytanieOpd pyt2 = new PytanieOpd("ile nóg ma stonoga", tablica2, 3);
            pytanieOpds.Add(pyt2);

            string[] tablica3 = new string[4];
            tablica3[0] = "A.kon";
            tablica3[1] = "B.slon";
            tablica3[2] = "C.płetwal błękitny";
            tablica3[3] = "D.kot";
            //popOdp = UzupelnijPytanieIOdp("ile żyje pszeciętny pies", tablica, 1);
            PytanieOpd pyt3 = new PytanieOpd("Jakie jest największe zwierzę na świecie ", tablica3, 2);
            pytanieOpds.Add(pyt3);


            string[] tablica4 = new string[4];
            tablica4[0] = "A.merkury";
            tablica4[1] = "B.jowisz";
            tablica4[2] = "C.księżyc";
            tablica4[3] = "ziemia";
            //popOdp = UzupelnijPytanieIOdp("ile żyje pszeciętny pies", tablica, 1);
            PytanieOpd pyt4 = new PytanieOpd("największa planeta Układu Słonecznego ", tablica4, 1);
            pytanieOpds.Add(pyt4);

            int cnt = Pytania.Count();
            for (int i = 0; i < cnt; i++)
            {

                string[] strings = Pytania[i].Split(';');
                string[] tablica5 = new string[4];
                tablica5[0] = strings[1];
                tablica5[1] = strings[2];
                tablica5[2] = strings[3];
                tablica5[3] = strings[4];
                //popOdp = UzupelnijPytanieIOdp("ile żyje pszeciętny pies", tablica, 1);
                PytanieOpd pyt5 = new PytanieOpd(strings[0], tablica5, int.Parse(strings[5]));
                pytanieOpds.Add(pyt5);

            }



            popOdp = UzupelnijPytanieIOdp(pytanieOpds[numer].Pytanie, pytanieOpds[numer].Odpowiedzi, pytanieOpds[numer].index);


        }

        public Form1()
        {
            InitializeComponent();
            Init();
          
        }
       
        private string UzupelnijPytanieIOdp(string pytanie, string[] odp, int index)
        {
            odpABtn.Text = odp[0];
            B.Text = odp[1];
            C.Text = odp[2];
            D.Text = odp[3];
            textBox1.Text = pytanie;
            return odp[index];
        }

        private void Odp_Click(object sender, EventArgs e)
        {
            string odp = ((Button)sender).Text;
            Label label = new Label();
            if (odp == popOdp & numer < 12)
            {
                MessageBox.Show("poprawna odpowiedz");
                switch (numer)
                {
                    case 0:
                        label1.BackColor = Color.Green;
                        label = label1;
                        break;
                    case 1:
                        label2.BackColor = Color.Green;
                        label = label2;
                        break;
                    case 2:
                        label3.BackColor = Color.Green;
                        label = label3;
                        break;

                    case 3:
                        lb5000.BackColor = Color.Green;
                        label = lb5000;
                        break;
                    case 4:
                        label5.BackColor = Color.Green;
                        label = label5;
                        break;
                    case 5:
                        label6.BackColor = Color.Green;
                        label = label6;
                        break;
                    case 6:
                        label7.BackColor = Color.Green;
                        label = label7;
                        break;
                    case 7:
                        label11.BackColor = Color.Green;
                        label = label11;
                        break;
                    case 8:
                        label8.BackColor = Color.Green;
                        label = label8;
                        break;
                    case 9:
                        label9.BackColor = Color.Green;
                        label = label9;
                        break;
                    case 10:
                        label10.BackColor = Color.Green;
                        label = label10;
                        break;
                    case 11:
                        label12.BackColor = Color.Green;
                        label = label12;
                        break;
                }
                if(MessageBox.Show("Grasz dalej?", "",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    MessageBox.Show($"wygrałes {label.Text}zł");
                    RestartGame();
                    return;
                }
                    numer++;
                if (numer < pytanieOpds.Count)
                    popOdp = UzupelnijPytanieIOdp(pytanieOpds[numer].Pytanie, pytanieOpds[numer].Odpowiedzi, pytanieOpds[numer].index);
            }
            else
            {
                if (numer > 11)
                    MessageBox.Show("wygrałeś 1000000");
                else
                if (numer > 6)
                    MessageBox.Show("wygrałes 40000zł");
                else if (numer > 1)
                    MessageBox.Show("wygrałeś 1000zł");
                else
                    MessageBox.Show("przegrałeś");
                RestartGame();
            }

        }
        private void RestartGame()
        {
            numer = 0;
            popOdp = UzupelnijPytanieIOdp(pytanieOpds[numer].Pytanie, pytanieOpds[numer].Odpowiedzi, pytanieOpds[numer].index);
            label1.BackColor = Color.Blue;
            label2.BackColor = Color.Blue;
            label3.BackColor = Color.Blue;
            lb5000.BackColor = Color.Blue;
            label5.BackColor = Color.Blue;
            label6.BackColor = Color.Blue;
            label7.BackColor = Color.Blue;
            label11.BackColor = Color.Blue;
            label8.BackColor = Color.Blue;
            label9.BackColor = Color.Blue;
            label10.BackColor = Color.Blue;
            label12.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int a = R.Next(35-2*numer, 100);
            int b = R.Next(0,100 - a);
            int c = R.Next(0,100 - a - b);
            int d = 100 - a - b - c;

            pytanieOpds[numer].PytanieDoPublicznosci(a, b, c, d);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pytanieOpds[numer].TelefonDoPrzyjaciela(numer);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pytanieOpds[numer].PolNaPol();
            if (pytanieOpds[numer].zlaOdp1 == 0 || pytanieOpds[numer].zlaOdp2 == 0)
                odpABtn.Text = "";
            if
               (pytanieOpds[numer].zlaOdp1 == 1 || pytanieOpds[numer].zlaOdp2 == 1)
                B.Text = "";
            if
               (pytanieOpds[numer].zlaOdp1 == 2 || pytanieOpds[numer].zlaOdp2 == 2)
                C.Text = "";
            if
               (pytanieOpds[numer].zlaOdp1 == 3 || pytanieOpds[numer].zlaOdp2 == 3)
                D.Text = "";




            button3.Enabled = false;

        } 
    }

    public class PytanieOpd
    {
     

        public string Pytanie { get; set; }
        public string[] Odpowiedzi { get; set; }
        public int index { get; set; }
        public PytanieOpd(string pytanie, string[] odp, int index)
        {
            this.Pytanie = pytanie;
            this.Odpowiedzi = odp;
            this.index = index;
        }
       public void PytanieDoPublicznosci(int a,int b,int c,int d)
        {
            switch (index)
            {
                case 0:
                    MessageBox.Show($"Odp A:{a}%\nOdp B: {b}%\nodp C: {c}%\nodp D: {d}%");
                    break;
                case 1:
                    MessageBox.Show($"Odp A:{d}%\nOdp B: {a}%\nodp C: {b}%\nodp D: {c}%");
                    break;
                case 2:
                    MessageBox.Show($"Odp A:{c}%\nOdp B: {d}%\nodp C: {a}%\nodp D: {b}%");
                    break;
                case 3:
                    MessageBox.Show($"Odp A:{b}%\nOdp B: {c}%\nodp C: {d}%\nodp D: {a}%");
                    break;
            }
        }
        public void TelefonDoPrzyjaciela(int numer)
        {
            Random r = new Random();
            int i = r.Next(0, 100);

            //int zlyIndex = (index + 1) % 4;
            string zlaOdp = "";
            string dobraOdp = "";
            switch (index)
            {
                case 0:
                    zlaOdp = "B";
                    dobraOdp = "A";
                    break;
                case 1:
                    zlaOdp = "C";
                    dobraOdp = "B";
                    break;
                case 2:
                    zlaOdp = "D";
                    dobraOdp = "C";
                    break;
                case 3:
                    zlaOdp = "A";
                    dobraOdp = "D";
                    break;
            }
            if (i > 95 -( 6 * numer))
                MessageBox.Show($"poprawną odpowiedzią jest {zlaOdp}");
            else
       MessageBox.Show($"poprawną odpowiedzią jest {dobraOdp}");
            



        }
        public int zlaOdp1 = -1;
        public int zlaOdp2 =-1;
        public void PolNaPol() 
        {
            Random r = new Random();

            while (zlaOdp2 == -1)
            {
                int l1 = r.Next(0, 3);
                if (l1 == index)
                {
                    continue;
                }
                else if (zlaOdp1 == -1)
                {
                    zlaOdp1 = l1;
                   
                }
                else if (zlaOdp2 == -1)
                {
                    if (l1 != zlaOdp1)
                        zlaOdp2 = l1;
                   
                }
            }

         }
    }
}
