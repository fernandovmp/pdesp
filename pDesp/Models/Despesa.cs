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
    public class Despesa
    {
        public int IdDespesa { get; set; }
        public Membro Membro { get; set; }
        public TipoDespesa TipoDespesa { get; set; }
        public DateTime DataDespesa { get; set; }
        public double ValorDespesa { get; set; }
        public string ObservacaoDespesa { get; set; }

        public static DataTable Listar(SqlConnection conexao)
        {
            DataTable dtTipoDespesa = new DataTable();

            try
            {
                string query = "select DESPESA.ID_DESPESA, "
                    + "MEMBRO.ID_MEMBRO, "
                    + "MEMBRO.NOME_MEMBRO, "
                    + "TIPODESPESA.ID_TIPODESPESA, "
                    + "TIPODESPESA.NOME_TIPODESPESA, "
                    + "DESPESA.DATA_DESPESA, "
                    + "DESPESA.VALOR_DESPESA, "
                    + "DESPESA.OBS_DESPESA "
                    + "from DESPESA, TIPODESPESA, MEMBRO "
                    + "where DESPESA.TIPODESPESA_ID_TIPODESPESA = TIPODESPESA.ID_TIPODESPESA "
                    + "and DESPESA.MEMBRO_ID_MEMBRO = MEMBRO.ID_MEMBRO";

                using (var daTipoDespesa = new SqlDataAdapter(query, conexao))
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
                string query = "INSERT INTO DESPESA VALUES (@id_tipo_despesa, @id_membro, @data_despesa, @valor_despesa, @obs_despesa)";
                using (var mycommand = new SqlCommand(query, conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@id_tipo_despesa", SqlDbType.Int));
                    mycommand.Parameters["@id_tipo_despesa"].Value = TipoDespesa.IdTipoDespesa;
                    mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                    mycommand.Parameters["@id_membro"].Value = Membro.IdMembro;
                    mycommand.Parameters.Add(new SqlParameter("@data_despesa", SqlDbType.DateTime));
                    mycommand.Parameters["@data_despesa"].Value = DataDespesa;
                    mycommand.Parameters.Add(new SqlParameter("@valor_despesa", SqlDbType.Decimal));
                    mycommand.Parameters["@valor_despesa"].Value = ValorDespesa;
                    mycommand.Parameters.Add(new SqlParameter("@obs_despesa", SqlDbType.VarChar));
                    mycommand.Parameters["@obs_despesa"].Value = ObservacaoDespesa;

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

                string query = "UPDATE DESPESA SET " +
                    "TIPODESPESA_ID_TIPODESPESA = @id_tipo_despesa, " +
                    "MEMBRO_ID_MEMBRO = @id_membro, " +
                    "DATA_DESPESA = @data_despesa, " +
                    "VALOR_DESPESA = @valor_despesa, " +
                    "OBS_DESPESA = @obs_despesa " +
                    "WHERE ID_DESPESA = @id_despesa";
                using (var mycommand = new SqlCommand(query, conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                    mycommand.Parameters["@id_despesa"].Value = IdDespesa;
                    mycommand.Parameters.Add(new SqlParameter("@id_tipo_despesa", SqlDbType.Int));
                    mycommand.Parameters["@id_tipo_despesa"].Value = TipoDespesa.IdTipoDespesa;
                    mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                    mycommand.Parameters["@id_membro"].Value = Membro.IdMembro;
                    mycommand.Parameters.Add(new SqlParameter("@data_despesa", SqlDbType.DateTime));
                    mycommand.Parameters["@data_despesa"].Value = DataDespesa;
                    mycommand.Parameters.Add(new SqlParameter("@valor_despesa", SqlDbType.Decimal));
                    mycommand.Parameters["@valor_despesa"].Value = ValorDespesa;
                    mycommand.Parameters.Add(new SqlParameter("@obs_despesa", SqlDbType.VarChar));
                    mycommand.Parameters["@obs_despesa"].Value = ObservacaoDespesa;

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

                using (var mycommand = new SqlCommand("DELETE FROM DESPESA WHERE " +
                    "ID_DESPESA = @id_despesa",
                    conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                    mycommand.Parameters["@id_despesa"].Value = IdDespesa;
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
