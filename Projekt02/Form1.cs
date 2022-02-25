using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            MessageBox.Show("Součet je " + (a + b));
            MessageBox.Show("Rozdil je " + (a - b));
            MessageBox.Show("Soucin je " + (a * b));
            MessageBox.Show("Podil je " + (a / b));

            MessageBox.Show("Prace ukoncena");
        }
    }
}
