using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulamentoOO
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido...");

            //ABAIXO VEJO SE TENHO ACESSO AO ATRIBUTO DA CLASSE PAI(SUBCELEBRIDADE), SENÃO COMENTO O CONSOLE.WRITE DO ATRIB.
            Console.WriteLine(InfoPublico);//publico
            
            Console.WriteLine(corDosOlhos);//herança
            
            Console.WriteLine(NumeroCelular);//está no mesmo projeto
            
            Console.WriteLine(JeitoDeFalar);//herança OU mesmo projeto
            
            Console.WriteLine(SegredoFamilia);//herança no mesmo projeto
            
            //Console.WriteLine(UsaMuitoPhotoshop); SÓ NA MESMA CLASSE
        }
    }
}
