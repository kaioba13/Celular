using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public class Iphone
    {
        public Iphone(string numero) : base(numero)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"{nome} foi instalado com sucesso");
        }
    }
}