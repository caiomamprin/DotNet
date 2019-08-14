namespace Exemplo
{
  public class Conta
  {
    // antes do C# 6.0
    // public double Saldo { get; private set; } = 1000;
    // agora no C# 6.0
    private double _saldo; // armazena
    public double Saldo { get { return _saldo; } } // mapeamento
    public string Cliente { get; set; }
    public void Sacar(double valor)
    {
      _saldo = _saldo - valor;
    }
    public void Depositar(double valor)
    {
      _saldo = _saldo + valor;
    }
    public Conta()
    {
      // Saldo = 1000;
    }
    //public double getSaldo()
    //{
    //  return Saldo;
    //}
  }
}
