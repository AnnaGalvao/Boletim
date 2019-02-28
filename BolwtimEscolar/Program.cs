using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolwtimEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string caderno = "";
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double nota4 = 0;
            double total = 0;


            Console.WriteLine("----Boletim----");

            Console.Write("Digite o nome do aluno");
            nome = Console.ReadLine();

            Console.Write("Aluno mostrou caderno");
            caderno = Console.ReadLine();

            Console.WriteLine("Nota 1");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nota 2");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nota 3");
            nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nota 4");
            nota4 = Convert.ToInt32(Console.ReadLine());

            // total = (double)(nota1 + nota2 + nota3 + nota4) / 4;

            if (caderno == "sim")
            {
                total = (nota1 + nota2 + nota3 + nota4) / 4 + 1;
            }
            else
            {
                total = (nota1 + nota2 + nota3 + nota4) / 4;
            }
            if (total > 5)
            {
                Console.WriteLine("Aluno Aprovado");
                Console.WriteLine("Com nota de: " + total);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
                Console.WriteLine("Com nota de: " + total);
            }

            Console.WriteLine(total);

            Console.ReadLine();

        }
    }
}

