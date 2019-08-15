using System;

namespace Calculadora
{
  public class Calc : object, ICalc
  {
    public Calc()
    {
    }

    public int Somar(int x, int y)
    {
      return x + y;
    }

    public int Multiplicar(int x, int y)
    {
      return x * y;
    }
  }
}