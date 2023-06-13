using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Enfermeiro : Colaborador
    {
        //Propriedades
        //Propriedades herdadas de Colaborador


        //Construtores
        public Enfermeiro()
        {

        }

        public Enfermeiro(string id, string nome, string morada, string telemovel, string email, double hora, double valorPorHora) 
            : base(id, nome, morada, telemovel, email, hora, valorPorHora)
        {
            
        }


        //Métodos
        //Método para registo do utente:
        public string RegistarUtente(string numeroUtente, string nome, string morada, string telemovel, string email)
        {
            return "Numero de utente: " + numeroUtente + " | Nome: " + nome + " | Morada: " + morada + " | Contacto: " + telemovel + " | Email: " + email + ".";

        }

        //Método para registo dos antecedentes de saúde do utente:
        public string RegistarAntecedentes()
        {
            Console.WriteLine("Antecedentes do Utente: ");
            string antecedentes = Console.ReadLine();
            return "Os antecendentes são: " + antecedentes;
        }

        //Método para cálculo do vencimento:
        public override double Vencimento()
        {
            return Hora * ValorPorHora;
        }



    }
}
