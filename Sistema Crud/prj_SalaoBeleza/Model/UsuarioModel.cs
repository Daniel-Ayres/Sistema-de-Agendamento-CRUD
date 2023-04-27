using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prj_SalaoBeleza.DAO;
using prj_SalaoBeleza.Entidades;
using System.Data;

namespace prj_SalaoBeleza.Model
{
    public class UsuarioModel
    { // Não precisa nessa altura colocar using para sql

            UsuarioDAO comunica_UsuarioDAO = new UsuarioDAO();

        public bool confirma_login(Usuario dadosUs)
        {
            try
            {
                bool bRet = comunica_UsuarioDAO.Dados_Login(dadosUs);
                return bRet;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro no login e senha" + ex);
                return false;
            }
        }

    }
}
