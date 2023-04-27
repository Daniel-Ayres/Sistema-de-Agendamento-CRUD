using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_SalaoBeleza.Entidades
{
    public class Agenda
    {
        int id, Id_Funcionario, Id_Servico, Id_Cliente;
        DateTime dthrs_agendamento;

        public int Id { get => id; set => id = value; }
        public int Id_Funcionario1 { get => Id_Funcionario; set => Id_Funcionario = value; }
        public int Id_Servico1 { get => Id_Servico; set => Id_Servico = value; }
        public int Id_Cliente1 { get => Id_Cliente; set => Id_Cliente = value; }
        public DateTime Dthrs_agendamento { get => dthrs_agendamento; set => dthrs_agendamento = value; }
    }
}
