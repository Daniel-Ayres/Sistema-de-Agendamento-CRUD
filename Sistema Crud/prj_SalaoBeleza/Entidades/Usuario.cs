using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_SalaoBeleza.Entidades
{
    public class Usuario
    {
        int Usid;
        string LoginUsuario, UsSenha;

        public int Usid1 { get => Usid; set => Usid = value; }
        public string LoginUsuario1 { get => LoginUsuario; set => LoginUsuario = value; }
        public string UsSenha1 { get => UsSenha; set => UsSenha = value; }
    }
}
