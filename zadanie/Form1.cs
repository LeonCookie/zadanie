﻿using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;




namespace zadanie
{
    public partial class Form1 : Form
    {


        //zmienne
        const int MAXINT = -2147483647;


        /*string lname, lnBadania;
        string ldata;
        */ // do zabawy z button wyślij





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
        struct pacjenci
        {
            
            string imie;
            string nazwa_bad;
            float data_bad;

        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            /*lname = textBoxImie.Text;     
            lnBadania = textBoxNazwaBadania.Text;
            ldata = dateTimePicker1.Text;
            MessageBox.Show("Dane: "+lname + " " + lnBadania + " " + ldata + " Zostały dodane"); //wyswietlenie obecnych danych.
            */      //meh

            Queue ulomnedzieci = new Queue();

            ulomnedzieci.Enqueue(1);// dodanie elementu do kolejki
            ulomnedzieci.Enqueue(2);
            foreach(int i in ulomnedzieci)//wyswietlaelementy kolejki
            {
                System.Diagnostics.Debug.WriteLine(i);
            }



        }
        private void buttontxt_Click(object sender, EventArgs e)
        {
           
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("E:\\Test.txt");
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
            
                //Close the file
                sw.Close();
                MessageBox.Show("sprawdz swoj dysk E!");




                System.Diagnostics.Debug.WriteLine("Exception: " );
            
            
                System.Diagnostics.Debug.WriteLine("Executing finally block.");
            
        }

        private void buttonusun_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker.

        }

    }
}

