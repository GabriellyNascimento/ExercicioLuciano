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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Cliente")
            {
                Cliente cliente = new Cliente();
                cliente.Show();
                Visible = false;
            }
            if(comboBox1.Text == "Fornecedor")
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Show();
                Visible = false;
            }
            if(comboBox1.Text == "Funcionario")
            {
                Login login = new Login();
                login.Show();
                Visible = false;
            }
        }
    }
}
