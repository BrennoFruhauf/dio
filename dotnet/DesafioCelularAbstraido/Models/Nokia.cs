using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelularAbstraido.Models
{
    public class Nokia(string numero, string modelo, string IMEI, int memoria) : Smartphone(numero, modelo, IMEI, memoria)
    {
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"O aplicativo {nome} foi instalado no Nokia modelo {Modelo}, memoria {Memoria} e IMEI {IMEI}");
        }
    }
}