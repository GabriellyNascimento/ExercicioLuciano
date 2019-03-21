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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastrarDataSet);

        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastrarDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.cadastrarDataSet.Fornecedor);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            cidadeTextBox.Enabled = true;
            enderecoTextBox.Enabled = true;
            cnpjMaskedTextBox.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = new TelaInicial();
            form1.Show();
            Visible = false;
        }
    }
}
