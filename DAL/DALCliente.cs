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
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "EXECUTE spInserirCliente @nome, @telefone, @celular, @idcidade, @idbairro";
                cmd.Parameters.AddWithValue("@nome", modelo.NomeCliente);
                cmd.Parameters.AddWithValue("@telefone", modelo.TelefoneCliente);
                cmd.Parameters.AddWithValue("@celular", modelo.CelularCliente);
                cmd.Parameters.AddWithValue("@idcidade", modelo.IDCidade);
                cmd.Parameters.AddWithValue("@idbairro", modelo.IDBairro);

                conexao.Conectar();
                modelo.IDCliente = Convert.ToInt32(cmd.ExecuteScalar());
            }
            
            catch(Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public void Alterar(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraCliente @nome, @telefone, @celular, @idcidade, @idbairro, @codigo";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDCliente);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCliente);
            cmd.Parameters.AddWithValue("@telefone", modelo.TelefoneCliente);
            cmd.Parameters.AddWithValue("@celular", modelo.CelularCliente);
            cmd.Parameters.AddWithValue("@idcidade", modelo.IDCidade);
            cmd.Parameters.AddWithValue("@idbairro", modelo.IDBairro);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiCliente @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraCliente '"+valor+"'", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDCliente @codigo"; 
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDCliente = Convert.ToInt32(registro["ID_Cliente"]);
                modelo.NomeCliente = Convert.ToString(registro["Nome"]);
                modelo.TelefoneCliente = Convert.ToInt64(registro["Telefone"]);
                modelo.CelularCliente = Convert.ToInt64(registro["Celular"]);
                modelo.IDCidade = Convert.ToInt32(registro["ID_Cidade"]);
                modelo.IDBairro = Convert.ToInt32(registro["ID_Bairro"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
