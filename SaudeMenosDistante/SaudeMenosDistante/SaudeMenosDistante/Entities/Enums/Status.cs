using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities.Enums
{
    internal enum Status : int
    {
        Aberta = 0,
        Triagem = 1,
        Encaminhada = 2,
        Consulta = 3,
        Fechada = 4
    }
}
