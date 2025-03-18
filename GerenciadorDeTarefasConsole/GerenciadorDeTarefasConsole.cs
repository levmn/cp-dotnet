using System;
using GerenciadorDeTarefas.Models;
using GerenciadorDeTarefas.Services;

namespace GerenciadorDeTarefasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Gerenciamento de Tarefas ===\n");

            var gerenciador = new GerenciadorTarefas();

            var tarefa1 = new TarefaPessoal("Estudar C#", 3, "João");
            var tarefa2 = new TarefaProfissional("Implementar API", 5, "TI");
            var tarefa3 = new TarefaPessoal("Fazer exercícios", 2, "Maria");

            gerenciador.AdicionarTarefa(tarefa1);
            gerenciador.AdicionarTarefa(tarefa2);
            gerenciador.AdicionarTarefa(tarefa3);

            tarefa1.Concluir();

            Console.WriteLine("Lista de todas as tarefas:");
            foreach (var tarefa in gerenciador.ObterTodasTarefas())
            {
                Console.WriteLine(tarefa.ExibirDetalhes());
                Console.WriteLine($"Tempo estimado: {tarefa.CalcularTempoEstimado()} horas");
                Console.WriteLine($"Status: {(tarefa.EstaConcluida ? "Concluída" : "Pendente")}");
                Console.WriteLine();
            }

            Console.WriteLine(
                $"Tempo total estimado para todas as tarefas: {gerenciador.CalcularTempoTotalEstimado()} horas"
            );

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
