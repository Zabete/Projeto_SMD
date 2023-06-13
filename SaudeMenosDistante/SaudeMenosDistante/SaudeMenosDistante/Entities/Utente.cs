using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Utente
    {
        //Propriedades
        public string NumeroUtente { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Telemovel { get; set; }
        public string Email { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Glicose { get; set; }
        public string Colesterol { get; set; }
        public int Pas { get; set; } //Pas + Pad calcula a tensão arterial.
        public int Pad { get; set; } //Pas + Pad calcula a tensão arterial.


        //Construtores
        public Utente()
        {
            
        }

        public Utente(string numeroUtente, string nome, string morada, string telemovel, string email, double peso, double altura, string glicose, string colesterol, int pas, int pad)
        {
            NumeroUtente = numeroUtente;
            Nome = nome;
            Morada = morada;
            Telemovel = telemovel;
            Email = email;
            Peso = peso;
            Altura = altura;
            Glicose = glicose;
            Colesterol = colesterol;
            Pas = pas;
            Pad = pad;
        }
    }
}
