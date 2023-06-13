using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class Equipa
    {
        //Propriedades
        public string IdEquipa { get; set; }
        public string Concelho { get; set; }

        public List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();

        public List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();


        //Construtores
        public Equipa()
        {

        }

        public Equipa(string idEquipa, string concelho)
        {
            IdEquipa = idEquipa;
            Concelho = concelho;
        }


        //Métodos
        //Método para adicionar um novo equipamento, seja para uma nova necessidade ou para reposição:
        public void AddEquipamento(string id, string nome) 
        {
            Equipamento equipamentos = new Equipamento(id, nome);
            Equipamentos.Add(equipamentos);
        }

        //Método para remover um equipamento avariado ou sem uso ou para reposição:
        public void RemoveEquipamento(string id, string nome)
        {           
            Equipamento equipamentoRemover = new Equipamento(id, nome);
            foreach (Equipamento equipamento in Equipamentos)
            {
                if (equipamento.IdEquipamento == id && equipamento.Nome == nome)
                {
                    equipamentoRemover = equipamento;
                    
                }
            }
            if (equipamentoRemover != null)
            {
                Equipamentos.Remove(equipamentoRemover);
                Console.WriteLine("Equipamento removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Esse equipamento não existe na lista.");
            }
        }

        //Método para mostrar os equipamentos:
        public void MostrarEquipamento()
        {
            foreach (Equipamento equipamentos in Equipamentos)
            {
                Console.WriteLine($"ID: {equipamentos.IdEquipamento}, Nome: {equipamentos.Nome}");
            }          
        }

        //Métodos para adicionar e remover os dados da consulta na lista consultas:
        public void AddConsulta()
        {
            List<Consulta> consultas = new List<Consulta>();
            consultas.Add(new Consulta());
        }

        public void RemoveConsulta()
        {
            List<Consulta> consultas = new List<Consulta>();
            consultas.Remove(new Consulta());
        }

        //Métodos para adicionar e remover os dados do utente na lista utentes:
        public void AddUtentes()
        {
            List<Utente> utente = new List<Utente>();
            utente.Add(new Utente());
        }

        public void RemoveUtentes()
        {
            List<Utente> utente = new List<Utente>();
            utente.Add(new Utente());
        }
 
    }
}
