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
    public class DALManufaturado
    {

        private DALConexao conexao;

        public DALManufaturado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloManufaturado modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spInserirManufaturado @idtipo,@caracteristica1,@caracteristica2,@nome,@unidademedida,@peso,@preco,@descricao";
            cmd.Parameters.AddWithValue("@idtipo", modelo.IDTipoManufaturado);
            cmd.Parameters.AddWithValue("@caracteristica1", modelo.IDCaracteristicaManufaturado1);
            cmd.Parameters.AddWithValue("@caracteristica2", modelo.IDCaracteristicaManufaturado2);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeManufaturado);
            cmd.Parameters.AddWithValue("@unidademedida", modelo.IDUnidadeMedida);
            cmd.Parameters.AddWithValue("@peso", modelo.QuantidadeManufaturado);
            cmd.Parameters.AddWithValue("@preco", modelo.PrecoManufaturado);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoManufaturado);

            conexao.Conectar();
            modelo.IDManufaturado = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloManufaturado modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraManufaturado @idtipo,@caracteristica1,@caracteristica2,@nome,@unidademedida,@peso,@preco,@descricao, @codigo;";

            cmd.Parameters.AddWithValue("@codigo", modelo.IDManufaturado);
            cmd.Parameters.AddWithValue("@idtipo", modelo.IDTipoManufaturado);
            cmd.Parameters.AddWithValue("@caracteristica1", modelo.IDCaracteristicaManufaturado1);
            cmd.Parameters.AddWithValue("@caracteristica2", modelo.IDCaracteristicaManufaturado2);
            cmd.Parameters.AddWithValue("@nome", modelo.NomeManufaturado);
            cmd.Parameters.AddWithValue("@unidademedida", modelo.IDUnidadeMedida);
            cmd.Parameters.AddWithValue("@peso", modelo.QuantidadeManufaturado);
            cmd.Parameters.AddWithValue("@preco", modelo.PrecoManufaturado);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoManufaturado);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiManufaturado @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraManufaturado '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela; 
        }

        public DataTable LocalizarModelo(ModeloManufaturado modelo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraManufaturadoModelo '" + modelo.IDTipoManufaturado +
                "', '" + modelo.IDCaracteristicaManufaturado1 +
                "', '" + modelo.IDCaracteristicaManufaturado2 +
                "' ", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public ModeloManufaturado CarregaModeloManufaturado(int codigo)
        {
            ModeloManufaturado modelo = new ModeloManufaturado();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDManufaturado @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDManufaturado = Convert.ToInt32(registro["ID_Manufaturado"]);
                modelo.NomeManufaturado = Convert.ToString(registro["Nome"]);
                modelo.PrecoManufaturado = Convert.ToSingle(registro["Preco"]);
                modelo.QuantidadeManufaturado = Convert.ToSingle(registro["Peso"]);
                modelo.IDTipoManufaturado = Convert.ToInt32(registro["ID_TipoManufaturado"]);
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado1"]);
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado2"]);
                modelo.IDUnidadeMedida = Convert.ToInt32(registro["ID_UnidadeMedida"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}

