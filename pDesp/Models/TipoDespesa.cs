using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace pDesp
{
    class TipoDespesa
    {
        private int idTipoDespesa;
        private string nomeTipoDespesa;

        public int IdTipoDespesa
        {
            get { return idTipoDespesa; }
            set { idTipoDespesa = value; }
        }

        public string NomeTipoDespesa
        {
            get { return nomeTipoDespesa; }
            set { nomeTipoDespesa = value; }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daTipoDespesa;
            DataTable dtTipoDespesa = new DataTable();

            try
            {
                daTipoDespesa = new SqlDataAdapter("SELECT * FROM TIPODESPESA",
                    frmDesp.conexao);
                daTipoDespesa.Fill(dtTipoDespesa);
                daTipoDespesa.FillSchema(dtTipoDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtTipoDespesa;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TIPODESPESA VALUES (@nome_tipodespesa",
                    frmDesp.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));

                mycommand.Parameters["@nome_tipodespesa"].Value = nomeTipoDespesa;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;

                mycommand = new SqlCommand("UPDATE TIPODESPESA SET nome_tipodespesa = @nome_tipodespesa," +
                    " WHERE id_tipodespesa = @id_tipodespesa", frmDesp.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));

                mycommand.Parameters["id_tipodespesa"].Value = idTipoDespesa;
                mycommand.Parameters["nome_tipodespesa"].Value = nomeTipoDespesa;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Excluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;

                mycommand = new SqlCommand("DELETE FROM TIPODESPESA WHERE " +
                    "id_tipodespesa = @id_tipodespesa",
                    frmDesp.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));

                mycommand.Parameters["@id_tipodespesa"].Value = idTipoDespesa;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
    }
}
