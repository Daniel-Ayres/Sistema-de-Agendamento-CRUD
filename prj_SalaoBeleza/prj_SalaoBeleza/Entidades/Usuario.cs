using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_SalaoBeleza.Entidades
{
    public class Usuario
    {
        int id;
        string LoginUsuario, Senha;

        public int Id { get => id; set => id = value; }
        public string LoginUsuario1 { get => LoginUsuario; set => LoginUsuario = value; }
        public string Senha1 { get => Senha; set => Senha = value; }
    }
}
