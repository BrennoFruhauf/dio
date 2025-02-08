using DesafioHospedagem.Models;

List<Suite> suites = [
	new (tipoSuite: "Suite Presidencial", capacidade: 4, valorDiaria: 1000),
	new (tipoSuite: "Suite Luxo", capacidade: 2, valorDiaria: 500),
	new (tipoSuite: "Suite Simples", capacidade: 1, valorDiaria: 250),
];

Suite? suiteSelecionada = null;

do {
	Console.Clear();
	foreach (Suite suite in suites)
		Console.WriteLine($"Tipo: {suite.TipoSuite} | Capacidade: {suite.Capacidade} | Valor diária: {suite.ValorDiaria}");

	Console.Write("Digite o tipo de suite válido: ");
	string tipoSuite = Console.ReadLine() ?? string.Empty;

	suiteSelecionada = suites.Find(suite => suite.TipoSuite.Contains(tipoSuite));

	if (suiteSelecionada is not null) break;
} while (true);

Console.Write("Digite a quantidade de dias que deseja reservar: ");
int diasReservados = int.Parse(Console.ReadLine()!);

Reserva reserva = new(suiteSelecionada, diasReservados);
List<Pessoa> hospedes = [];

do {
	Console.Write("Digite o nome e sobrenome do hóspede ou 'sair' para finalizar: ");
	string[] texto = Console.ReadLine()!.Split(' ');

	if (texto[0].ToLower().Equals("sair")) break;

	hospedes.Add(new Pessoa(nome: texto[0], sobrenome: texto[1]));
} while (hospedes.Count < suiteSelecionada.Capacidade);

reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorDiaria().ToString("C")}");
