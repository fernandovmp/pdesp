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

            txtId.DataBindings.Add(nameof(txtId.Text), bnMembro, "ID_MEMBRO");
            txtNomeMembro.DataBindings.Add(nameof(txtNomeMembro.Text), bnMembro, "NOME_MEMBRO");
            txtPapelMembro.DataBindings.Add(nameof(txtPapelMembro.Text), bnMembro, "PAPEL_MEMBRO");
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            bnMembro.AddNew();
            txtNomeMembro.Enabled = true;
            txtPapelMembro.Enabled = true;
            txtNomeMembro.Focus();
            //btnSalvar.Enabled = true;
            //btnAlterar.Enabled = false;
            //btnNovoRegistro.Enabled = false;
            //btnExcluir.Enabled = false;
            //btnCancelar.Enabled = true;
            //bInclusao = true;
        }
    }
}
