namespace DesafioEstacionamento.Models
{
	class Estacionamento(decimal precoInicial, decimal precoPorHora)
	{
		private readonly List<string> VeiculosEstacionado = [];
		private readonly decimal precoInicial = precoInicial;
		private readonly decimal precoPorHora = precoPorHora;

		public void Estacionar(string placa)
		{
			if (!VeiculosEstacionado.Contains(placa))
			{
				VeiculosEstacionado.Add(placa);
				Console.WriteLine("Veículo estacionado com sucesso!");
				return;
			}

			Console.WriteLine("Veículo já está estacionado!");
		}

		public void Sair(string placa, int horas)
		{
			if (!VeiculosEstacionado.Contains(placa))
			{
				Console.WriteLine("Veículo não está estacionado!");
				return;
			}

			VeiculosEstacionado.Remove(placa);
			decimal preco = precoInicial + (horas * precoPorHora);
			Console.WriteLine($"Veículo {placa} saiu do estacionamento. Preço a pagar: R$ {preco}");
		}

		public void ListarVeiculosEstacionados()
		{
			Console.WriteLine("Veículos estacionados:");
			foreach (string veiculo in VeiculosEstacionado)
			{
				Console.WriteLine(veiculo);
			}
		}

		public static void ExibirMenu()
		{
			Console.Clear();
			Console.WriteLine("1 - Estacionar");
			Console.WriteLine("2 - Sair");
			Console.WriteLine("3 - Listar veículos estacionados");
			Console.WriteLine("4 - Encerrar");
			Console.Write("Escolha uma opção: ");
		}
	}
}