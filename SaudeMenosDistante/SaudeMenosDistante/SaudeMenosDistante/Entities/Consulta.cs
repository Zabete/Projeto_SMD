using SaudeMenosDistante.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Consulta : Utente
    {
        //Propriedades
        public DateTime DataConsulta { get; set; }
        public string Freguesia { get; set; }

        public Status Estado { get; set; }

        public List<Utente> Utentes { get; set; } = new List<Utente>();


        //Construtores
        public Consulta()
        {
            
        }

        public Consulta(string numeroUtente, string nome, string morada, string telemovel, string email, double peso, double altura, string glicose, string colesterol, int pas, int pad, DateTime dataConsulta, string freguesia) 
            : base(numeroUtente, nome, morada, telemovel, email, peso, altura, glicose, colesterol, pas, pad)
        {
            DataConsulta = dataConsulta;
            Freguesia = freguesia;
        }


        //Métodos da Triagem do Utente
        //IMC
        public string IMC(double peso, double altura)
        {          
            double imc;
            imc = peso / (altura * altura);
            Console.WriteLine("IMC: " + imc.ToString("F1", CultureInfo.InvariantCulture));

            if (imc <= 18.5)
            {
                return ("Abaixo do peso.");
            }
            else if (imc > 18.6 && imc <= 24.9)
            {
                return ("Peso ideal.");
            }
            else if (imc > 25 && imc <= 29.9)
            {
                return ("Levemente acima do peso.");
            }
            else if (imc > 30 && imc <= 34.9)
            {
                return ("Obesidade grau I.");
            }
            else if (imc > 35 && imc <= 39.9)
            {
                return ("Obesidade grau II (severa).");
            }
            else
            {
                return ("Obesidade grau III (mórbida).");
            };
        }

        //Glicose
        public string ResultadoGlicose(int glicose)
        {
            if (glicose <= 69)
            {
                return ("Hipoglicemia.");
            }
            else if (glicose <= 139)
            {
                return ("Normal.");
            }
            else if (glicose > 140 || glicose >= 199)
            {
                return ("Pré-diabetes.");
            }
            else
            {
                return ("Diabetes.");
            }
        }

        //Colesterol
        public string ResultadoColesterol(int colesterol)
        {
            if (colesterol <= 189)
            {
                return ("Normal.");
            }
            else
            {
                return ("Alto.");
            }
        }

        //Método para retornar o risco cardiovascular  do utente com base no pas e no pad:
        public string CalcularRisco(int pas, int pad)
        {
            if (pas < 120 && pad < 80)
            {
                return("Ótima.");
            }
            else if (pas >= 120 && pas <= 129 || pad >= 80 && pad <= 84)
            {
                return ("Normal.");
            }
            else if (pas >= 130 && pas <= 139 || pad >= 85 && pad <= 89)
            {
                return ("Normal - Alta (1).");
            }
            else if (pas >= 140 && pas <= 149 || pad >= 90 && pad <= 99)
            {
                return ("HTA Grau I.");
            }
            else if (pas >= 160 && pas <= 179 || pad >= 100 && pad <= 109)
            {
                return ("HTA Grau II.");
            }
            else if (pas >= 180 || pad >= 110)
            {
                return ("HTA Grau III.");
            }
            else if (pas >= 140 && pad > 90)
            {
                return ("Hipertensão Sistólica Isolada (2).");
            }
            else
            {
                return ("Dados inseridos incorretos.");
            }
        }

    }
}
