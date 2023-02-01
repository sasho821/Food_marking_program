using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_marking_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0, y = 0; // Поменяй потом на конкретные значения

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Program.data.Cells[118,1].Value.ToString();
            label2.Text = Math.Round(decimal.Parse(Program.data.Cells[118, 3].Value.ToString()),2).ToString();

            label4.Text = Program.data.Cells[124, 1].Value.ToString();
            label3.Text = Math.Round(decimal.Parse(Program.data.Cells[124, 3].Value.ToString()), 2).ToString();

            label6.Text = Program.data.Cells[127, 1].Value.ToString();
            label5.Text = Math.Round(decimal.Parse(Program.data.Cells[127, 3].Value.ToString()), 2).ToString();

            label8.Text = Program.data.Cells[131, 1].Value.ToString();
            label7.Text = Math.Round(decimal.Parse(Program.data.Cells[131, 3].Value.ToString()), 2).ToString();

            label10.Text = Program.data.Cells[133, 1].Value.ToString();
            label9.Text = Math.Round(decimal.Parse(Program.data.Cells[133, 3].Value.ToString()), 2).ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("It is working");
            BackgroundImage = Food_marking_program.Properties.Resources.background2;
            Label[] labels = {label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12};

            numericUpDown1.Visible = true;

            foreach(var item in labels)
            {
                item.Visible = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int buff = Int32.Parse(numericUpDown1.Value.ToString());
            buff -= 2016;

            label1.Text = Program.data.Cells[118, 1].Value.ToString();
            label2.Text = Math.Round(decimal.Parse(Program.data.Cells[118, 3+buff].Value.ToString()), 2).ToString();

            label4.Text = Program.data.Cells[124, 1].Value.ToString();
            label3.Text = Math.Round(decimal.Parse(Program.data.Cells[124, 3 + buff].Value.ToString()), 2).ToString();

            label6.Text = Program.data.Cells[127, 1].Value.ToString();
            label5.Text = Math.Round(decimal.Parse(Program.data.Cells[127, 3 + buff].Value.ToString()), 2).ToString();

            label8.Text = Program.data.Cells[131, 1].Value.ToString();
            label7.Text = Math.Round(decimal.Parse(Program.data.Cells[131, 3 + buff].Value.ToString()), 2).ToString();

            label10.Text = Program.data.Cells[133, 1].Value.ToString();
            label9.Text = Math.Round(decimal.Parse(Program.data.Cells[133, 3 + buff].Value.ToString()), 2).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
