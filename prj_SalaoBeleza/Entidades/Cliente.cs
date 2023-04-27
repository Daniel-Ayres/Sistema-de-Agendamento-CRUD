using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_SalaoBeleza.Entidades
{
    internal class Cliente
    {
        int id;
        string Nome, Email, Telefone, Endereco, Cidade, Estado, Pais;

        public int Id { get => id; set => id = value; }
        public string Nome1 { get => Nome; set => Nome = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Telefone1 { get => Telefone; set => Telefone = value; }
        public string Endereco1 { get => Endereco; set => Endereco = value; }
        public string Cidade1 { get => Cidade; set => Cidade = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string Pais1 { get => Pais; set => Pais = value; }
    }
}
