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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _zaloguj();
        }

        private void _zaloguj()
        {
            string path = $@"C:\Users\HP\Desktop\konta\Users.txt"; 
            string[] dane = File.ReadAllLines(path);


            //Tworzymy obiekt użytkownika z danych logowania
            User user = new User();
            user.Name = textBox1.Text;
            user.LastName = textBox2.Text;
            user.Password = textBox3.Text;

            bool czyOk = false;// sprawdzLogowanie(dane, tablica);
            int i = 0;
            while(!czyOk && i < dane.Length)
            {
               czyOk = user.SprawdzLogowanie(user.FillUser(dane[i]));
                i++;
            }
            
            
            if (czyOk) 
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }

       else MessageBox.Show("podałeś błędne dane");
        }

        private bool sprawdzLogowanie(string[] dane, string[] tablica)
        {
            for (int i = 0; i < dane.Length; i++)
                if (dane[i] != tablica[i])
                    return false;
            return true;
        }
    }
}
