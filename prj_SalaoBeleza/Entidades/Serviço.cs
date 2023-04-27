using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_SalaoBeleza.Entidades
{
    public class Serviço
    {
        int id;
        string nome, descricao;
        DateTime hrs_media_gasta;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Hrs_media_gasta { get => hrs_media_gasta; set => hrs_media_gasta = value; }
    }
}
