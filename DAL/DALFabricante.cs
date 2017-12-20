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
    public class DALFabricante
    {
        private DALConexao conexao;

        public DALFabricante(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFabricante modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            
            cmd.CommandText = "EXECUTE spInserirFabricante @nome, @descricao";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeFabricante);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoFabricante);
            conexao.Conectar();
            modelo.IDFabricante = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloFabricante modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            
            cmd.CommandText = "EXECUTE spAlteraFabricante @nome, @descricao, @codigo";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDFabricante);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeFabricante);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoFabricante);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiFabricante @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraFabricante '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaExistente(String valor) // 0 = não existe valor
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spVerificaFabricanteExistente @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["ID_Fabricante"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloFabricante CarregaModeloFabricante(int codigo)
        {
            ModeloFabricante modelo = new ModeloFabricante();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spVerificaFabricanteExistente @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDFabricante = Convert.ToInt32(registro["ID_Fabricante"]);
                modelo.NomeFabricante = Convert.ToString(registro["Nome"]);
                modelo.DescricaoFabricante = Convert.ToString(registro["Descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
