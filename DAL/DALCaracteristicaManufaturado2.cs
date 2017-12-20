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
    public class DALCaracteristicaManufaturado2
    {
        private DALConexao conexao;

        public DALCaracteristicaManufaturado2(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCaracteristicaManufaturado2 modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "EXECUTE spInserirCaracteristicaManufaturado2 @nome, @descicao";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeCaracteristicaManufaturado2);
                cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoCaracteristicaManufaturado2);

                conexao.Conectar();
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(ModeloCaracteristicaManufaturado2 modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraCaracteristicaManufaturado2 @nome, @descricao, @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDCaracteristicaManufaturado2);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCaracteristicaManufaturado2);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoCaracteristicaManufaturado2);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiCaracteristicaManufaturado2 @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraCaracteristicaManufaturado2 '" + valor + "'", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public int VerificaExistente(String valor) // 0 = não existe valor
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraCaracteristicaManufaturado2 @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["ID_CaracteristicaManufaturado2"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloCaracteristicaManufaturado2 CarregaModeloCaracteristicaManufaturado2(int codigo)
        {
            ModeloCaracteristicaManufaturado2 modelo = new ModeloCaracteristicaManufaturado2();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDCaracteristicaManufaturado2 @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado2"]);
                modelo.NomeCaracteristicaManufaturado2 = Convert.ToString(registro["Nome"]);
                modelo.DescricaoCaracteristicaManufaturado2 = Convert.ToString(registro["Descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
