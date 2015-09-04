using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorNum;



namespace CalculatorWFA
{
    public partial class CalculatorNumbers : Form
    {
        
        public Calculator instanse = new Calculator();
        public CalculatorNumbers()
        {
            InitializeComponent();
        }

        private void MulNumberButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = (double.Parse(FirstNumberTextBox.Text) * double.Parse(SecondNumberTextBox.Text)).ToString();
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
        }

        private void FirstNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNumberButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = (double.Parse(FirstNumberTextBox.Text) + double.Parse(SecondNumberTextBox.Text)).ToString();
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
        }

        private void SubNumberButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = (double.Parse(FirstNumberTextBox.Text) - double.Parse(SecondNumberTextBox.Text)).ToString();
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
        }

        private void DivNumberButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = (double.Parse(FirstNumberTextBox.Text) / double.Parse(SecondNumberTextBox.Text)).ToString();
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
        }

    }
}
