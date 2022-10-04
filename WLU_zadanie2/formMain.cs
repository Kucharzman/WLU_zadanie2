﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WLU_zadanie2
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            cmbHow.SelectedItem = null;
            cmbHow.SelectedText = "-Wybierz-";
            cmbWhat.SelectedItem = null;
            cmbWhat.SelectedText = "-Wybierz-";


            string[] lns = File.ReadAllLines(@"C:\Users\student\source\repos\WLU_zadanie2\WLU_zadanie2\Uczniowie.txt");
            foreach (string line in lns)
            {
                edtOut.Text += line;
                edtOut.Text += Environment.NewLine;
            }
        }

        private void bttDodajUcznia_Click(object sender, EventArgs e)
        {
            string sToWrite = "";

            sToWrite = tbImie.Text.Trim() + " " + tbNazwisko.Text.Trim() + " " + tbKlasa.Text.Trim();

            if (!File.Exists("C:\\Users\\student\\source\\repos\\WLU_zadanie2\\WLU_zadanie2\\Uczniowie.txt"))
            {
                File.Create("C:\\Users\\student\\source\\repos\\WLU_zadanie2\\WLU_zadanie2\\Uczniowie.txt").Close();
                using (StreamWriter streamr = File.AppendText("C:\\Users\\student\\source\\repos\\WLU_zadanie2\\WLU_zadanie2\\Uczniowie.txt"))
                {
                    streamr.WriteLine(sToWrite);
                }
            }
            else
            {
                using (StreamWriter streamr = File.AppendText("C:\\Users\\student\\source\\repos\\WLU_zadanie2\\WLU_zadanie2\\Uczniowie.txt"))
                {
                    streamr.WriteLine(sToWrite);
                }
            }
        }
    }
}
