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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = StudentInfoClass.GetStudentNo(long.Parse(txtStudentNo.Text));
            StudentInfoClass.Program = StudentInfoClass.GetProgram(cmbProgram.SelectedItem.ToString());
            StudentInfoClass.FirstName = StudentInfoClass.GetFirstName(txtFirstName.Text);
            StudentInfoClass.MiddleName = StudentInfoClass.GetMiddleName(txtMiddleName.Text);
            StudentInfoClass.LastName = StudentInfoClass.GetLastName(txtLastName.Text);
            StudentInfoClass.Age = StudentInfoClass.GetAge(long.Parse(txtAge.Text));
            StudentInfoClass.ContactNo = StudentInfoClass.GetContactNo(long.Parse(txtContactNo.Text));
            StudentInfoClass.Address = StudentInfoClass.GetAddress(txtAddress.Text);


            Form2 frmConfirm = new Form2();
            DialogResult result = frmConfirm.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbProgram.Items.Add("Bacherlor of Science Information Technology");
            cmbProgram.Items.Add("Bachelor of Science in Computer Engineering");
            cmbProgram.Items.Add(" Bachelor of Science in Computer Science");
            cmbProgram.Items.Add("Bachelor of Science in Civil Engineering");
            cmbProgram.Items.Add("Bachelor of Science in Hospitality Management");
            cmbProgram.Items.Add("Bachelor of Science in Business Administration");

            cmbProgram.SelectedIndex = -1;
        }
    }
}
