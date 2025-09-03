using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Laboratory_Exercise_1_YunosA
{
    public partial class Form2 : Form
    {
        StudentInfoClass.DelegateText DelText;
        StudentInfoClass.DelegateNumber DelNum;
        public Form2()
        {
            InitializeComponent();

            DelText = (txt) => txt;
            DelNum = (num) => num;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
   
            lblStudentNo.Text = DelNum(StudentInfoClass.StudentNo).ToString();
            lblProgram.Text = DelText(StudentInfoClass.Program);
            lblFirstName.Text = DelText(StudentInfoClass.FirstName);
            lblMiddleName.Text = DelText(StudentInfoClass.MiddleName);
            lblLastName.Text = DelText(StudentInfoClass.LastName);
            lblAge.Text = DelNum(StudentInfoClass.Age).ToString();
            lblContactNo.Text = DelNum(StudentInfoClass.ContactNo).ToString();
            lblAddress.Text = DelText(StudentInfoClass.Address);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
