using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie
{
    public partial class Form1 : Form
    {

        string lname, lnBadania;
        string ldata;

       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        struct pacjenci
        {
            public string imie;
            public string nazwabadania;
            public string data;

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString(); //dzisiejszy czas 

            labelDate.Text = DateTime.Now.ToLongDateString();// dzisejsza data
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            lname = textBoxImie.Text;
            lnBadania = textBoxNazwaBadania.Text;
            ldata = dateTimePicker1.Text;

            MessageBox.Show("Dane: "+lname + " " + lnBadania + " " + ldata + " Zostały dodane"); //wyswietlenie obecnych danych.
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker.
          
        }
    }
}
