using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_SalaoBeleza.DAO;
using prj_SalaoBeleza.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using MySqlX.XDevAPI;

namespace prj_SalaoBeleza.Model
{
    public class ClienteModel
    {
        ClientesDAO clientesDAO = new ClientesDAO();

        public DataTable Chamar_Listar()
        {
            try
            {
                DataTable dt_Listar = new DataTable();
                dt_Listar = clientesDAO.Listar();
                return dt_Listar;
            }
            catch (Exception)
            {

                throw;
            }
        }
        internal void  Excluir(Cliente dados)
        {
            try
            {
                clientesDAO.Excluir(dados);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um Erro ao Excluir \n", "ERRO!!" + ex.Message);
            }
        }
    }
}
