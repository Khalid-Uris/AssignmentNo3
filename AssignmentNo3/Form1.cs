using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentNo3
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

        private void Add_Click(object sender, EventArgs e)
        {
            Calculator.ArithmaticOperation obj1 = new Calculator.ArithmaticOperation();

            textBox3.Text = obj1.sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)) + "";

            //textBox6.Text = obj.Sub(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text)) + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator.ArithmaticOperation obj2 = new Calculator.ArithmaticOperation();

            textBox6.Text = obj2.subtract(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text)) + "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculator.ArithmaticOperation obj3 = new Calculator.ArithmaticOperation();

            textBox9.Text = obj3.multiplication(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text)) + "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculator.ArithmaticOperation obj4 = new Calculator.ArithmaticOperation();

            textBox12.Text = obj4.divide(Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text)) + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator.LogicalOperation obj5 = new Calculator.LogicalOperation();

            textBox15.Text = obj5.AND(Convert.ToBoolean(textBox13.Text), Convert.ToBoolean(textBox14.Text)) + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculator.LogicalOperation obj6 = new Calculator.LogicalOperation();

            textBox18.Text = obj6.OR(Convert.ToBoolean(textBox16.Text), Convert.ToBoolean(textBox17.Text)) + "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calculator.LogicalOperation obj7 = new Calculator.LogicalOperation();

            textBox21.Text = obj7.NOT(Convert.ToBoolean(textBox19.Text), Convert.ToBoolean(textBox20.Text)) + "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calculator.Temperature_Converter obj8 = new Calculator.Temperature_Converter();

            textBox23.Text = obj8.temperature(Convert.ToDouble(textBox22.Text)) + "";
        }
    }
}
