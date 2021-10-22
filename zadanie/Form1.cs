using System;
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

        Queue ulomnedzieci = new Queue();

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            /*lname = textBoxImie.Text;     
            lnBadania = textBoxNazwaBadania.Text;
            ldata = dateTimePicker1.Text;
            MessageBox.Show("Dane: "+lname + " " + lnBadania + " " + ldata + " Zostały dodane"); //wyswietlenie obecnych danych.
            */      //meh



            ulomnedzieci.Enqueue(textBoxImie.Text);// dodanie elementu do kolejki
            ulomnedzieci.Enqueue(textBoxNazwaBadania.Text);
            ulomnedzieci.Enqueue(dateTimePicker1.Text);
            //wyswietlaelementy kolejki
            labelImie.Text = textBoxImie.Text;
            labelBadania.Text = textBoxNazwaBadania.Text;
            labelData.Text = dateTimePicker1.Text;






        }
        private void buttontxt_Click(object sender, EventArgs e)
        {

            //Pass the filepath and filename to the StreamWriter Constructor
            //C:\Users\student\Documents\
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter(@"C:\\Users\student\Desktop\text.txt");
            //Write a line of text
            sw.WriteLine("Hello World!!");
            //Write a second line of text
            sw.WriteLine("From the StreamWriter class");

            //Close the file
            sw.Close();
            MessageBox.Show("sprawdz swoj dysk E!");
            
            



            System.Diagnostics.Debug.WriteLine("przycisk wyslij kliknieto " );
            
        }

        private void buttonusun_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("przycisk usun kliknieto " );
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker.

        }

        private void buttonp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("przycisk poprzedni kliknieto ");
        }

        private void buttonn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("przycisk nastepny kliknieto ");
        }

        private void buttonspdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("przycisk za ile badanie kliknieto ");
        }
    }
}

