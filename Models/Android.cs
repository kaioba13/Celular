using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Celular.Models;

namespace Celular.Models
{
    public class Android : Smartphone
    {
        public Android(string numero) : base(numero)
        {

        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"{nome} foi instalado com sucesso");
        }
    }
}