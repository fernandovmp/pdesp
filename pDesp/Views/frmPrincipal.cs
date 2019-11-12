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
    public partial class frmPrincipal : Form
    {
        public const string STRING_CONEXAO = "Data Source=Apolo;Initial Catalog=LP2;User ID=BD1911005;Password=cmpVrau22";
        //public const string STRING_CONEXAO = "Data Source=ZERO\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True";
        public static SqlConnection Conexao { get; private set; }

        public frmPrincipal()
        {
            InitializeComponent();
            AbrirConexao();
        }

        private void AbrirConexao()
        {
            try
            {
                Conexao = new SqlConnection(STRING_CONEXAO);
                Conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros: " + ex.Message);
            }
        }


        private void tipoDeDespesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTipoDespesa(Conexao).Show();
        }

        private void membroFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMembro(Conexao).Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDespesa(Conexao).Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSobre().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja sair?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (escolha.ToString() == "Yes")
            {
                Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
