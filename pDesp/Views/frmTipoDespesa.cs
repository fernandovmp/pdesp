using pDesp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pDesp.Views
{
    public partial class frmTipoDespesa : Form
    {
        private readonly SqlConnection conexao;
        private readonly DataSet dsTipoDespesa = new DataSet();
        private readonly BindingSource bnTipoDespesa = new BindingSource();
        private bool bInclusao;

        public frmTipoDespesa(SqlConnection conexaoBd)
        {
            InitializeComponent();
            conexao = conexaoBd;
        }

        private void frmMembro_Load(object sender, EventArgs e)
        {
            dsTipoDespesa.Tables.Add(TipoDespesa.Listar(conexao));
            bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];
            dgvTipoDespesa.DataSource = bnTipoDespesa;
            bnvTipoDespesa.BindingSource = bnTipoDespesa;

            txtId.DataBindings.Add("Text", bnTipoDespesa, "ID_TIPODESPESA");
            txtNomeTipoDespesa.DataBindings.Add("Text", bnTipoDespesa, "NOME_TIPODESPESA");
        }

        private void AtualizarTabela()
        {
            dsTipoDespesa.Tables.Clear();
            dsTipoDespesa.Tables.Add(TipoDespesa.Listar(conexao));
            bnTipoDespesa.DataSource = dsTipoDespesa.Tables["TIPODESPESA"];
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            txtId.Enabled = false;
            txtNomeTipoDespesa.Enabled = false;
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
            txtNomeTipoDespesa.Enabled = true;
            txtNomeTipoDespesa.Focus();
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
            bnTipoDespesa.AddNew();
            HabilitarEdicao(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeTipoDespesa.Text == "") return;

            var tipoDespesa = new TipoDespesa
            {
                IdTipoDespesa = int.Parse(txtId.Text),
                NomeTipoDespesa = txtNomeTipoDespesa.Text,
            };

            if(bInclusao)
            {
                if(tipoDespesa.Salvar(conexao) > 0)
                {
                    MessageBox.Show("Tipo de despesa adicionada com sucesso!");
                    DesabilitarCampos();
                    ResetarEstadoBotoes();

                    AtualizarTabela();
                    return;
                }
                MessageBox.Show("Erro ao gravar tipo de despesa");
                return;
            }
            
            if(tipoDespesa.Alterar(conexao) > 0)
            {
                //AtualizarTabela();
                MessageBox.Show("Tipo de despesa alterada com sucesso!");
                DesabilitarCampos();
                ResetarEstadoBotoes();
                return;
            }
            MessageBox.Show("Erro ao gravar tipo de despesa");
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
            bnTipoDespesa.CancelEdit();
            DesabilitarCampos();
            ResetarEstadoBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                var tipoDespesa = new TipoDespesa
                {
                    IdTipoDespesa = int.Parse(txtId.Text),
                    NomeTipoDespesa = txtNomeTipoDespesa.Text,
                };
                if (tipoDespesa.Excluir(conexao) > 0)
                {
                    MessageBox.Show("Tipo de despesa excluído com sucesso!");

                    AtualizarTabela();
                    return;
                }

                MessageBox.Show("Erro ao excluir tipo de despesa!");
                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja sair?", "Tipo Despesa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (escolha.ToString() == "Yes")
            {
                Close();
            }
        }
    }
}
