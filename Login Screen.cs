using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  
using System.Xml;      //added so the program can read a .xml file   
using System.IO;

namespace College_System
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            XmlDocument document = new XmlDocument();              //Stole this xml file reader from google
            document.Load("Sign In Details.xml");
            XmlNodeList UsernameList = document.GetElementsByTagName("Username");
            XmlNodeList PasswordList = document.GetElementsByTagName("Password");
            int i = 0;

            while (i != -1 && UsernameList.Count != i)
            {
                if (UsernameList[i].InnerText == txtLoginUser.Text && PasswordList[i].InnerText == txtLoginCode.Text)
                {
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                    
                    i = -1;
                }
                else
                {
                    i++;
                }
            }
            if (UsernameList.Count == i)
            {
                MessageBox.Show("Incorrect Username or Password, Please Try Again", "Login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error); //This makes the message box play an error sound and display a red x
            }
            
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void pcbSchoolLogo_Click(object sender, EventArgs e) //this is here so i can quickly get to the other form and will be removed
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
