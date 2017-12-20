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
     public class DALCidade
    {
        private DALConexao conexao;

        public DALCidade(DALConexao cx)
        {
            this.conexao = cx;
        }
        
        public void Incluir(ModeloCidade modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spInserirCidade @nome, @descricao";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCidade);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoCidade);
            conexao.Conectar();
            modelo.IDCidade = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloCidade modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraCidade @nome, @descreve, @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCidade);
            cmd.Parameters.AddWithValue("@codigo", modelo.IDCidade);
            cmd.Parameters.AddWithValue("@descreve", modelo.DescricaoCidade);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir (int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiCidade @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar (String valor)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraCidade '"+valor+"'", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public int VerificaExistente(String valor) // 0 = não existe valor
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spVerificaCidadeExistente @nome";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["ID_Cidade"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloCidade CarregaModeloCidade(int codigo)
        {
            ModeloCidade modelo = new ModeloCidade();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDCidade @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo); 
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                modelo.IDCidade = Convert.ToInt32(registro["ID_Cidade"]);
                modelo.NomeCidade = Convert.ToString(registro["Nome"]);
                modelo.DescricaoCidade = Convert.ToString(registro["Descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
    
}
