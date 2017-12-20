using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCaracteristicaManufaturado1
    {
        private DALConexao conexao;

        public DALCaracteristicaManufaturado1(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCaracteristicaManufaturado1 modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "EXECUTE spInserirCaracteristicaManufaturado1 @nome, @descicao";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeCaracteristicaManufaturado1);
                cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoCaracteristicaManufaturado1);

                conexao.Conectar();
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            finally
            {
                conexao.Desconectar();
            }

        }
        public void Alterar(ModeloCaracteristicaManufaturado1 modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraCaracteristicaManufaturado1 @nome, @descricao, @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDCaracteristicaManufaturado1);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCaracteristicaManufaturado1);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoCaracteristicaManufaturado1);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiCaracteristicaManufaturado1 @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {

            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraCaracteristicaManufaturado1 '"+valor+"'", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public int VerificaExistente(String valor) // 0 = não existe valor
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraCaracteristicaManufaturado1 @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["ID_CaracteristicaManufaturado1"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloCaracteristicaManufaturado1 CarregaModeloCaracteristicaManufaturado1(int codigo)
        {
            ModeloCaracteristicaManufaturado1 modelo = new ModeloCaracteristicaManufaturado1();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDCaracteristicaManufaturado1 @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado1"]);
                modelo.NomeCaracteristicaManufaturado1 = Convert.ToString(registro["Nome"]);
                modelo.DescricaoCaracteristicaManufaturado1 = Convert.ToString(registro["Descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
