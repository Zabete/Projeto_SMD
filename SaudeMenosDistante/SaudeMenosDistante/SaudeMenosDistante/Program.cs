using System.Globalization;
using System.Collections.Generic;
using SaudeMenosDistante.Entities;
using SaudeMenosDistante.Entities.Enums;
using System;
using System.Drawing;

namespace SaudeMenosDistante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //----------------------------------Saúde Menos Distante----------------------------------------//

            //Lista Utentes presentes na "base de dados":

            List<Utente> utentes = new List<Utente>();
            utentes.Add(new Utente("123456789", "João Nunes", "Rua das Flores, 123", "912345678", "joao.silva@gmail.com", 70.5, 1.75, "95", "180", 115, 75));
            utentes.Add(new Utente("987654321", "Ana Santos", "Avenida Central, 456", "923456789", "ana.santos@gmail.com", 65.2, 1.60, "110", "200", 125, 75));
            utentes.Add(new Utente("456789123", "Pedro Costa", "Travessa das Oliveiras, 789", "914567890", "pedro.costa@gmail.com", 80, 1.85, "120", "220", 129, 86));
            utentes.Add(new Utente("321654987", "Sofia Rodrigues", "Rua dos Cedros, 234", "926543217", "sofia.rodrigues@gmail.com", 55.5, 1.70, "90", "170", 141, 95));
            utentes.Add(new Utente("789456123", "Carlos Pereira", "Avenida das Palmeiras, 567", "918765432", "carlos.pereira@gmail.com", 90.3, 1.80, "135", "250", 170, 103));
            utentes.Add(new Utente("234567891", "Ana Martins", "Praça da Liberdade, 890", "927654321", "ana.martins@gmail.com", 68.7, 1.65, "100", "190", 185, 112));
            utentes.Add(new Utente("918273645", "Miguel Ferreira", "Rua dos Pinheiros, 560", "912345678", "miguel.ferreira@gmail.com", 73.2, 1.78, "105", "195", 145, 107));
            utentes.Add(new Utente("543216789", "Marina Almeida", "Avenida dos Girassóis, 782", "923456789", "marina.almeida@gmail.com", 61.8, 1.62, "115", "210", 182, 76));
            utentes.Add(new Utente("876543219", "Ricardo Santos", "Rua das Palmeiras, 876", "919876543", "ricardo.santos@gmail.com", 95.3, 1.90, "182", "215", 145, 80));
            utentes.Add(new Utente("896516789", "Clara Vieira", "Avenida da Luz, 225", "935495670", "clara.vieira@gmail.com", 59.1, 1.63, "107", "175", 135, 92));

            //Lista de Consultas presentes na "base de dados":
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

            //Lista de Colaboradores (Equipa 01) presentes na "base de dados":
            List<Colaborador> colaboradores = new List<Colaborador>();
            string equi = "01";
            string concelho = "Braga";
            colaboradores.Add(new Medico("Med01", "Sofia Fernandes", "Praça Central, 234", "914567890", "sofia.fernandes@gmail.com", 50.0, 20.0));
            colaboradores.Add(new Enfermeiro("Enf01", "Maria Santos", " Avenida Central, 456", "923456789", "maria.santos@gmail.com", 50.0, 12.0));
            colaboradores.Add(new Administrativo("Adm01", "Pedro Oliveira", "Travessa das Flores, 789", "965432187", "pedro.oliveira@gmail.com", 40.0, 10.0));
            colaboradores.Add(new Motorista("Mot01", "João Silva", "Rua Principal, 123", "912345678", "joao.silva@gmail.com", 40.0, 8.0));

            //Instanciação da Consulta:
            Consulta consulta = new Consulta();
            Console.WriteLine();


            //------------------------------Login e Senha------------------------------//

            Console.Write("Id: ");
            string id = (Console.ReadLine());
            Console.Write("Senha: ");
            string senha = Console.ReadLine();
            Console.WriteLine();

            //------------------------------Menu Colaborador------------------------------//
            //De acordo o login feito ele vai entrar no menu correspondente.

            if (id == "Enf01" && senha == "enfermeiro")
            {
                //---------Entramos no menu do enfermeiro:
                //Exibir Concelho e Equipa:
                Console.WriteLine("Equipa: " + equi);
                Console.WriteLine("Concelho: " + concelho);
                Console.WriteLine();

                //Exibir a equipa de colaboradores:
                Console.WriteLine("Membros da equipa: ");
                foreach (Colaborador equipa1 in colaboradores)
                {
                    Console.WriteLine($"Id:{equipa1.Id} | Nome: {equipa1.Nome} | Telemóvel:{equipa1.Telemovel} | Email:{equipa1.Email}.");
                }
                Console.WriteLine("----------------------------------------------------");

                //Secção Equipamentos:
                //Lista de Equipamentos para o enfermeiro verificar o material que irá utilizar.
                Console.WriteLine();
                Console.WriteLine("Lista de equipamentos: ");
                Equipa equipamentoStock = new Equipa();
                equipamentoStock.AddEquipamento("01", "Estetoscópio");
                equipamentoStock.AddEquipamento("02", "Esfigmomanômetro");
                equipamentoStock.AddEquipamento("03", "Tiras de avaliação de colesterol");
                equipamentoStock.AddEquipamento("04", "Tiras de avaliação de glicose");
                equipamentoStock.AddEquipamento("05", "Balança");
                equipamentoStock.AddEquipamento("06", "Fita métrica");
                equipamentoStock.MostrarEquipamento();

                //Opção para o enfermeiro efetuar alterações na lista de equipamentos:
                Console.WriteLine();
                Console.Write("Quer fazer o pedido para remover ou adicionar algum equipamento? (s/n): ");
                char resp = char.Parse(Console.ReadLine());
                while (resp == 's' || resp == 'S')
                {
                    Console.Write("Quer remover ou adicionar?: ");
                    string resp2 = Console.ReadLine();
                    if (resp2 == "remover" || resp2 == "Remover")
                    {
                        Console.WriteLine("Indique o Id e nome do equipamento a remover: ");
                        Console.Write("Id: ");
                        string id1 = (Console.ReadLine());
                        Console.Write("Nome: ");
                        string nome1 = (Console.ReadLine());
                        equipamentoStock.RemoveEquipamento(id1, nome1);
                        Console.WriteLine();
                        Console.WriteLine("Lista atualizada:");
                        equipamentoStock.MostrarEquipamento();
                        Console.WriteLine();
                        Console.Write("Quer fazer outro pedido para remover ou adicionar algum equipamento? (s/n): ");
                        resp = char.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Indique o Id e nome do equipamento a adicionar: ");
                        Console.Write("Id: ");
                        string id1 = (Console.ReadLine());
                        Console.Write("Nome: ");
                        string nome1 = (Console.ReadLine());
                        equipamentoStock.AddEquipamento(id1, nome1);
                        Console.WriteLine();
                        Console.WriteLine("Lista atualizada:");
                        equipamentoStock.MostrarEquipamento();
                        Console.WriteLine();
                        Console.Write("Quer fazer outro pedido para remover ou adicionar algum equipamento? (s/n): ");
                        resp = char.Parse(Console.ReadLine());
                    }
                };
                Console.WriteLine("Secção equipamentos finalizada.");

                Console.WriteLine("----------------------------------------------------");

                //Status Atendimento: aqui o enfermeiro dará início ao atendimento.
                Console.WriteLine();
                Enfermeiro enfermeiro = new Enfermeiro();
                Console.Write("Estado da consulta: "); //Status Aberta.
                consulta.Estado = (Status)Enum.Parse(typeof(Status), Console.ReadLine());

                //Inserção dos dados do utente:
                Console.WriteLine();
                Console.Write("Número do Utente: ");
                string numeroUtente = Console.ReadLine();
                Console.Write("Nome do Utente: ");
                string nome = Console.ReadLine();
                Console.Write("Morada do Utente: ");
                string morada = Console.ReadLine();
                Console.Write("Telemóvel do Utente: ");
                string telemovel = Console.ReadLine();
                Console.Write("Email do Utente: ");
                string email = Console.ReadLine();

                //Exibição dos dados do utente inseridos:
                Console.WriteLine();
                string dados = enfermeiro.RegistarUtente(numeroUtente, nome, morada, telemovel, email);
                Console.WriteLine(dados);

                //Registo dos antecedentes de saúde do utente:
                Console.WriteLine();
                enfermeiro.RegistarAntecedentes();

                //Atualização do status do atendimento: aqui o enfermeiro atualiza o status para a Triagem.
                Console.WriteLine();
                Console.Write("Estado da consulta: ");
                consulta.Estado = (Status)Enum.Parse(typeof(Status), Console.ReadLine());

                //Triagem do Utente:
                //Classificação IMC:
                Console.WriteLine();
                Console.Write("Peso do Utente: ");
                double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura do Utente: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                string imc = consulta.IMC(peso, altura);
                Console.WriteLine(imc);

                //Classificação Glicose:
                Console.WriteLine();
                Console.Write("Glicose do Utente: ");
                int glicose = int.Parse(Console.ReadLine());
                string glic = consulta.ResultadoGlicose(glicose);
                Console.WriteLine(glic);

                //Classificação Colesterol:
                Console.WriteLine();
                Console.Write("Colesterol do Utente: ");
                int colesterol = int.Parse(Console.ReadLine());
                string coles = consulta.ResultadoColesterol(colesterol);
                Console.WriteLine(coles);

                //Classificação Risco Cardiovascular:
                Console.WriteLine();
                Console.Write("Tensão Arterial do Utente (PAS): ");
                int pas = int.Parse(Console.ReadLine());
                Console.Write("Tensão Arterial do Utente (PAD): ");
                int pad = int.Parse(Console.ReadLine());
                string risco = consulta.CalcularRisco(pas, pad);
                Console.WriteLine(risco);

                //Adicionar dados do utente a lista das Consultas:
                utentes.Add(new Utente(numeroUtente, nome, morada, telemovel, email, peso, altura, glic, coles, pas, pad));

                //Atualização do status do atendimento: final do atendimento pelo enfermeiro, utente é encaminhado para o médico.
                Console.WriteLine();
                Console.Write("Estado da consulta: "); //Status Encaminhado.
                consulta.Estado = (Status)Enum.Parse(typeof(Status), Console.ReadLine());
            }

            else if (id == "Med01" && senha == "medico")
            {
                //---------Entramos no menu do médico:
                //Exibir Concelho e Equipa:
                Console.WriteLine("Equipa: " + equi);
                Console.WriteLine("Concelho: " + concelho);
                Console.WriteLine();

                //Exibir a equipa de colaboradores:
                Console.WriteLine("Membros da equipa: ");
                foreach (Colaborador equipa1 in colaboradores)
                {
                    
                    Console.WriteLine($"Id:{equipa1.Id} | Nome: {equipa1.Nome} | Telemóvel:{equipa1.Telemovel} | Email:{equipa1.Email}.");
                }

                Console.WriteLine("----------------------------------------------------");

                //Status Atendimento: aqui começa o atendimento do médico.
                Console.Write("Estado da consulta: "); //Status Consulta.
                consulta.Estado = (Status)Enum.Parse(typeof(Status), Console.ReadLine());

                //Identificação Utente - Resultado triagem: aqui o médico acessa ao resultado do risco cardiovascular do utente, através do número de utente.
                Console.WriteLine();
                Console.Write("Numero de utente: ");
                string nUtente = Console.ReadLine();

                foreach (Consulta consulta1 in consultas1)
                {
                    if (nUtente == consulta1.NumeroUtente)
                    {
                        string resultado = consulta1.CalcularRisco(consulta1.Pas, consulta1.Pad);
                        Console.WriteLine($"Nome de utente: {consulta1.Nome} \nResultado do risco cardiovascular: {resultado} ");

                    }
                }

                //Secção para atualização de medicação e pedido de exames: 
                //Instanciação da classe médico:
                Medico med = new Medico();

                //Método da medicação:
                Console.WriteLine();
                string medicacao = med.Medicacao();
                Console.WriteLine(medicacao);
                Console.WriteLine();

                //Método dos exames:
                string exames = med.SolicitarExames();
                Console.WriteLine(exames);

                //Atualização do status de atendimento: após todos os procedimentos serem feitos, a consulta é encerrada. 
                Console.WriteLine();
                Console.Write("Estado da consulta: "); //Status Fechada.
                consulta.Estado = (Status)Enum.Parse(typeof(Status), Console.ReadLine());

                //Instanciação da classe equipa para adicionar os dados da consulta::
                Equipa equipa = new Equipa();
                equipa.AddConsulta();
            }

            else if (id == "Adm01" && senha == "administrativo")
            {
                //---------Entramos no menu do administrativo:
                //Exibir Concelho e Equipa:
                Console.WriteLine("Equipa: " + equi);
                Console.WriteLine("Concelho: " + concelho);
                Console.WriteLine();

                //Exibir a equipa de colaboradores:
                Console.WriteLine("Membros da equipa: ");
                foreach (Colaborador equipa1 in colaboradores)
                {
                    Console.WriteLine($"Id:{equipa1.Id} | Nome: {equipa1.Nome} | Telemóvel:{equipa1.Telemovel} | Email:{equipa1.Email}.");
                }

                Console.WriteLine("----------------------------------------------------");

                //Instanciação da classe administrativo:
                Administrativo admin = new Administrativo();

                //Método para calendarizar as visitas:
                Console.Write("Deseja calendarizar uma visita? (s/n) ");
                char nova = char.Parse(Console.ReadLine());
                while (nova == 's' | nova == 'S')
                { 
                Console.WriteLine();
                string visitas = admin.CalendarizarVisitas();
                Console.WriteLine(visitas);
                Console.WriteLine();
                Console.Write("Deseja calendarizar uma nova visita? (s/n) ");
                nova = char.Parse(Console.ReadLine());

                };

                //Secção Relatórios:
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.Write("Quer gerar algum relatório? (s/n) ");
                char resp3 = char.Parse(Console.ReadLine());
                while (resp3 == 's' || resp3 == 'S')
                {
                    Console.Write("Qual o relatório que quer gerar?(Risco, Estatistico, Equipa ou Todos) ");
                    string resp4 = Console.ReadLine();

                    if (resp4 == "Risco" || resp4 == "risco")
                    {
                        //Método para gerar o relatório do risco cardiovascular:
                        Console.WriteLine();
                        Console.WriteLine();
                        List<Consulta> pacientesRisco = new List<Consulta>();
                        string relatorioRisco = admin.RelatorioRiscoCardiovascular();
                        Console.WriteLine(relatorioRisco);
                        Console.WriteLine();
                        Console.Write("Quer gerar outro relatório? (s/n) ");
                        resp3 = char.Parse(Console.ReadLine());
                    }
                    else if (resp4 == "Estatistico" || resp4 == "estatistico")
                    {
                        //Método para gerar o relatório estatístico:
                        Console.WriteLine();
                        Console.WriteLine();
                        admin.RelatorioEstatistico(concelho);
                        Console.WriteLine();
                        Console.Write("Quer gerar outro relatório? (s/n) ");
                        resp3 = char.Parse(Console.ReadLine());
                    }
                    else if (resp4 == "Equipa" || resp4 == "equipa")
                    {
                        //Método para gerar o relatório da equipa:
                        Console.WriteLine();
                        Console.WriteLine();
                        string relatorioEquipa = admin.RelatorioEquipa();
                        Console.WriteLine(relatorioEquipa);
                        Console.WriteLine();
                        Console.Write("Quer gerar outro relatório? (s/n) ");
                        resp3 = char.Parse(Console.ReadLine());

                    }
                    else
                    {
                        //Método para gerar o relatório do risco cardiovascular:
                        Console.WriteLine();
                        Console.WriteLine();
                        List<Consulta> pacientesRisco = new List<Consulta>();
                        string relatorioRisco = admin.RelatorioRiscoCardiovascular();
                        Console.WriteLine(relatorioRisco);

                        //Método para gerar o relatório estatístico:
                        Console.WriteLine();
                        Console.WriteLine();
                        admin.RelatorioEstatistico(concelho);

                        //Método para gerar o relatório da equipa:
                        Console.WriteLine();
                        Console.WriteLine();
                        string relatorioEquipa = admin.RelatorioEquipa();
                        Console.WriteLine(relatorioEquipa);
                        Console.WriteLine();
                        Console.Write("Quer gerar outro relatório? (s/n) ");
                        resp3 = char.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Secção relatório finalizada.");
                
            }
               
            else if (id == "Mot01" && senha == "motorista")
            {
                //---------Entramos no menu do Motorista:
                //Exibir Concelho e Equipa:
                Console.WriteLine("Equipa: " + equi);
                Console.WriteLine("Concelho: " + concelho);
                Console.WriteLine();

                //Exibir a equipa de colaboradores:
                Console.WriteLine("Membros da equipa: ");
                foreach (Colaborador equipa1 in colaboradores)
                {                   
                    Console.WriteLine($"Id:{equipa1.Id} | Nome: {equipa1.Nome} | Telemóvel:{equipa1.Telemovel} | Email:{equipa1.Email}.");
                }

                Console.WriteLine("----------------------------------------------------");
            }

            else
            {
                Console.WriteLine("Senha e/ou nome de utilizador incorretos.");
            }
        }
    }
}