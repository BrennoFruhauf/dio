namespace DesafioHospedagem.Models
{
    public class Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        public string TipoSuite { get; } = tipoSuite;
        public int Capacidade { get; } = capacidade;
        public decimal ValorDiaria { get; } = valorDiaria;
    }
}