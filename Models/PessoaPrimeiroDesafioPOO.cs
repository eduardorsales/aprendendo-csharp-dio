using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroDesafioPOO.Models
{
class Pessoa
{
        public string nome;
        public int idade;

        public Pessoa(string n, int i)
    {
      this.nome = n;
      this.idade = i;
    }public int MyProperty { get; set; }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}
}