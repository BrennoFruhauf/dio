namespace DesafioHospedagem.Models
{
    public class Reserva(Suite suite, int diasReservados)
    {
        private List<Pessoa> _hospedes = [];
        private readonly Suite _suite = suite;
        private readonly int _diasReservados = diasReservados;

        public void CadastrarHospedes(List<Pessoa> pessoas) {
            if (pessoas.Count > _suite.Capacidade) {
                throw new NotSupportedException("Quantidade de hóspedes excede a capacidade da suíte!");
            }
            _hospedes = pessoas;
        }

        public int ObterQuantidadeHospedes() => _hospedes.Count;
        public decimal CalcularValorDiaria()
        {
            decimal valorTotalDaDiaria = _suite.ValorDiaria * _diasReservados;
            return _diasReservados >= 10 ? valorTotalDaDiaria * 0.9M : valorTotalDaDiaria;
        }
    }
}