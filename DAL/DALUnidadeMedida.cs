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
    public class DALUnidadeMedida
    {
        private DALConexao conexao;

        public DALUnidadeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeMedida modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spInserirUnidadeMedida @nome";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeUnidadeMedida);
            conexao.Conectar();
            modelo.IDUnidadeMedida = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUnidadeMedida modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraUnidadeMedida @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDUnidadeMedida);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeUnidadeMedida);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiUnidadeMedida @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraUnidadeMedida '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaExistente(String valor) // 0 = não existe valor
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spVerificaUnidadeMedidaExistente @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["ID_UnidadeMedida"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDUnidadeMedida @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDUnidadeMedida = Convert.ToInt32(registro["ID_UnidadeMedida"]);
                modelo.NomeUnidadeMedida = Convert.ToString(registro["Nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
