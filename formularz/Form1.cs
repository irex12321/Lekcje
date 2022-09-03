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

namespace formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _rejestruj();
        }
        private void _rejestruj()
        {
            if (hasla())
            {
               // string path = @"C:\Users\HP\Desktop\logowanie.txt";
                string path = $@"C:\Users\HP\Desktop\konta\Users.txt";
                User user = new User();
                user.Name = textBox1.Text;
                user.LastName = textBox2.Text;
                user.Password = textBox3.Text;//\
                user.Dodaj(path);
                //using(File.Create(path))
                //{

                //}
                ////File.Create(path);
                
                //File.WriteAllLines(path, tablica);
                MessageBox.Show("pomyślnie zarejstrowano");
            }
            else
                MessageBox.Show("hasła się niezgadzają");
        }
        private bool hasla()
        {
            return textBox3.Text == textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(Logowanie dlg = new Logowanie())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Jestes zalogowany");
                using (Plansza pl = new Plansza())
                    pl.ShowDialog();
            }
        }
    }   
}
