using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Motorista : Colaborador
    {
        //Propriedades
        //Propriedades herdadas de Colaborador

        //Construtores
        public Motorista()
        {

        }

        public Motorista(string id, string nome, string morada, string telemovel, string email, double hora, double valorPorHora) 
            : base(id, nome, morada, telemovel, email, hora, valorPorHora)
        {
            
        }


        //Método para cálculo do vencimento:
        public override double Vencimento()
        {
            return Hora * ValorPorHora;
        }



    }
}
