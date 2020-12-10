using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    
    public class CalculadoraEstatica
    {
        public static double Somar(double a , double b)
        {
            return a + b;
        }

        public double Multiplicar(double a , double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            return a / b;
        }

    }

    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto;
        public Produto (string nome , double preco , double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        //CONSTRUTOR PADRÃO - APENAS POR DIDÁTICA
        public Produto()
        {

        }
    }
    
    
    class MetodosAtributosEstaticos
    {
        public static void Executar()
        {
            //Por ser um método estático, não preciso criar uma instância para usa-lo
             CalculadoraEstatica.Somar(2, 2);

            //Método não estatico
            CalculadoraEstatica calc = new CalculadoraEstatica();
            calc.Multiplicar(2, 2);

            //Atributo estático
            var produto1 = new Produto("Caneta", 3.0, 0.1);
            
            //O Atributo Desconto só é acessado pela classe, ele não é pela instância
            Console.WriteLine($"{produto1.Nome} tem desconto de: {Produto.Desconto}");


            Produto.Desconto = 0.5;

            var produto2 = new Produto();
            produto2.Nome = "Lápis";
            produto2.Preco = 2.0;
            //produto2.Desconto = 0.5; Não é possível, pois o atributo é estatico
            Console.WriteLine($"{produto2.Nome} tem desconto de: {Produto.Desconto}");



            //Parametro Nomeado (Passando na ordem que eu desejo)
            Console.WriteLine(CalculadoraEstatica.Dividir(b: 2, a: 10)); 

        }
    }
}
