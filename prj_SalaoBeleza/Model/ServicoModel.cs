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
    public class ServicoModel
    {
        ServicoDAO servicoDAO = new ServicoDAO();

        public DataTable Chamar_Listar()
        {
            try
            {
                DataTable dt_Listar = new DataTable();
                dt_Listar = servicoDAO.Listar();
                return dt_Listar;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
