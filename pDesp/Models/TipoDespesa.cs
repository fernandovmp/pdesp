using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace pDesp.Models
{
    public class TipoDespesa
    {
        public int IdTipoDespesa { get; set; }
        public string NomeTipoDespesa { get; set; }

        public static DataTable Listar(SqlConnection conexao)
        {
            DataTable dtTipoDespesa = new DataTable();

            try
            {
                using (var daTipoDespesa = new SqlDataAdapter("SELECT * FROM TIPODESPESA",
                    conexao))
                {
                    daTipoDespesa.Fill(dtTipoDespesa);
                    daTipoDespesa.FillSchema(dtTipoDespesa, SchemaType.Source);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtTipoDespesa;
        }

        public int Salvar(SqlConnection conexao)
        {
            try
            {
                int nReg;

                using (var mycommand = new SqlCommand("INSERT INTO TIPODESPESA VALUES (@nome_tipodespesa)",
                    conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));
                    mycommand.Parameters["@nome_tipodespesa"].Value = NomeTipoDespesa;
                    nReg = mycommand.ExecuteNonQuery();

                    if (nReg > 0)
                    {
                        return nReg;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }

        public int Alterar(SqlConnection conexao)
        {
            try
            {
                int nReg = 0;

                using (var mycommand = new SqlCommand("UPDATE TIPODESPESA SET NOME_TIPODESPESA = @nome_tipodespesa" +
                    " WHERE ID_TIPODESPESA = @id_tipodespesa", conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));
                    mycommand.Parameters.Add(new SqlParameter("@nome_tipodespesa", SqlDbType.VarChar));

                    mycommand.Parameters["@id_tipodespesa"].Value = IdTipoDespesa;
                    mycommand.Parameters["@nome_tipodespesa"].Value = NomeTipoDespesa;

                    nReg = mycommand.ExecuteNonQuery();

                    if (nReg > 0)
                    {
                        return nReg;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }

        public int Excluir(SqlConnection conexao)
        {
            try
            {
                int nReg = 0;

                using (var mycommand = new SqlCommand("DELETE FROM TIPODESPESA WHERE " +
                    "ID_TIPODESPESA = @id_tipodespesa",
                    conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));
                    mycommand.Parameters["@id_tipodespesa"].Value = IdTipoDespesa;
                    nReg = mycommand.ExecuteNonQuery();
                    if (nReg > 0)
                    {
                        return nReg;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }
    }
}
