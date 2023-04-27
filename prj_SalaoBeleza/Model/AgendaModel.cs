using prj_SalaoBeleza.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_SalaoBeleza.Model
{
    public class AgendaModel
    {
        AgendaDAO Comunica_AgendaDAO = new AgendaDAO();
        public DataTable Chamar_Listar()
        {
            try
            {
                DataTable dt_Listar = new DataTable();
                dt_Listar = Comunica_AgendaDAO.Lista();
                return dt_Listar;
            }
            catch (Exception )
            {

                throw ;
            }
        }
    }
}

