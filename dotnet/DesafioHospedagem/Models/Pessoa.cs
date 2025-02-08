namespace DesafioHospedagem.Models
{
    public class Pessoa(string nome, string sobrenome)
    {
        public string Nome { get; } = nome;
        public string Sobrenome { get; } = sobrenome;
    }
}