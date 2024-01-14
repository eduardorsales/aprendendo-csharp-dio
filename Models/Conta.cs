using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public abstract class Conta //Abstract -> esta classe não pode ser instanciada, apenas herdada
    {
        protected decimal saldo; //protected -> protegido de alterações externas com excecão das suas classes filhas

        public abstract void Creditar (decimal valor); //métodos abstratos não tem corpo e devem ser desenvolvidos nas classes que herdarem

        public void ExibirSaldo ()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }
    }
}