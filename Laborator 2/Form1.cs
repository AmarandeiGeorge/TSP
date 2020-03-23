using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_lab_2
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
        private void button14_Click(object sender, EventArgs e)
        { Button x = (Button)sender;
            textBox1.Text += x.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void OperandClick(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                char last = textBox1.Text[textBox1.Text.Length - 1];
                Button x = (Button)sender;
                if (!"+-*/".Contains(last))
                    textBox1.Text += x.Text;
            }
            

        }

        private void CalcResult(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(new DataTable().Compute(textBox1.Text, null));
            textBox1.Text = result.ToString();
        }
    }
}
