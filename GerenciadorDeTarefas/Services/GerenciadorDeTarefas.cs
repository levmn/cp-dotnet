using System.Collections.Generic;
using GerenciadorDeTarefas.Models;

namespace GerenciadorDeTarefas.Services
{
    public class GerenciadorTarefas
    {
        private readonly List<Tarefa> _tarefas;

        public GerenciadorTarefas()
        {
            _tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            _tarefas.Add(tarefa);
        }

        public List<Tarefa> ObterTodasTarefas()
        {
            return _tarefas;
        }

        public double CalcularTempoTotalEstimado()
        {
            double tempoTotal = 0;
            foreach (var tarefa in _tarefas)
            {
                tempoTotal += tarefa.CalcularTempoEstimado();
            }
            return tempoTotal;
        }
    }
}
