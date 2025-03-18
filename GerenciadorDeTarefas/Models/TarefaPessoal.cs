namespace GerenciadorDeTarefas.Models
{
    public class TarefaPessoal : Tarefa
    {
        private protected string _responsavel;

        public TarefaPessoal(string titulo, int prioridade, string responsavel)
            : base(titulo, prioridade)
        {
            _responsavel = responsavel;
            Categoria = "Pessoal";
        }

        public override double CalcularTempoEstimado()
        {
            return Prioridade * 0.5;
        }

        public override string ExibirDetalhes()
        {
            return $"{base.ExibirDetalhes()}\nResponsável: {_responsavel}";
        }
    }
}
