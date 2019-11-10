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

namespace pDesp
{
    public partial class frmDesp : Form
    {
        public static SqlConnection conexao;

        public frmDesp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2;User ID=BD1911014;Password=Senhaestranha12");
                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros erros: " + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja sair?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (escolha.ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
