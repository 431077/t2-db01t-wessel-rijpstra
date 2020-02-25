using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studenten_cijfers
{
    public partial class Form1 : Form
    {
        List<int> Cijfers = new List<int>();
        int Minimum = 11;
        int maximum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alles = 0;
            listBox1.Items.Clear();
            Cijfers.Add(Convert.ToInt32(numericUpDown2.Value));
            foreach (int nummer in Cijfers)
            {
                listBox1.Items.Add(nummer);
                if (nummer < Minimum)
                {
                    Minimum = nummer;
                    label6.Text = Convert.ToString(nummer);
                }
                if (nummer > maximum)
                {
                    maximum = nummer;
                    label10.Text = Convert.ToString(nummer);
                }

                alles = alles + nummer;
                int gem = alles / Cijfers.Count();

                label9.Text = Convert.ToString(gem);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int nummer in Cijfers)
            {
                if (nummer == numericUpDown1.Value)
                {
                    count++;
                    label4.Text = Convert.ToString(count);
                }
            }
        }
    }
}
