﻿using System;
using System.Collections;
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
            string imie;
            string nazwa_bad;
            float data_bad;

        }
        // queue
        Queue kolejka = new Queue();
        
            







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
            /*lname = textBoxImie.Text;     
            lnBadania = textBoxNazwaBadania.Text;
            ldata = dateTimePicker1.Text;
            MessageBox.Show("Dane: "+lname + " " + lnBadania + " " + ldata + " Zostały dodane"); //wyswietlenie obecnych danych.
            */      //meh
            
           
        }

        private void buttontxt_Click(object sender, EventArgs e)
        {
            //queue simple export file = "queues.txt";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker.
          
        }

    }
}
