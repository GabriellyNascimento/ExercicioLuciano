namespace Exercicio4
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label casadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label idadeLabel;
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastrarDataSet = new Exercicio4.cadastrarDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.casadoCheckBox = new System.Windows.Forms.CheckBox();
            this.clienteTableAdapter = new Exercicio4.cadastrarDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Exercicio4.cadastrarDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idadeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            casadoLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(47, 85);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(47, 137);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 8;
            enderecoLabel.Text = "Endereco:";
            // 
            // casadoLabel
            // 
            casadoLabel.AutoSize = true;
            casadoLabel.Location = new System.Drawing.Point(47, 191);
            casadoLabel.Name = "casadoLabel";
            casadoLabel.Size = new System.Drawing.Size(46, 13);
            casadoLabel.TabIndex = 12;
            casadoLabel.Text = "Casado:";
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(936, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.cadastrarDataSet;
            // 
            // cadastrarDataSet
            // 
            this.cadastrarDataSet.DataSetName = "cadastrarDataSet";
            this.cadastrarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(288, 28);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(628, 186);
            this.clienteDataGridView.TabIndex = 1;
            this.clienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Idade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Idade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cep";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cep";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Casado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Casado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(109, 82);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(104, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.enderecoTextBox.Enabled = false;
            this.enderecoTextBox.Location = new System.Drawing.Point(109, 134);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(104, 20);
            this.enderecoTextBox.TabIndex = 9;
            // 
            // casadoCheckBox
            // 
            this.casadoCheckBox.Checked = true;
            this.casadoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.casadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clienteBindingSource, "Casado", true));
            this.casadoCheckBox.Enabled = false;
            this.casadoCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.casadoCheckBox.Location = new System.Drawing.Point(109, 186);
            this.casadoCheckBox.Name = "casadoCheckBox";
            this.casadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.casadoCheckBox.TabIndex = 13;
            this.casadoCheckBox.Text = "SIM";
            this.casadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Exercicio4.cadastrarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "CADASTRO DE CLIENTES";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(47, 163);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(29, 13);
            cepLabel.TabIndex = 20;
            cepLabel.Text = "Cep:";
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cep", true));
            this.cepMaskedTextBox.Enabled = false;
            this.cepMaskedTextBox.Location = new System.Drawing.Point(109, 160);
            this.cepMaskedTextBox.Mask = "#####-###";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(59, 20);
            this.cepMaskedTextBox.TabIndex = 21;
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Location = new System.Drawing.Point(48, 114);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(37, 13);
            idadeLabel.TabIndex = 21;
            idadeLabel.Text = "Idade:";
            // 
            // idadeMaskedTextBox
            // 
            this.idadeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Idade", true));
            this.idadeMaskedTextBox.Enabled = false;
            this.idadeMaskedTextBox.Location = new System.Drawing.Point(109, 108);
            this.idadeMaskedTextBox.Mask = "##";
            this.idadeMaskedTextBox.Name = "idadeMaskedTextBox";
            this.idadeMaskedTextBox.Size = new System.Drawing.Size(22, 20);
            this.idadeMaskedTextBox.TabIndex = 22;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(this.idadeMaskedTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepMaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(casadoLabel);
            this.Controls.Add(this.casadoCheckBox);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastrarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastrarDataSet cadastrarDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private cadastrarDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private cadastrarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.CheckBox casadoCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox idadeMaskedTextBox;
    }
}