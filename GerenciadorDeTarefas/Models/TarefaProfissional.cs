namespace GerenciadorDeTarefas.Models
{
    public class TarefaProfissional : Tarefa
    {
        public string Departamento { get; set; }

        public TarefaProfissional(string titulo, int prioridade, string departamento)
            : base(titulo, prioridade)
        {
            Departamento = departamento;
            Categoria = "Profissional";
        }

        public override double CalcularTempoEstimado()
        {
            return Prioridade * 1.2;
        }

        public override string ExibirDetalhes()
        {
            return $"{base.ExibirDetalhes()}\nDepartamento: {Departamento}";
        }
    }
}
