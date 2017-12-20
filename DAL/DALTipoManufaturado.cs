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
    public class DALTipoManufaturado
    {
        private DALConexao conexao;

        public DALTipoManufaturado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoManufaturado modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "EXECUTE spInserirTipoManufaturado @nome, @descricao";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeTipoManufaturado);
                cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoTipoManufaturado);

                conexao.Conectar();
                modelo.IDTipoManufaturado = Convert.ToInt32(cmd.ExecuteScalar());
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
        public void Alterar(ModeloTipoManufaturado modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraTipoManufaturado @nome, @descricao, @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDTipoManufaturado);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeTipoManufaturado);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoTipoManufaturado);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiTipoManufaturado @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraTipoManufaturado '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        
        public int VerificaExistente(String valor) // 0 = não existe valor
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spVerificaTipoManufaturadoExistente @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["ID_TipoManufaturado"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloTipoManufaturado CarregaModeloTipoManufaturado(int codigo)
        {
            ModeloTipoManufaturado modelo = new ModeloTipoManufaturado();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraTipoManufaturado @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDTipoManufaturado = Convert.ToInt32(registro["ID_TipoManufaturado"]);
                modelo.NomeTipoManufaturado = Convert.ToString(registro["Nome"]);
                modelo.DescricaoTipoManufaturado = Convert.ToString(registro["Descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
