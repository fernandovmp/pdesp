using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using pDesp.Models;

namespace pDesp.Views
{
    public partial class frmDespesa : Form
    {
        private readonly SqlConnection conexao;
        private readonly DataSet dsDespesa = new DataSet();
        private readonly BindingSource bnDespesa = new BindingSource();

        public frmDespesa(SqlConnection conexaoBd)
        {
            InitializeComponent();
            conexao = conexaoBd;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja sair?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (escolha.ToString() == "Yes")
            {
                Close();
            }
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            dsDespesa.Tables.Add(Despesa.Listar(conexao));
            bnDespesa.DataSource = dsDespesa.Tables["Table1"];
            dgvDespesas.DataSource = bnDespesa;
            bnvDespesas.BindingSource = bnDespesa;

            txtId.DataBindings.Add(nameof(txtId.Text), bnDespesa, "ID_DESPESA");
            txtObservacao.DataBindings.Add(nameof(txtObservacao.Text), bnDespesa, "OBS_DESPESA");
            txtValor.DataBindings.Add(nameof(txtValor.Text), bnDespesa, "VALOR_DESPESA");
            txtDataDespesa.DataBindings.Add(nameof(txtDataDespesa.Text), bnDespesa, "DATA_DESPESA");
            
            cbxMembro.DataSource = Membro.Listar(conexao);
            cbxMembro.DisplayMember = "NOME_MEMBRO";
            cbxMembro.ValueMember = "ID_MEMBRO";
            cbxMembro.DataBindings.Add(nameof(cbxMembro.SelectedValue), bnDespesa, "ID_MEMBRO");

            cbxTipoDespesa.DataSource = TipoDespesa.Listar(conexao);
            cbxTipoDespesa.DisplayMember = "NOME_TIPODESPESA";
            cbxTipoDespesa.ValueMember = "ID_TIPODESPESA";
            cbxTipoDespesa.DataBindings.Add(nameof(cbxTipoDespesa.SelectedValue), bnDespesa, "ID_TIPODESPESA");
            
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            bnDespesa.AddNew();
            txtValor.Enabled = true;
            txtObservacao.Enabled = true;
            cbxMembro.Enabled = true;
            cbxMembro.SelectedIndex = 0;
            cbxTipoDespesa.Enabled = true;
            cbxTipoDespesa.SelectedIndex = 0;
            txtDataDespesa.Enabled = true;
            txtValor.Focus();
            //btnSalvar.Enabled = true;
            //btnAlterar.Enabled = false;
            //btnNovoRegistro.Enabled = false;
            //btnExcluir.Enabled = false;
            //btnCancelar.Enabled = true;
            //bInclusao = true;
        }
    }
}
