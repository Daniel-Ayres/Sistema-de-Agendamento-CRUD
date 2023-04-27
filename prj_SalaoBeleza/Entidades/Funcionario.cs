using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_SalaoBeleza.Entidades
{
    public class Funcionario
    {
        int id;
        string nome, cargo, telefone, usuario, senha;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
