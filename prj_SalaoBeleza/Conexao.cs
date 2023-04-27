using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prj_SalaoBeleza
{
    //ABRINDO CONEXÃO COM O BANCO MYSQL
    public class Conexao
    {
        //PASSANDO RECURSOS PARA LOCALIZAR E ABRIR O BANCO
        String conexao_bd = "dataSource=localHost; username=root; password=123456; database=db_bellasalao";

        public MySqlConnection conexao = null;

        //ABRINDO CONEXÃO COM O BANCO
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conexao_bd);
                conexao.Open();
                //MessageBox.Show("BANCO ABERTO COM SUCESSO!!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("OCORREU UM ERRO NA ABERTURA DO BANCO!! \n" + ex.Message);
            }
        }
        public void FecharBanco()
        {
            try
            {
                conexao = new MySqlConnection(conexao_bd);
                //FECHANDO CONEXAO
                conexao.Close();
            }
            catch (Exception ex)
            {

              
            }
        }
    }
}
