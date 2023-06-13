using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal abstract class Colaborador
    {
        //Propriedades
        public string Id { get; private set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Telemovel { get; set; }
        public string Email { get; set; }
        public double Hora { get; set; }
        public double ValorPorHora { get; private set; }


        //Construtores
        public Colaborador ()
        {

        }


        public Colaborador(string id, string nome, string morada, string telemovel, string email, double hora, double valorPorHora)
        {
            Id = id;
            Nome = nome;
            Morada = morada;
            Telemovel = telemovel;
            Email = email;
            Hora = hora;
            ValorPorHora = valorPorHora;
        }


        //Método Vencimento:
        public abstract double Vencimento();



    }
}
