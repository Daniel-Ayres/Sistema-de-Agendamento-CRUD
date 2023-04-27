using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace prj_SalaoBeleza.DAO
{
    public class ServicoDAO
    {
        MySqlCommand comandos_sql = null;
        Conexao conectar = new Conexao();

        public DataTable Listar()
        {
            try
            {
                conectar.AbrirConexao();
                // Instanciar uma variável com o código SQL  de Pesquisa
                comandos_sql = new MySqlCommand("SELECT * FROM servicos order by id desc", conectar.conexao);
                MySqlDataAdapter pesq_dados = new MySqlDataAdapter(comandos_sql);
                pesq_dados.SelectCommand = comandos_sql;

                DataTable dados_tabela = new DataTable();

                pesq_dados.Fill(dados_tabela);

                return dados_tabela;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}

