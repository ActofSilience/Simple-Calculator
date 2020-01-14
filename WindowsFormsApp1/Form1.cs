using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(InputTextBox1.Text);
            int input2 = int.Parse(InputTextBox2.Text);
            MessageBox.Show("Thank you, " + NameTextBox.Text + ". Your total is " + (input1 + input2).ToString());
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(InputTextBox1.Text);
            int input2 = int.Parse(InputTextBox2.Text);
            MessageBox.Show("Thank you, " + NameTextBox.Text + ". Your total is " + (input1 - input2).ToString());
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(InputTextBox1.Text);
            int input2 = int.Parse(InputTextBox2.Text);


            MessageBox.Show("Thank you, " + NameTextBox.Text + ". Your total is " + (input1 * input2).ToString());
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(InputTextBox1.Text);
            int input2 = int.Parse(InputTextBox2.Text);
            MessageBox.Show("Thank you, " + NameTextBox.Text + ". Your total is " + (input1 / input2).ToString());
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            InputTextBox1.Text = "";
            InputTextBox2.Text = "";
            NameTextBox.Focus(); 
        }

        private void COSButton_Click(object sender, EventArgs e)
        {
            Name = NameTextBox.Text;
            int num1;
            num1 = Convert.ToInt32(InputTextBox1.Text);
            MessageBox.Show(" Thank you, " + Name + ". Your total is " + Math.Cos(num1).ToString());
            
        }

        private void SINButton_Click(object sender, EventArgs e)
        {
            Name = NameTextBox.Text;
            int num1;
            num1 = Convert.ToInt32(InputTextBox1.Text);
            MessageBox.Show("Thank you " + Name + ". Your total is " + Math.Sin(num1).ToString());
        }

        private void TANButton_Click(object sender, EventArgs e)
        {
            Name = NameTextBox.Text;
            int num1;
            num1 = Convert.ToInt32(InputTextBox1.Text);
            MessageBox.Show("Thank you " + Name + ". Your total is " + Math.Tan(num1).ToString());
        }

        private void MODULUSButton_Click(object sender, EventArgs e)
        {
            int input1 = int.Parse(InputTextBox1.Text);
            int input2 = int.Parse(InputTextBox2.Text);
            MessageBox.Show("Thank you, " + NameTextBox.Text + ". Your total is " + (input1 % input2).ToString());
        }
    }
}
