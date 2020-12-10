using System;
using System.Collections.Generic;
using System.Text;
using EncapsulamentoOO;

namespace CursoCSharp.OO_OrientacaoAObjetos
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido");


            //ABAIXO VEJO SE TENHO ACESSO AO ATRIBUTO DA CLASSE PAI(SUBCELEBRIDADE), SENÃO COMENTO O CONSOLE.WRITE DO ATRIB.
            Console.WriteLine(InfoPublico);//publico

            Console.WriteLine(corDosOlhos);//herança

            //Console.WriteLine(NumeroCelular);//está no mesmo projeto

            Console.WriteLine(JeitoDeFalar);//herança OU mesmo projeto

            //Console.WriteLine(SegredoFamilia);//herança no mesmo projeto

            //Console.WriteLine(UsaMuitoPhotoshop); SÓ NA MESMA CLASSE
        }

    }

    public class AmigoNaoProximo
    {
        public readonly SubCelebridade amigoNaoProximo = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoNaoProximo...");


            //ABAIXO VEJO SE TENHO ACESSO AO ATRIBUTO DA CLASSE PAI(SUBCELEBRIDADE), SENÃO COMENTO O CONSOLE.WRITE DO ATRIB.
            Console.WriteLine(amigoNaoProximo.InfoPublico);//publico

            //Console.WriteLine(amigoNaoProximo.corDosOlhos);//herança

            //Console.WriteLine(amigoNaoProximo.NumeroCelular);//está no mesmo projeto

            //Console.WriteLine(amigoNaoProximo.JeitoDeFalar);//herança OU mesmo projeto

            //Console.WriteLine(amigoNaoProximo.SegredoFamilia);//herança no mesmo projeto

            //Console.WriteLine(UsaMuitoPhotoshop); SÓ NA MESMA CLASSE
        }
    }

    class Encapsulamento
    {


        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            //FilhoReconhecido filho = new FilhoReconhecido()//
            //filho.MeusAcessos();
            //CHAMO DIRETO NA INSTANCIA, SEM USAR UMA VARIAVEL - COMO A VARIAVEL SUB DA LINHA 61
            new FilhoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoNaoProximo().MeusAcessos();

            int j;
            int i=0;

            j = i;
            i = j + 1;
            Console.WriteLine(i);

        }
    }
}
