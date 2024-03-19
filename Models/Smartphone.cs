using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        public string Modelo { get; set; }

        public string Imei { get; set; }

        public int Memoria { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void InfoSmartPhone()
        {
            Console.WriteLine($"Modelo:{Modelo}, Numero: {Numero}, Imei: {Imei} e Memória: {Memoria}GB");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}