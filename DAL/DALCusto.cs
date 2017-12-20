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
    public class DALCusto
    {
        private DALConexao conexao;

        public DALCusto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCusto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spInserirCusto @idfabricante, @nome, @precocusto, @qtdcusto, @unidad, @unidade, @descricao";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCusto);
            cmd.Parameters.AddWithValue("@idfabricante", modelo.IDFabricante);
            cmd.Parameters.AddWithValue("@precocusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@qtdcusto", modelo.QuantidadeCusto);
            cmd.Parameters.AddWithValue("@unidad", modelo.UnidadeCusto);
            cmd.Parameters.AddWithValue("@unidade", modelo.IDUnidadeMedida);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoCusto);

            conexao.Conectar();
            modelo.IDCusto = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloCusto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spInserirCusto @idfabricante, @nome, @precocusto, @qtdcusto, @unidad, @unidade, @descricao, @codigo";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDCusto);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeCusto);
            cmd.Parameters.AddWithValue("@idfabricante", modelo.IDFabricante);
            cmd.Parameters.AddWithValue("@precocusto", modelo.PrecoCusto);
            cmd.Parameters.AddWithValue("@qtdcusto", modelo.QuantidadeCusto);
            cmd.Parameters.AddWithValue("@unidad", modelo.UnidadeCusto);
            cmd.Parameters.AddWithValue("@unidade", modelo.IDUnidadeMedida);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoCusto);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiCusto @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraCusto '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCusto CarregaModeloCusto(int codigo)
        {
            ModeloCusto modelo = new ModeloCusto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDCusto @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDCusto = Convert.ToInt32(registro["ID_Custo"]);
                modelo.NomeCusto = Convert.ToString(registro["Nome"]);
                modelo.DescricaoCusto = Convert.ToString(registro["Descricao"]);
                modelo.IDFabricante = Convert.ToInt32(registro["ID_Fabricante"]);
                modelo.IDUnidadeMedida = Convert.ToInt32(registro["ID_UnidadeMedida"]);
                modelo.PrecoCusto = Convert.ToSingle(registro["Preco"]);
                modelo.QuantidadeCusto = Convert.ToInt32(registro["Quantidade"]);
                modelo.UnidadeCusto = Convert.ToSingle(registro["Unidade"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
