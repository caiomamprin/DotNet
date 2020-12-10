using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];

            alunos[0] = "Caio";
            alunos[1] = "Mariana";
            alunos[2] = "Amarilis";
            alunos[3] = "Fernando";
            alunos[4] = "Lucila";

            foreach(var aluno in alunos)
            {
                Console.WriteLine($"Olá {aluno}");
            }

            double somatorio = 0;
            double[] notas = { 9.8, 8, 7, 10, 9 };

            foreach(var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            Console.WriteLine($"Média {media}");


        }
    }
}
