using System;

namespace GerenciadorDeTarefas.Models
{
    public abstract class Tarefa
    {
        public string Titulo { get; set; }
        protected DateTime DataCriacao { get; set; }
        internal int Prioridade { get; set; }
        private bool _concluida;
        protected internal string Categoria { get; set; }

        public Tarefa(string titulo, int prioridade)
        {
            Titulo = titulo;
            Prioridade = prioridade;
            DataCriacao = DateTime.Now;
            _concluida = false;
        }

        public virtual string ExibirDetalhes()
        {
            return $"Título: {Titulo}\n"
                + $"Data de criação: {DataCriacao:dd/MM/yyyy}\n"
                + $"Prioridade: {Prioridade}\n"
                + $"Concluída: {(_concluida ? "Sim" : "Não")}\n"
                + $"Categoria: {Categoria}";
        }

        public abstract double CalcularTempoEstimado();

        public void Concluir()
        {
            _concluida = true;
        }

        public bool EstaConcluida => _concluida;

        private void Resetar()
        {
            _concluida = false;
        }
    }
}
