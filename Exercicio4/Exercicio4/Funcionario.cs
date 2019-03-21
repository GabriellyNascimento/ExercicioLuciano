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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastrarDataSet);

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastrarDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.cadastrarDataSet.Funcionario);

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            loginTextBox.Enabled = true;
            senhaTextBox.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }
    }
}
