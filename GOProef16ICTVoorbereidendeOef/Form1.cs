using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GOProef16ICTVoorbereidendeOef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            AddButtons();
        }
             private void AddButtons()
        {
            int Aantal = 100;
            int xPos = 0;
            int yPos = 0;
            // Declare and assign number of buttons = 26 
            System.Windows.Forms.CheckBox[] btnArray = new System.Windows.Forms.CheckBox[Aantal ];
            // Create (26) Buttons: 
            for (int i = 0; i < Aantal ; i++)
            {
                // Initialize one variable 
                btnArray[i] = new System.Windows.Forms.CheckBox();
            }
            int n = 0;

            Random rnd = new Random(); // nodig om verschillende getallen te kunnen genereren
            while (n < Aantal )
            {
                btnArray[n].Tag = n + 1; // Tag of button 
                btnArray[n].Width = 24; // Width of button 
                btnArray[n].Height = 20; // Height of button 
                if (n % 10 == 0) // Location of second line of buttons: 
                {
                    xPos = 0;
                    yPos += 20;
                }
                // Location of button: 
                btnArray[n].Left = xPos;
                btnArray[n].Top = yPos;
                // Add buttons to a Panel: 
                pnlButtons.Controls.Add(btnArray[n]); // Knoppenn aan panel toevoegen 
                xPos = xPos + btnArray[n].Width; // Links van de vorige knop 
                btnArray[n].Appearance = Appearance.Button; //checkbox als button tonen
                btnArray[n].FlatStyle = FlatStyle.Popup; //popup stijl voor je button
               
                // Genereer getal tussen 0 en 4 en toon dit als tekst in de checkbox-button
                byte getal= (byte)(rnd.Next(5)); //getal genereren tussen 0 en 4

                btnArray[n].Text = (getal).ToString();
                switch (getal)
                {
                    case 0: btnArray[n].BackColor = Color.Blue; break;
                    case 1: btnArray[n].BackColor = Color.Green ; break;
                    case 2: btnArray[n].BackColor = Color.Red ; break;
                    case 3: btnArray[n].BackColor = Color.White ; break;
                    case 4: btnArray[n].BackColor = Color.Black ; break;

                }
                

                // the Event of click Button 
                btnArray[n].Click += new System.EventHandler(ClickButton);
                n++;
            }
            btnAddButton.Enabled = false; // not need now to this button now 
            //label1.Visible = true;
        
        }
      
             public void ClickButton(Object sender, System.EventArgs e)
             {
                 CheckBox btn = (CheckBox)sender;
                 MessageBox.Show("You clicked character [" + btn.Text + "]");


             }

             public string tekstje="test";//public zodat het overal kan gebruikt worden
             private void button1_Click(object sender, EventArgs e)
             {
                frmForm2  frmTweede = new frmForm2(this);//via this form1 doorgeven
                frmTweede.Show();
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 this.Text = tekstje;
             }
    }
}
