using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_SalaoBeleza.Entidades;
using MySql.Data.MySqlClient;
using System.Data;



namespace prj_SalaoBeleza.DAO
{
    public class AgendaDAO
    {
        MySqlCommand comando_sql = null;
        Conexao conectar_BD = new Conexao();


        public DataTable Lista()
        {
            try
            {
                conectar_BD.AbrirConexao();

                comando_sql = new MySqlCommand("SELECT * FROM agendamento order by id desc", conectar_BD.conexao);

                MySqlDataAdapter pesq_dados = new MySqlDataAdapter(comando_sql);

                pesq_dados.SelectCommand = comando_sql;

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

