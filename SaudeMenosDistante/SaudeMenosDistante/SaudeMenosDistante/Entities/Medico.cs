using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Medico : Colaborador
    {
        //Propriedades
        //Propriedades herdadas de Colaborador


        //Construtores
        public Medico()
        {

        }

        public Medico(string id, string nome, string morada, string telemovel, string email, double hora, double valorPorHora) 
            : base(id, nome, morada, telemovel, email, hora, valorPorHora)
        {
            
        }


        //Métodos
        //Registo Medicação (adicionar, alterar e/ou remover):
        public string Medicacao()
        {
            List<string> listaMedicacao = new List<string>();

            Console.Write("Medicação (adicionar, remover, nada): ");
            string resposta = Console.ReadLine();

            
            if (resposta == "adicionar" || resposta == "Adicionar")
            {
                Console.Write("Nome da nova medicação: ");
                string medicacao = Console.ReadLine();
                listaMedicacao.Add(medicacao);
                
                foreach (string adicionar in listaMedicacao)
                {
                    return ("Foi adicionado o(s) medicamento(s): " + adicionar);
                }
                return ("Medicação adicionada com sucesso.");
            }
            else if (resposta == "remover" || resposta == "Remover")
            {
                Console.Write("Nome da medicação a ser removida: ");
                string medicacao1 = Console.ReadLine();
                listaMedicacao.Remove(medicacao1);
                
                foreach (string remover in listaMedicacao)
                {
                    return ("Atualização da medicação: " + remover);
                }
                
                Console.Write("Quer adicionar nova medicação? (s/n) ");
                char adicao = char.Parse(Console.ReadLine());
                if (adicao == 's' || adicao == 'S')
                {
                    Console.Write("Nome da nova medicação: ");
                    string medicacao_plus = Console.ReadLine();
                    listaMedicacao.Add(medicacao_plus);
                    
                    foreach (string novaMedicacao in listaMedicacao)
                    {
                        return ("Foi adicionado o(s) medicamento(s): " + novaMedicacao);
                    }
                    return ("Medicação adicionada com sucesso.");                    
                }
                else
                {
                    return ("Não foi registada nenhuma nova medicação.");
                }
            }
            else 
            {
                return ("Não foi registada nenhuma alteração na medicação.");
            }
        }


        //Registo Exames
        public string SolicitarExames()
        {
            Console.Write("Deseja solicitar exames? (s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            List<string> listaExames = new List<string>();

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Indique o(s) exame(s): ");
                string exame = Console.ReadLine();
                listaExames.Add(exame);

                foreach (string addExame in listaExames)
                {
                    return ("Foi adicionado o(s) exame(s): " + addExame);
                }               
            }
            else
            {
                return ("Não foi solicitado nenhum exame.");
            }

            return ("Solicitação de exames terminada");           
        }

        //Método para cálculo do vencimento:
        public override double Vencimento()
        {
            return Hora * ValorPorHora;
        }



    }
}
