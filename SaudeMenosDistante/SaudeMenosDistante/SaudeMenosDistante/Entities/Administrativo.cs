using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Administrativo : Colaborador
    {
        //Propriedades
        //Propriedades herdadas de Colaborador
        public List<Colaborador> Equipa { get; set; }


        //Construtores
        public Administrativo()
        {

        }

        public Administrativo(string id, string nome, string morada, string telemovel, string email, double hora, double valorPorHora) 
            : base(id, nome, morada, telemovel, email, hora, valorPorHora)
        {
            
        }


        //Métodos
        //Método para calendarizar as visitas:
        public string CalendarizarVisitas()
        {
            Console.Write("Indique a data para a qual quer fazer o agendamento: ");
            DateOnly dataVisita = DateOnly.Parse(Console.ReadLine());
            Console.Write("Indique a freguesia para a qual quer fazer o agendamento: ");
            string freguesia = (Console.ReadLine());
            DateOnly dataenvio1 = dataVisita.AddDays(-7);
            DateOnly dataenvio2 = dataVisita.AddDays(-1);

            Console.WriteLine();
            return ($"Agendamento da visita à freguesia {freguesia} para o dia {dataVisita}. \nEnvio do email para os utentes nas datas {dataenvio1} e {dataenvio2}.");
        }


        //Método para retornar o relatório dos dados estatísticos gerais das consultas efetuadas por zona do país (número de consultas total, número de consultas da última semana, número de consultas do último mês, número de consultas do último dia).
        public string RelatorioEstatistico(string concelho)
        {

            List<Consulta> consultas1 = new List<Consulta>();
            consultas1.Add(new Consulta("123456789", "João Nunes", "Rua das Flores, 123", "912345678", "joao.nunes@gmail.com", 70.5, 1.75, "95", "180", 115, 75, DateTime.Now, "São Vitor")); ;
            consultas1.Add(new Consulta("987654321", "Ana Santos", "Avenida Central, 456", "923456789", "ana.santos@gmail.com", 65.2, 1.60, "110", "200", 125, 75, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("456789123", "Pedro Costa", "Travessa das Oliveiras, 789", "914567890", "pedro.costa@gmail.com", 80, 1.85, "120", "220", 129, 86, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("321654987", "Sofia Rodrigues", "Rua dos Cedros, 234", "926543217", "sofia.rodrigues@gmail.com", 55.5, 1.70, "90", "170", 141, 95, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("789456123", "Carlos Pereira", "Avenida das Palmeiras, 567", "918765432", "carlos.pereira@gmail.com", 90.3, 1.80, "135", "250", 170, 103, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("234567891", "Ana Martins", "Praça da Liberdade, 890", "927654321", "ana.martins@gmail.com", 68.7, 1.65, "100", "190", 185, 112, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("918273645", "Miguel Ferreira", "Rua dos Pinheiros, 560", "912345678", "miguel.ferreira@gmail.com", 73.2, 1.78, "105", "195", 145, 107, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("543216789", "Marina Almeida", "Avenida dos Girassóis, 782", "923456789", "marina.almeida@gmail.com", 61.8, 1.62, "115", "210", 182, 76, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("876543219", "Ricardo Santos", "Rua das Palmeiras, 876", "919876543", "ricardo.santos@gmail.com", 95.3, 1.90, "182", "215", 145, 80, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("896516789", "Clara Vieira", "Avenida da Luz, 225", "935495670", "clara.vieira@gmail.com", 59.1, 1.63, "107", "175", 135, 92, DateTime.Now, "São Vitor"));


            if (consultas1 != null)
            {
                int countTotal = consultas1.Count;
                int countMes = 0;
                int countSemana = 0;
                int countDia = 0;

                DateTime now = DateTime.Now;

                foreach (Consulta consulta in consultas1)
                {
                    if (consulta.DataConsulta.Month == now.Month)
                    {
                        countMes++;
                    }
                    if ((now - consulta.DataConsulta).TotalDays <= 7)
                    {
                        countSemana++;
                    }
                    if (consulta.DataConsulta.Date == now.Date)
                    {
                        countDia++;
                    }
                }
                Console.WriteLine("Relatório Estatístico");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"Zona do País: {concelho}");
                Console.WriteLine($"Total de Consultas: {countTotal}");
                Console.WriteLine($"Consultas no Mês: {countMes}");
                Console.WriteLine($"Consultas na Semana: {countSemana}");
                Console.WriteLine($"Consultas no Dia: {countDia}");
            }
            else
            {
                Console.WriteLine("Não foram encontradas consultas.");
            }
            return ("Não foram encontradas consultas.");
        }

        //Método para retornar o relatório das consultas efetuadas, com filtro diário, indicando de forma clara quais as pessoas que apresentaram HTA grau 1, HTA grau 2, HTA grau 3.
        public string RelatorioRiscoCardiovascular()
        {
            List<Consulta> pacientesRisco = new List<Consulta>();
            List<Consulta> consultas1 = new List<Consulta>();

            consultas1.Add(new Consulta("123456789", "João Nunes", "Rua das Flores, 123", "912345678", "joao.nunes@gmail.com", 70.5, 1.75, "95", "180", 115, 75, DateTime.Now, "São Vitor")); ;
            consultas1.Add(new Consulta("987654321", "Ana Santos", "Avenida Central, 456", "923456789", "ana.santos@gmail.com", 65.2, 1.60, "110", "200", 125, 75, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("456789123", "Pedro Costa", "Travessa das Oliveiras, 789", "914567890", "pedro.costa@gmail.com", 80, 1.85, "120", "220", 129, 86, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("321654987", "Sofia Rodrigues", "Rua dos Cedros, 234", "926543217", "sofia.rodrigues@gmail.com", 55.5, 1.70, "90", "170", 141, 95, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("789456123", "Carlos Pereira", "Avenida das Palmeiras, 567", "918765432", "carlos.pereira@gmail.com", 90.3, 1.80, "135", "250", 170, 103, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("234567891", "Ana Martins", "Praça da Liberdade, 890", "927654321", "ana.martins@gmail.com", 68.7, 1.65, "100", "190", 185, 112, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("918273645", "Miguel Ferreira", "Rua dos Pinheiros, 560", "912345678", "miguel.ferreira@gmail.com", 73.2, 1.78, "105", "195", 145, 107, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("543216789", "Marina Almeida", "Avenida dos Girassóis, 782", "923456789", "marina.almeida@gmail.com", 61.8, 1.62, "115", "210", 182, 76, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("876543219", "Ricardo Santos", "Rua das Palmeiras, 876", "919876543", "ricardo.santos@gmail.com", 95.3, 1.90, "182", "215", 145, 80, DateTime.Now, "São Vitor"));
            consultas1.Add(new Consulta("896516789", "Clara Vieira", "Avenida da Luz, 225", "935495670", "clara.vieira@gmail.com", 59.1, 1.63, "107", "175", 135, 92, DateTime.Now, "São Vitor"));

            foreach (Consulta paciente in consultas1)
            {
                if (paciente.DataConsulta.Date == DateTime.Today &&
                         (paciente.CalcularRisco(paciente.Pas, paciente.Pad) == "HTA Grau I." ||
                          paciente.CalcularRisco(paciente.Pas, paciente.Pad) == "HTA Grau II." ||
                          paciente.CalcularRisco(paciente.Pas, paciente.Pad) == "HTA Grau III."))
                {
                    pacientesRisco.Add(paciente);
                }
            }
                Console.WriteLine("Relatório de Risco Cardiovascular - Filtro Diário");
                Console.WriteLine("----------------------------------------------------");

            if (pacientesRisco.Count > 0)
            {
                    Console.WriteLine($"Pacientes com HTA Grau 1, HTA Grau 2 e HTA Grau 3:");
                    foreach (Consulta paciente in pacientesRisco)
                    {
                        Console.WriteLine($"Nome: {paciente.Nome} | Risco: {paciente.CalcularRisco(paciente.Pas, paciente.Pad)}");
                    
                    }
            }
           else
           {
                    Console.WriteLine($"Não foram encontrados pacientes com HTA Grau 1, HTA Grau 2 e HTA Grau 3 - {DateTime.Today:d}.");
           }
           Console.WriteLine();
           return ($"Relatório gerado em {DateTime.Today:d}.");
        }


        //Método para retornar o relatório dos colaboradores da sua equipa apresentando o seu nome e vencimento.
        public string RelatorioEquipa()
        {
            List<Colaborador> colaboradores = new List<Colaborador>();
            colaboradores.Add(new Medico("Med01", "Sofia Fernandes", "Praça Central, 234", "914567890", "sofia.fernandes@gmail.com", 50.0, 20.0));
            colaboradores.Add(new Enfermeiro("Enf01", "Maria Santos", " Avenida Central, 456", "923456789", "maria.santos@gmail.com", 50.0, 12.0));
            colaboradores.Add(new Administrativo("Adm01", "Pedro Oliveira", "Travessa das Flores, 789", "965432187", "pedro.oliveira@gmail.com", 40.0, 10.0));
            colaboradores.Add(new Motorista("Mot01", "João Silva", "Rua Principal, 123", "912345678", "joao.silva@gmail.com", 40.0, 8.0));

            string relatorio = "Relatório da Equipa:\n----------------------------------------------------\n";

            foreach (Colaborador colaborador in colaboradores)
            {
                relatorio += $"Nome: {colaborador.Nome} | Vencimento: {colaborador.Vencimento()} euros.\n";
            }
            return relatorio;
        }

        //Método para cálculo do vencimento:
        public override double Vencimento()
        {
            return Hora * ValorPorHora;
        }



    }
}
