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
    class Membro
    {
        private int idMembro;
        private string nomeMembro;
        private string papelMembro;

        public int IdMembro
        {
            get { return idMembro; }
            set { idMembro = value; }
        }

        public string NomeMembro
        {
            get { return nomeMembro; }
            set { nomeMembro = value; }
        }

        public string PapelMembro
        {
            get { return papelMembro; }
            set { papelMembro = value; }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daMembro;
            DataTable dtMembro = new DataTable();

            try
            {
                daMembro = new SqlDataAdapter("SELECT * FROM MEMBRO",
                    frmDesp.conexao);
                daMembro.Fill(dtMembro);
                daMembro.FillSchema(dtMembro, SchemaType.Source);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dtMembro;
        }

        public int Salvar()
        {
            int retorno = 0;
            
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO MEMBRO VALUES (@nome_membro, @papel_membro",
                    frmDesp.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_membro", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@papel_membro", SqlDbType.VarChar));

                mycommand.Parameters["@nome_membro"].Value = nomeMembro;
                mycommand.Parameters["@papel_membro"].Value = papelMembro;

                nReg = mycommand.ExecuteNonQuery();

                if(nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch(Exception ex)
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

                mycommand = new SqlCommand("UPDATE MEMBRO SET nome_membro = @nome_membro," +
                    " papel_membro = @papel_membro" +
                    " WHERE id_membro = @id_membro", frmDesp.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_membro", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@papel_membro", SqlDbType.VarChar));

                mycommand.Parameters["id_membro"].Value = idMembro;
                mycommand.Parameters["nome_membro"].Value = nomeMembro;
                mycommand.Parameters["papel_membro"].Value = papelMembro;

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

                mycommand = new SqlCommand("DELETE FROM MEMBRO WHERE " +
                    "id_membro = @id_membro", 
                    frmDesp.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));

                mycommand.Parameters["@id_membro"].Value = idMembro;

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
