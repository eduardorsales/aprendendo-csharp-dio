using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> ListaAlunos { get; set; }

        public void AdicionarAlunos (Pessoa aluno)
        {
            ListaAlunos.Add(aluno);
        }

        public int QuantidadeDeAlunosMatriculados()
        {
            int quantidade = ListaAlunos.Count();
            return quantidade;
        }

        public void RemoverAluno (Pessoa aluno)
        {
            ListaAlunos.Remove(aluno);
        }

        public void ListarAlunos ()
        {
            Console.WriteLine($"Lista de alunos matrículados em {Nome}");
            
            for (int i = 0; i < ListaAlunos.Count; i++)
            {
                         //concatenação
                // string texto = "Nº " + (i+1) + " - " + ListaAlunos[i].NomeCompleto;
                // Console.WriteLine(texto);
                        //interpolação
                string texto = $"Nº{(i+1)} - {ListaAlunos[i].NomeCompleto}";
                Console.WriteLine(texto);

            }
            
            // foreach (Pessoa aluno in ListaAlunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }
    }
}