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
        private bool bInclusao;
        private bool comboboxEhVazio;

        public frmDespesa(SqlConnection conexaoBd)
        {
            InitializeComponent();
            conexao = conexaoBd;
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
            dsDespesa.Tables.Add(Despesa.Listar(conexao));
            bnDespesa.DataSource = dsDespesa.Tables["Table1"];
            dgvDespesas.DataSource = bnDespesa;
            bnvDespesas.BindingSource = bnDespesa;

            txtId.DataBindings.Add("Text", bnDespesa, "ID_DESPESA");
            txtObservacao.DataBindings.Add("Text", bnDespesa, "OBS_DESPESA");
            txtValor.DataBindings.Add("Text", bnDespesa, "VALOR_DESPESA");
            txtDataDespesa.DataBindings.Add("Text", bnDespesa, "DATA_DESPESA");
            
            DataTable membros = Membro.Listar(conexao);

            cbxMembro.DataSource = membros;
            cbxMembro.DisplayMember = "NOME_MEMBRO";
            cbxMembro.ValueMember = "ID_MEMBRO";
            cbxMembro.DataBindings.Add("SelectedValue", bnDespesa, "ID_MEMBRO");

            DataTable tipoDespesas = TipoDespesa.Listar(conexao);

            cbxTipoDespesa.DataSource = tipoDespesas;
            cbxTipoDespesa.DisplayMember = "NOME_TIPODESPESA";
            cbxTipoDespesa.ValueMember = "ID_TIPODESPESA";
            cbxTipoDespesa.DataBindings.Add("SelectedValue", bnDespesa, "ID_TIPODESPESA");

            comboboxEhVazio = membros.Rows.Count == 0 || tipoDespesas.Rows.Count == 0;
            if(comboboxEhVazio)
            {
                MessageBox.Show("Vazio");
            }
        }

        private void AtualizarTabela()
        {
            dsDespesa.Tables.Clear();
            dsDespesa.Tables.Add(Despesa.Listar(conexao));
            bnDespesa.DataSource = dsDespesa.Tables["Table1"];
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            txtId.Enabled = false;
            txtValor.Enabled = false;
            txtObservacao.Enabled = false;
            txtDataDespesa.Enabled = false;
            cbxMembro.Enabled = false;
            cbxTipoDespesa.Enabled = false;
        }

        private void ResetarEstadoBotoes()
        {
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
            bInclusao = false;
        }

        private void HabilitarEdicao(bool adicao = false)
        {
            txtValor.Enabled = true;
            txtObservacao.Enabled = true;
            cbxMembro.Enabled = true;
            cbxTipoDespesa.Enabled = true;
            if(adicao && comboboxEhVazio)
            {
                cbxMembro.SelectedIndex = 0;
                cbxTipoDespesa.SelectedIndex = 0;
            }
            // 9, 2
            // 1000000000,00
            // 11111111111
            txtDataDespesa.Enabled = true;
            txtValor.Focus();
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = adicao;
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            bnDespesa.AddNew();
            HabilitarEdicao(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double d;
            DateTime date;
            if (txtValor.Text == "" || 
                !double.TryParse(txtValor.Text, out d) ||
                txtObservacao.Text == "" ||
                !DateTime.TryParse(txtDataDespesa.Text, out date)) 
                return;

            var despesa = new Despesa
            {
                IdDespesa = int.Parse(txtId.Text),
                ValorDespesa = double.Parse(txtValor.Text),
                ObservacaoDespesa = txtObservacao.Text,
                DataDespesa = DateTime.Parse(txtDataDespesa.Text),
                Membro = new Membro
                {
                    IdMembro = (int)cbxMembro.SelectedValue,
                    NomeMembro = cbxMembro.Text
                },
                TipoDespesa = new TipoDespesa
                {
                    IdTipoDespesa = (int)cbxTipoDespesa.SelectedValue,
                    NomeTipoDespesa = cbxTipoDespesa.Text
                }
            };

            if (bInclusao)
            {
                if (despesa.Salvar(conexao) > 0)
                {
                    MessageBox.Show("Despesa adicionada com sucesso!");
                    DesabilitarCampos();
                    ResetarEstadoBotoes();

                    AtualizarTabela();
                    return;
                }
                MessageBox.Show("Erro ao gravar despesa");
                return;
            }

            if (despesa.Alterar(conexao) > 0)
            {
                AtualizarTabela();
                MessageBox.Show("Despesa alterada com sucesso!");
                DesabilitarCampos();
                ResetarEstadoBotoes();
                return;
            }
            MessageBox.Show("Erro ao gravar despesa");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            HabilitarEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnDespesa.CancelEdit();
            DesabilitarCampos();
            ResetarEstadoBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Exlusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                var despesa = new Despesa
                {
                    IdDespesa = int.Parse(txtId.Text),
                    ValorDespesa = double.Parse(txtValor.Text),
                    ObservacaoDespesa = txtObservacao.Text,
                    DataDespesa = DateTime.Parse(txtDataDespesa.Text),
                    Membro = new Membro
                    {
                        IdMembro = (int) cbxMembro.SelectedValue,
                        NomeMembro = cbxMembro.Text
                    },
                    TipoDespesa = new TipoDespesa
                    {
                        IdTipoDespesa = (int) cbxTipoDespesa.SelectedValue,
                        NomeTipoDespesa = cbxTipoDespesa.Text
                    }
                };
                if (despesa.Excluir(conexao) > 0)
                {
                    MessageBox.Show("Despesa excluída com sucesso!");
                    AtualizarTabela();
                    return;
                }

                MessageBox.Show("Erro ao excluir despesa!");

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja sair?", "Despesa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (escolha.ToString() == "Yes")
            {
                Close();
            }
        }
    }
}
