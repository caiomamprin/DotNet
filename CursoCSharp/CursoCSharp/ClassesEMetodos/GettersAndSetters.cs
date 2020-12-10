using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo;
        
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        //CONSTRUTOR PADRÃO (FEITO APENAS POR DIDÁTICA)
        public Moto()
        {

        }

        //GETTERS AND SETTERS 
        

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        
        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            //SE O VALOR É NEGATIVO , EU ALTERO PARA POSITIVO
            Cilindrada = Math.Abs(cilindrada);
        }


    }

    class GettersAndSetters
    {
        public static void Executar()
        {
            var moto1 = new Moto();

            moto1.SetMarca("Honda");
            Console.WriteLine(moto1.GetMarca());
            moto1.SetModelo("Hornet");
            moto1.SetCilindrada(-600);
            Console.WriteLine($"Moto: {moto1.GetMarca()} {moto1.GetModelo()} {moto1.GetCilindrada()} cilidradas.");
        }
    }
}
