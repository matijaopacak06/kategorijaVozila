using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int brojMotocikala = 0;
        private int brojAutomobila = 0;
        private int brojKamiona = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                string model = txtModel.Text;
                int godina = int.Parse(txtGodinaProizvodnje.Text);
                int brojKotaca = int.Parse(txtBrojKotaca.Text);

                if (brojKotaca % 2 != 0)
                {
                    MessageBox.Show("Unos neparnog broja kotača nije dozvoljen.");
                    return;
                }

                if (brojKotaca == 2)
                {
                    brojMotocikala++;
                    txtIspis.AppendText($"Model: {model}, Godina: {godina}, Kategorija: Motocikl\n");
                }
                else if (brojKotaca == 4)
                {
                    brojAutomobila++;
                    txtIspis.AppendText($"Model: {model}, Godina: {godina}, Kategorija: Automobil\n");
                }
                else if (brojKotaca > 4)
                {
                    brojKamiona++;
                    txtIspis.AppendText($"Model: {model}, Godina: {godina}, Kategorija: Kamion\n");
                }
                txtModel.Clear();
                txtGodinaProizvodnje.Clear();
                txtBrojKotaca.Clear();

                DialogResult upit = MessageBox.Show("Želite li unijeti jos podataka?", "Upit",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            }
            catch
            {
                MessageBox.Show("Unesite Ispravne podatke");
            }
            
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            txtIspis.AppendText($"\nUkupan broj vozila:\nMotocikli: {brojMotocikala}\nAutomobili: {brojAutomobila}\nKamioni: {brojKamiona}\n");
        }


    }
    }
    
