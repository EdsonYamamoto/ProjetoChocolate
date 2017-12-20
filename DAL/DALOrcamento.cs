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
    public class DALOrcamento
    {
        private DALConexao conexao;

        public DALOrcamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloOrcamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spInserirOrcamento @nome";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeOrcamento);
            conexao.Conectar();
            modelo.IDOrcamento = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloOrcamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraOrcamento @nome, @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDOrcamento);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeOrcamento);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiOrcamento @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraOrcamento '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloOrcamento CarregaModeloOrcamento(int codigo)
        {
            ModeloOrcamento modelo = new ModeloOrcamento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDOrcamento @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDOrcamento = Convert.ToInt32(registro["ID_Orcamento"]);
                modelo.NomeOrcamento = Convert.ToString(registro["Nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
