using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulamentoOO
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amigo = new SubCelebridade();

        public void MeusAcessos()
        {

            Console.WriteLine("AmigoProximo...");

            //ABAIXO VEJO SE TENHO ACESSO AO ATRIBUTO DA CLASSE PAI(SUBCELEBRIDADE), SENÃO COMENTO O CONSOLE.WRITE DO ATRIB.
            Console.WriteLine(amigo.InfoPublico);//publico

            //Console.WriteLine(amigo.corDosOlhos);//herança

            Console.WriteLine(amigo.NumeroCelular);//está no mesmo projeto

            Console.WriteLine(amigo.JeitoDeFalar);//herança OU mesmo projeto

            //Console.WriteLine(amigo.SegredoFamilia);//herança no mesmo projeto

            //Console.WriteLine(amigo.UsaMuitoPhotoshop); SÓ NA MESMA CLASSE
        }
    }
}
