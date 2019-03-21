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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastrarDataSet);

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastrarDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.cadastrarDataSet.Cliente);

        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            idadeMaskedTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
            cepMaskedTextBox.Enabled = true;
            casadoCheckBox.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = new TelaInicial();
            form1.Show();
            Visible = false;
        }
    }
}
