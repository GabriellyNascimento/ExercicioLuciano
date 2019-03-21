using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "XPS" && textBox2.Text == "SPX123")
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = new TelaInicial();
            form1.Show();
            Visible = false;
        }
    }
}
