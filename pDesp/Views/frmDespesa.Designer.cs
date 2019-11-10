namespace pDesp.Views
{
    partial class frmDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesa));
            this.bnvDespesas = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.paginaDados = new System.Windows.Forms.TabPage();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.paginaDetalhes = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDataDespesa = new System.Windows.Forms.Label();
            this.cbxTipoDespesa = new System.Windows.Forms.ComboBox();
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.cbxMembro = new System.Windows.Forms.ComboBox();
            this.lblMembro = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtDataDespesa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesas)).BeginInit();
            this.bnvDespesas.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.paginaDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.paginaDetalhes.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvDespesas
            // 
            this.bnvDespesas.AddNewItem = null;
            this.bnvDespesas.CountItem = this.bindingNavigatorCountItem;
            this.bnvDespesas.DeleteItem = null;
            this.bnvDespesas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovoRegistro,
            this.bindingNavigatorDeleteItem});
            this.bnvDespesas.Location = new System.Drawing.Point(0, 0);
            this.bnvDespesas.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvDespesas.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvDespesas.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvDespesas.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvDespesas.Name = "bnvDespesas";
            this.bnvDespesas.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvDespesas.Size = new System.Drawing.Size(800, 25);
            this.bnvDespesas.TabIndex = 3;
            this.bnvDespesas.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoRegistro.Image")));
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.RightToLeftAutoMirrorImage = true;
            this.btnNovoRegistro.Size = new System.Drawing.Size(23, 22);
            this.btnNovoRegistro.Text = "Adicionar novo";
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.paginaDados);
            this.tabControl1.Controls.Add(this.paginaDetalhes);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 271);
            this.tabControl1.TabIndex = 4;
            // 
            // paginaDados
            // 
            this.paginaDados.Controls.Add(this.dgvDespesas);
            this.paginaDados.Location = new System.Drawing.Point(4, 22);
            this.paginaDados.Name = "paginaDados";
            this.paginaDados.Padding = new System.Windows.Forms.Padding(3);
            this.paginaDados.Size = new System.Drawing.Size(792, 245);
            this.paginaDados.TabIndex = 0;
            this.paginaDados.Text = "Dados";
            this.paginaDados.UseVisualStyleBackColor = true;
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Location = new System.Drawing.Point(0, 0);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.Size = new System.Drawing.Size(792, 245);
            this.dgvDespesas.TabIndex = 0;
            // 
            // paginaDetalhes
            // 
            this.paginaDetalhes.Controls.Add(this.lblDataDespesa);
            this.paginaDetalhes.Controls.Add(this.txtDataDespesa);
            this.paginaDetalhes.Controls.Add(this.txtId);
            this.paginaDetalhes.Controls.Add(this.lblId);
            this.paginaDetalhes.Controls.Add(this.cbxTipoDespesa);
            this.paginaDetalhes.Controls.Add(this.lblTipoDespesa);
            this.paginaDetalhes.Controls.Add(this.cbxMembro);
            this.paginaDetalhes.Controls.Add(this.lblMembro);
            this.paginaDetalhes.Controls.Add(this.lblValor);
            this.paginaDetalhes.Controls.Add(this.txtValor);
            this.paginaDetalhes.Controls.Add(this.lblObservacao);
            this.paginaDetalhes.Controls.Add(this.txtObservacao);
            this.paginaDetalhes.Location = new System.Drawing.Point(4, 22);
            this.paginaDetalhes.Name = "paginaDetalhes";
            this.paginaDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.paginaDetalhes.Size = new System.Drawing.Size(792, 245);
            this.paginaDetalhes.TabIndex = 1;
            this.paginaDetalhes.Text = "Detalhes";
            this.paginaDetalhes.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(60, 9);
            this.txtId.MaxLength = 1000;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(173, 20);
            this.txtId.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(35, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID";
            // 
            // lblDataDespesa
            // 
            this.lblDataDespesa.AutoSize = true;
            this.lblDataDespesa.Location = new System.Drawing.Point(17, 132);
            this.lblDataDespesa.Name = "lblDataDespesa";
            this.lblDataDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblDataDespesa.TabIndex = 9;
            this.lblDataDespesa.Text = "Data da despesa";
            // 
            // cbxTipoDespesa
            // 
            this.cbxTipoDespesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDespesa.Enabled = false;
            this.cbxTipoDespesa.FormattingEnabled = true;
            this.cbxTipoDespesa.Location = new System.Drawing.Point(432, 37);
            this.cbxTipoDespesa.Name = "cbxTipoDespesa";
            this.cbxTipoDespesa.Size = new System.Drawing.Size(239, 21);
            this.cbxTipoDespesa.TabIndex = 7;
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(340, 40);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(86, 13);
            this.lblTipoDespesa.TabIndex = 6;
            this.lblTipoDespesa.Text = "Tipo de despesa";
            // 
            // cbxMembro
            // 
            this.cbxMembro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMembro.Enabled = false;
            this.cbxMembro.FormattingEnabled = true;
            this.cbxMembro.Location = new System.Drawing.Point(60, 37);
            this.cbxMembro.Name = "cbxMembro";
            this.cbxMembro.Size = new System.Drawing.Size(239, 21);
            this.cbxMembro.TabIndex = 5;
            // 
            // lblMembro
            // 
            this.lblMembro.AutoSize = true;
            this.lblMembro.Location = new System.Drawing.Point(8, 40);
            this.lblMembro.Name = "lblMembro";
            this.lblMembro.Size = new System.Drawing.Size(45, 13);
            this.lblMembro.TabIndex = 4;
            this.lblMembro.Text = "Membro";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(17, 66);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(89, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor da despesa";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(8, 78);
            this.txtValor.MaxLength = 1000;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(173, 20);
            this.txtValor.TabIndex = 2;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(208, 66);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 1;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(199, 78);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(291, 20);
            this.txtObservacao.TabIndex = 0;
            // 
            // txtDataDespesa
            // 
            this.txtDataDespesa.Enabled = false;
            this.txtDataDespesa.Location = new System.Drawing.Point(8, 144);
            this.txtDataDespesa.MaxLength = 1000;
            this.txtDataDespesa.Name = "txtDataDespesa";
            this.txtDataDespesa.Size = new System.Drawing.Size(173, 20);
            this.txtDataDespesa.TabIndex = 12;
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnvDespesas);
            this.MaximizeBox = false;
            this.Name = "frmDespesa";
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.frmDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvDespesas)).EndInit();
            this.bnvDespesas.ResumeLayout(false);
            this.bnvDespesas.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.paginaDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.paginaDetalhes.ResumeLayout(false);
            this.paginaDetalhes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvDespesas;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovoRegistro;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage paginaDados;
        private System.Windows.Forms.TabPage paginaDetalhes;
        private System.Windows.Forms.ComboBox cbxMembro;
        private System.Windows.Forms.Label lblMembro;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblDataDespesa;
        private System.Windows.Forms.ComboBox cbxTipoDespesa;
        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.TextBox txtDataDespesa;
    }
}

