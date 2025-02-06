using DesafioEstacionamento.Models;

Console.Write("Digite o preço inicial: ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o preço por hora: ");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
string placa;
int opcao;

Estacionamento estacionamento = new(precoInicial, precoPorHora);

do {
	Estacionamento.ExibirMenu();
	opcao = Convert.ToInt32(Console.ReadLine());

	switch (opcao)
	{
		case 1:
			Console.Write("Digite a placa do veículo: ");
			placa = Console.ReadLine()!;
			estacionamento.Estacionar(placa);
			break;

		case 2:
			Console.Write("Digite a placa do veículo: ");
			placa = Console.ReadLine()!;
			Console.Write("Digite a quantidade de horas: ");
			int horas = Convert.ToInt32(Console.ReadLine());
			estacionamento.Sair(placa, horas);
			break;

		case 3:
			estacionamento.ListarVeiculosEstacionados();
			break;

		case 4:
			Console.WriteLine("Encerrando...");
			break;

		default:
			Console.WriteLine("Opção inválida!");
			break;
	}

	Console.WriteLine("\nPressione qualquer tecla para continuar...");
	Console.ReadKey();
} while (opcao != 4);