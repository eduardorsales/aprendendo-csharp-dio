using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public class Aluno : Pessoa //:Pessoa -> herança 
    {
        public Aluno(string nome, string sobrenome) : base(nome, sobrenome)
        {
            //Este construtor é necessário porque na classe pai Pessoa há o construtor
            //que exige esse parâmentos. O comando base passa os parametros para classe pai
            //Para facilitar, pode-se criar construtores vazios na classe pai e filhas para
            //tirar a obrigatoriedade.
        }
        public double Nota { get; set; }

        public override void Apresentar() //override -> polimorfismo
        {
            Console.WriteLine($"Meu nome é {Nome} tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}