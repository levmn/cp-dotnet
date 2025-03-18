namespace GerenciadorDeTarefas.Models
{
    public abstract class Tarefa(string titulo, int prioridade)
    {
        public string Titulo { get; set; } = titulo;
        protected DateTime DataCriacao { get; set; } = DateTime.Now;
        internal int Prioridade { get; set; } = prioridade;
        private bool _concluida = false;
        protected internal string? Categoria { get; set; }

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
