using System;

namespace Desafio_03
{
    class Program
    {
        public class Aluno
        {
            public string Nome;
            public int Idade;
            public double Nota;
        }
        static void Main(string[] args)
        {
            // [] inserção de vetor
            Aluno[] vetaluno = new Aluno[3];
            List<Aluno> listaluno = new List<Aluno>();
            Aluno aluno = new Aluno();
            double somavet = 0, somalist = 0;

            //preenchimento de vetor e lista
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Informe o nome do aluno:");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine($"Informe a idade do aluno:");
                aluno.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"Informe a nota do aluno:");
                aluno.Nota = double.Parse(Console.ReadLine());
                Console.WriteLine();

                // salva a nota no vetor de aluno e soma o resultado
                vetaluno[i] = aluno;
                listaluno.Add(aluno);
                somavet = somavet + vetaluno[i].Nota;
                somalist = somalist + listaluno[i].Nota;

            }

                Console.WriteLine($"A Nota total dos alunos são: {somavet}");
                Console.WriteLine($"A Nota total dos alunos são: {somalist}");

        }
    }
}