using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__DIO.Interfaces;

namespace C__DIO.Models
{
    public class Calculadora:ICalculadora
    {
        public double LerNumero()
        {
            double numero;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero; // Retorna o número se a conversão for bem-sucedida
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número válido:");
            }
            }
        }
        double ICalculadora.Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
            return x + y;
        }

        double ICalculadora.Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
            return x - y;
        }

        double ICalculadora.Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} x {y} = {x*y}");
            return x * y;
        }

        double ICalculadora.Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
            return x / y;
        }
        public void Potencia (double x, double y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }
        public void Seno (double angulo)
        {
            double radiano = angulo*Math.PI/180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno do {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Coseno (double angulo)
        {
            double radiano = angulo*Math.PI/180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno do {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente (double angulo)
        {
            double radiano = angulo*Math.PI/180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente do {angulo}° = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrade de {x} é {raiz}");
        }
    }
}