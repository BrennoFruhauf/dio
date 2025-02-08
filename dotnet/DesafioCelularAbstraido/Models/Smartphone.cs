using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelularAbstraido.Models
{
    public abstract class Smartphone(string numero, string modelo, string IMEI, int memoria)
    {
        public string Numero { get; set; } = numero;
        protected readonly string Modelo = modelo;
        protected readonly string IMEI = IMEI;
        protected readonly int Memoria = memoria;

        public void Ligar()
        {
            Console.WriteLine($"O smartphone modelo {Modelo}, memoria {Memoria} e IMEI {IMEI} está ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"O número {Numero} esta recebendo uma ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}