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
    public class Membro
    {
        public int IdMembro { get; set; }
        public string NomeMembro { get; set; }
        public string PapelMembro { get; set; }

        public static DataTable Listar(SqlConnection conexao)
        {
            SqlDataAdapter daMembro;
            DataTable dtMembro = new DataTable();

            try
            {
                using (daMembro = new SqlDataAdapter("SELECT * FROM MEMBRO",
                    conexao))
                {
                    daMembro.Fill(dtMembro);
                    daMembro.FillSchema(dtMembro, SchemaType.Source);
                    return dtMembro;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int Salvar(SqlConnection conexao)
        {
            try
            {
                int nReg;

                using (var mycommand = new SqlCommand("INSERT INTO MEMBRO VALUES (@nome_membro, @papel_membro)",
                    conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@nome_membro", SqlDbType.VarChar));
                    mycommand.Parameters.Add(new SqlParameter("@papel_membro", SqlDbType.VarChar));

                    mycommand.Parameters["@nome_membro"].Value = NomeMembro;
                    mycommand.Parameters["@papel_membro"].Value = PapelMembro;

                    nReg = mycommand.ExecuteNonQuery();

                    if (nReg > 0)
                    {
                        return nReg;
                    }
                }
            }
            catch(Exception ex)
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

                using (var mycommand = new SqlCommand("UPDATE MEMBRO SET NOME_MEMBRO = @nome_membro," +
                    " PAPEL_MEMBRO = @papel_membro" +
                    " WHERE ID_MEMBRO = @id_membro", conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                    mycommand.Parameters.Add(new SqlParameter("@nome_membro", SqlDbType.VarChar));
                    mycommand.Parameters.Add(new SqlParameter("@papel_membro", SqlDbType.VarChar));

                    mycommand.Parameters["@id_membro"].Value = IdMembro;
                    mycommand.Parameters["@nome_membro"].Value = NomeMembro;
                    mycommand.Parameters["@papel_membro"].Value = PapelMembro;

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
                using (var mycommand = new SqlCommand("DELETE FROM MEMBRO WHERE " + 
                    "ID_MEMBRO = @id_membro",
                    conexao))
                {
                    mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                    mycommand.Parameters["@id_membro"].Value = IdMembro;
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
