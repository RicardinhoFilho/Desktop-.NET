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

      
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_usuario.Text.Equals("03411614030")  
                    && txt_senha.Text.Equals("teste"))
                {
                    var menu = new MenuRestrito();
                    menu.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Senha ou Usuario invalido!",
                   "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_usuario.Focus();
                    txt_senha.Text = "";
                }
            }catch(Exception error)
            {
                MessageBox.Show(error.Message,
                    "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Somente numeros sao aceitos neste campo!",
                     "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
