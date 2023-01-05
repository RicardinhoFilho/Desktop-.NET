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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Vamos estudar C#?", "Título", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Você digitou SIM");
            }
            else
            {
                MessageBox.Show("Você digitou NÃO!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouviu o som?", "Alerta Critico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerta Simples");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerta Simples com título", "Título aqui!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Vamos estudar C#?", "Título", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Você digitou SIM");
            }
            else if(retorno == DialogResult.No)
            {
                MessageBox.Show("Você digitou NÃO!");
            }
        }
    }
}
