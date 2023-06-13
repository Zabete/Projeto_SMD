using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Equipamento
    {
        //Propriedades
        public string IdEquipamento { get; set; }
        public string Nome { get; set; }

        
        //Construtores
        public Equipamento()
        {
            
        }

        public Equipamento(string idEquipamento, string nome)
        {
            IdEquipamento = idEquipamento;
            Nome = nome;
        }

        

    }
}
