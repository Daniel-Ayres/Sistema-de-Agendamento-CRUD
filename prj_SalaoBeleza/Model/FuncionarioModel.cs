using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_SalaoBeleza.DAO;
using prj_SalaoBeleza.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace prj_SalaoBeleza.Model
{
    public class FuncionarioModel
    {
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

        public DataTable Chamar_Listar()
        {
            try
            {
                DataTable dt_Listar = new DataTable();
                dt_Listar = funcionarioDAO.Listar();
                return dt_Listar;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
