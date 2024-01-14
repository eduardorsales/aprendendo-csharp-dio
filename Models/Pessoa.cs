using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public class Pessoa
    {
        //construtores
        // public Pessoa()
        // {

        // }
        //construtor recebendo parâmetros e 
        //os associando aos atributos(propriedades)
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        private string _sobrenome;
        
        public string Nome 
        { 
            get => _nome.ToUpper(); //body expressions - ter o código em uma linha pelo atribuidor =>
                // {
                //     return _nome.ToUpper();
                // }

            set
            {
                if (value == ""){
                    throw new ArgumentException("Nome inválido. O nome não pode ser vazio.");
                }
                
                _nome = value;
            } 
        }
        public string Sobrenome 
        { 
            get => _sobrenome;

            set
            {
                if (value == ""){
                    throw new ArgumentException("Nome inválido. O sobrenome não pode ser vazio.");
                }
                
                _sobrenome = value;
            } 
        }
        public string NomeCompleto => $"{_nome} {_sobrenome}".ToUpper();
     
        public int Idade 
        { 
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade inválida. A idade não pode ser inferior a zero.");
                }
                _idade = value;
            } 
        }

        public virtual void Apresentar() //virtual -> polimorfismo
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}