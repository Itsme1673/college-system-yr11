using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Xml;      //added so the program can read a .xml file   
using System.Text.RegularExpressions;

namespace College_System
{
    public partial class Form2 : Form
    {
        string[] ChangedValues = new string[140]; //This is here so i can use both strings across the whole form.
        string[] Activities = new string[140];
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            form1.Visible = true;
            this.Close();
            MessageBox.Show("Logout Successful");
            
                               
        }
        private void btnSubmit_Click(object sender, EventArgs e) //there are a lot of if statements here
        {
            XmlDocument document = new XmlDocument();              //Again this xml file reader stuff is from google. this easily allows me to have multiple correct usernames and passwords and student ids without having to put them in code
            document.Load("StudentIDs.xml");                           //this looks for the xml file and loads it
            XmlNodeList StudentIDList = document.GetElementsByTagName("Username"); //this looks for anything between <Username> and </Username> in the xml file and adds it to a list
            int i = 0;
            while (i != -1 && StudentIDList.Count != i)
            { 
                    if (StudentIDList[i].InnerText == txtStudentID.Text)
                    {
                        i = -1; //if the input id is in the list it sets the i variable to -1
                    }
                    else
                    {
                        i++;   //if the input id is not in the list it keeps adding 1 to the variable
                    }
            }
                if ((StudentIDList.Count == i) || ((string.IsNullOrEmpty(txtFirstName.Text)) || (string.IsNullOrEmpty(txtLastName.Text)) || (string.IsNullOrEmpty(txtAge.Text)) || (string.IsNullOrEmpty(cbxActivity.Text)) || (string.IsNullOrEmpty(cbxFormGroup.Text)) || (string.IsNullOrEmpty(cbxGender.Text)) || (string.IsNullOrEmpty(cbxPaymentMethod.Text))) || !Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(cbxGender.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(cbxPaymentMethod.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(txtAge.Text, @"^[a-zA-Z]+$"))
                {                                  // found this on google, works better and is shorter than if (txtFirstName.Text == "" || txtFirstName.Text == null)                                                                                                                                                                                                 I also found this on google. This checks if the text in the box is any character from a-z. the ones that i dont want to have numbers in start with an ! and the one that i do want only numbers in doesnt.
                    MessageBox.Show("SUBMISSION ERROR \nPossible Solutions: \nIncorrect Student ID \nEmpty Fields \nNumbers In Text Fields \nText in Number Fields", "Submission Error",  //the \n adds a new line to the text of the message box
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Activities[0] = "Student ID :" + txtStudentID.Text;    //This sets each line of the text file to the input values
                    Activities[1] = "Name: " + txtFirstName.Text;
                    Activities[2] = "Last Name: " + txtLastName.Text;
                    Activities[3] = "Age: " + txtAge.Text;
                    Activities[4] = "Activity: " + cbxActivity.Text;
                    Activities[5] = "Form Group: " + cbxFormGroup.Text;
                    Activities[6] = "Gender: " + cbxGender.Text;           //As you can see from the form, i tried to be as inclusive as i could so some people dont feel left out.
                    Activities[7] = "Payment Method: " + cbxPaymentMethod.Text;
                    Activities[8] = "Total Cost: " + lblCost.Text;
                    File.WriteAllLines($"Activities.txt", Activities);   
                    MessageBox.Show("Save Successful, You may now log off or make an edit if you made a mistake"); //i added using System.IO at the top so i didnt have to type it at the start of this

                    ChangedValues[0] = txtStudentID.Text;             //This sets a string to the text box, combo box and label values that change without the "Student ID: " thing so I can see if the value of any of the boxes have changed after it has been submitted.
                    ChangedValues[1] = txtFirstName.Text;
                    ChangedValues[2] = txtLastName.Text;
                    ChangedValues[3] = txtAge.Text;
                    ChangedValues[4] = cbxActivity.Text;
                    ChangedValues[5] = cbxFormGroup.Text;
                    ChangedValues[6] = cbxGender.Text;
                    ChangedValues[7] = cbxPaymentMethod.Text;
                    ChangedValues[8] = lblCost.Text;
                    File.WriteAllLines($"ChangedValues.txt", ChangedValues); //Looking back on this, I didn't need to write it to a text file but i did it anyway for reasons known only to myself at the time that i coded this
                }
            }

        

     

        private void btnActivitySelectionFromAthletics_Click(object sender, EventArgs e)  //this takes you back to the activity selection screen
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();

        }

        private void btnEditSubmission_Click(object sender, EventArgs e)  //this checks if the input values have changed and if any of them has, it changes it in the text file.
        {
           
           
            if (txtStudentID.Text != ChangedValues[0] || txtFirstName.Text != ChangedValues[1] || txtLastName.Text != ChangedValues[2] || txtAge.Text != ChangedValues[3] || cbxActivity.Text != ChangedValues[4] || cbxFormGroup.Text != ChangedValues[5] || cbxGender.Text != ChangedValues[6] || cbxPaymentMethod.Text != ChangedValues[7] || lblCost.Text != ChangedValues[8])
            {
                Activities[0] = "Student ID :" + txtStudentID.Text;
                Activities[1] = "Name: " + txtFirstName.Text;
                Activities[2] = "Last Name: " + txtLastName.Text;
                Activities[3] = "Age: " + txtAge.Text;
                Activities[4] = "Activity: " + cbxActivity.Text;
                Activities[5] = "Form Group: " + cbxFormGroup.Text;
                Activities[6] = "Gender: " + cbxGender.Text;
                Activities[7] = "Payment Method: " + cbxPaymentMethod.Text;
                Activities[8] = "Total Cost: " + lblCost.Text;
                File.WriteAllLines($"Activities.txt", Activities);
                MessageBox.Show("Changes Applied Successfully");
            }
            else
            {
                MessageBox.Show("Unable To Edit File \nReason: No Changes To Form Detected");  //If there are no changes detected, this message box will show.
            }

        }

        private void cbxActivity_SelectedIndexChanged(object sender, EventArgs e)  //This looks for changes in the text of the combo box and sets the value of the cost label to the cost of the respective activity.
        {                                                                          //I had a button that when pressed, would update the cost label but people could use it to get around the payment and i suddenly remebered that i can do this instead so people couldnt get free stuff so i did.
            if (cbxActivity.Text == "Music ($30)")
            {
                lblCost.Text = "$30";
            }
            if (cbxActivity.Text == "Swimming ($25.50)")
            {
                lblCost.Text = "$25.50";
            }
            if (cbxActivity.Text == "Tennis ($20)")
            {
                lblCost.Text = "$20";
            }
            if (cbxActivity.Text == "Basketball ($15.50)")
            {
                lblCost.Text = "$15.50";
            }
            if (cbxActivity.Text == "Netball ($15.50)")
            {
                lblCost.Text = "$15.50";
            }
            if (cbxActivity.Text == "Dance ($10.50)")
            {
                lblCost.Text = "10.50";
            }
            if (cbxActivity.Text == "Community Service (No Charge)")
            {
                lblCost.Text = "$0";
            }
            
        }
    }
}
// Similar code can be used for more events, just that the data would have to be saved to a different file.