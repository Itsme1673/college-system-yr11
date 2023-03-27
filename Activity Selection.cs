using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAthleticsActivity_Click(object sender, EventArgs e) //This takes the user to the athletics form. Similar code can be used for different payments for different events.
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }

        private void btnLogOutFromActivitySelection_Click(object sender, EventArgs e) //This takes you out of the activity selection and back to the login screen where you can close the program.
        {                                                                             
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
            MessageBox.Show("Successfully Logged Out");
        }
    }
}


//There are so many things that i could have done with this program but i dont know how to do it and it looks like a lot of effort. That said, im happy with what ive made i just think it could be improved upon a lot more if we had more time and if i had the patience to figure out bugs.
//Most of the code in Athletics Form.cs made me pull my hair out but i eventually fixed it and it works fine now.
//I removed the x on all the forms so that the user is forced to close the program using the button on the login screen and also so it closes properly and doesnt take up cpu or memory resources.