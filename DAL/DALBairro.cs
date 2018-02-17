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
    public class DALBairro
    {
        private DALConexao conexao;

        public DALBairro(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloBairro modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spInserirBairro @nome, @descricao";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeBairro);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoBairro);

            conexao.Conectar();
            modelo.IDBairro = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloBairro modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraBairro @nome, @descreve, @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeBairro);
            cmd.Parameters.AddWithValue("@codigo", modelo.IDBairro);
            cmd.Parameters.AddWithValue("@descreve", modelo.DescricaoBairro);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiBairro @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        
        public DataTable Localizara(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spProcuraBairro '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        
        public DataTable Localizar(String valor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraBairro '" + valor + "'", conexao.StringConexao);
            
            da.Fill(tabela);
            return tabela;
        }

        public int VerificaExistente(String valor) // 0 = não existe valor
        {
            int r = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spVerificaBairroExistente @nome;";
            cmd.Parameters.AddWithValue("@nome", valor);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                r = Convert.ToInt32(registro["ID_Bairro"]);
            }
            conexao.Desconectar();
            return r;
        }

        public ModeloBairro CarregaModeloBairro(int codigo)
        {
            ModeloBairro modelo = new ModeloBairro();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDBairro @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDBairro = Convert.ToInt32(registro["ID_Bairro"]);
                modelo.NomeBairro = Convert.ToString(registro["Nome"]);
                modelo.DescricaoBairro = Convert.ToString(registro["Descricao"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }

}
