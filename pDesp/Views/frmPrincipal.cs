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
        //public const string STRING_CONEXAO = "Data Source=Apolo;Initial Catalog=LP2;User ID=BD1911014;Password=Senhaestranha12";
        public const string STRING_CONEXAO = "Data Source=ZERO\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True";
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

        private void button1_Click(object sender, EventArgs e)
        {
            new frmMembro(Conexao).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmDespesa(Conexao).Show();
        }
    }
}
