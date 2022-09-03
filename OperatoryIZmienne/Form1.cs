using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatoryIZmienne
{
    public partial class Form1 : Form
    {
        bool PrawdaFalsz = false;
        int LiczbaCalkowita = 2;
        string LancuchZnakow = "cos";
        float LiczbaZmiennoprzecinkowa = 1.5f ;
        double Lzmiennoprzec = 5.231d;
        decimal kwota = 12.54m;
        char znak = 'A';
        byte malaLiczba = 255;         
        long duzaLiczna = 532487298;
        ushort LiczbaDodatnia  = 23;


        public Form1()
        {
            InitializeComponent();
            double x = LiczbaZmiennoprzecinkowa + Lzmiennoprzec;
            long y = duzaLiczna + LiczbaCalkowita;
           float bokA = 2.5F;

            float obw = 4 * bokA;
            int W = 1;


            

        }
    }
}
