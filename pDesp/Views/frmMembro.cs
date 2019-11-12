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
    public partial class frmMembro : Form
    {
        private readonly SqlConnection conexao;
        private readonly DataSet dsMembro = new DataSet();
        private readonly BindingSource bnMembro = new BindingSource();
        private bool bInclusao;

        public frmMembro(SqlConnection conexaoBd)
        {
            InitializeComponent();
            conexao = conexaoBd;
        }

        private void frmMembro_Load(object sender, EventArgs e)
        {
            dsMembro.Tables.Add(Membro.Listar(conexao));
            bnMembro.DataSource = dsMembro.Tables["MEMBRO"];
            dgvMembros.DataSource = bnMembro;
            bnvMembros.BindingSource = bnMembro;

            txtId.DataBindings.Add("Text", bnMembro, "ID_MEMBRO");
            txtNomeMembro.DataBindings.Add("Text", bnMembro, "NOME_MEMBRO");
            txtPapelMembro.DataBindings.Add("Text", bnMembro, "PAPEL_MEMBRO");
        }

        private void AtualizarTabela()
        {
            dsMembro.Tables.Clear();
            dsMembro.Tables.Add(Membro.Listar(conexao));
            bnMembro.DataSource = dsMembro.Tables["MEMBRO"];
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            txtId.Enabled = false;
            txtNomeMembro.Enabled = false;
            txtPapelMembro.Enabled = false;
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
            txtNomeMembro.Enabled = true;
            txtPapelMembro.Enabled = true;
            txtNomeMembro.Focus();
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
            bnMembro.AddNew();
            HabilitarEdicao(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeMembro.Text == "" || txtPapelMembro.Text == "") return;

            var membro = new Membro
            {
                IdMembro = int.Parse(txtId.Text),
                NomeMembro = txtNomeMembro.Text,
                PapelMembro = txtPapelMembro.Text
            };

            if(bInclusao)
            {
                if(membro.Salvar(conexao) > 0)
                {
                    MessageBox.Show("Membro da família adicionado com sucesso!");
                    DesabilitarCampos();
                    ResetarEstadoBotoes();

                    AtualizarTabela();
                    return;
                }
                MessageBox.Show("Erro ao gravar membro da família");
                return;
            }
            
            if(membro.Alterar(conexao) > 0)
            {
                //AtualizarTabela();
                MessageBox.Show("Membro da família alterado com sucesso!");
                DesabilitarCampos();
                ResetarEstadoBotoes();
                return;
            }
            MessageBox.Show("Erro ao gravar membro da família");
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
            bnMembro.CancelEdit();
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
                var membro = new Membro
                {
                    IdMembro = int.Parse(txtId.Text),
                    NomeMembro = txtNomeMembro.Text,
                    PapelMembro = txtPapelMembro.Text
                };
                if (membro.Excluir(conexao) > 0)
                {
                    MessageBox.Show("Membro excluído com sucesso!");

                    AtualizarTabela();
                    return;
                }

                MessageBox.Show("Erro ao excluir membro!");
                
            }
        }
    }
}
