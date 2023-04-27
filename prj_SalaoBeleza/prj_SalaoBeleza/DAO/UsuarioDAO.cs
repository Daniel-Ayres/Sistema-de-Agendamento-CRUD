using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using prj_SalaoBeleza.Entidades;

namespace prj_SalaoBeleza.DAO
{
    public class UsuarioDAO
    {
        MySqlCommand Comando_SQL = null; //Vazio
        Conexao conectar_BD = new Conexao();

        public bool Dados_Login(Usuario dadosUs)
        {
            try
            {
                //Caminho para pegar dados do banco de dados 
                conectar_BD.AbrirConexao();
                Comando_SQL = new MySqlCommand("SELECT id, usuario, senha FROM agendamento WHERE usuario = @usuario And senha = @senha", conectar_BD.conexao);

                Comando_SQL.Parameters.AddWithValue("@usuario", dadosUs.LoginUsuario1);
                Comando_SQL.Parameters.AddWithValue("@senha", dadosUs.Senha1);

                MySqlDataReader leitor = Comando_SQL.ExecuteReader(); // Criação de elemento que fará a comparação dos dados

                if (leitor.Read())
                {
                    int id = Convert.ToInt32(leitor["id"]); //Necessário []
                    conectar_BD.FecharBanco();
                    return id > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;

            }
        }


    }
}
