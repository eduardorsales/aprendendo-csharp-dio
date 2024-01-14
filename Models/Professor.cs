using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public sealed class Professor : Pessoa //:Pessoa -> herança -- sealed -> uma classe selada não gera classes filhas, ou seja, ela não pode ser herdada.
    {
        public Professor(string nome, string sobrenome) : base(nome, sobrenome)
        {
            //Este construtor é necessário porque na classe pai Pessoa há o construtor
            //que exige esse parâmentos. O comando base passa os parametros para classe pai
            //Para facilitar, pode-se criar construtores vazios na classe pai e filhas para
            //tirar a obrigatoriedade.
        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar() //override -> polimorfismo -- sealed -> um método selado impede que a classe filha a sobrescreva
        {
            Console.WriteLine ($"Meu nome é {Nome} tenho {Idade} anos e meu salário é {Salario}");
        }
    }
}