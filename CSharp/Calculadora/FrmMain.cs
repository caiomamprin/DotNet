using System;
using System.Windows.Forms;
using static System.Convert;

namespace Calculadora
{
  //Programe para Interfaces / Abstrações
  //Nunca programe para classes concretas
  //Form -> Interface -> Calc

  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private int x()
    {
      return ToInt32(textBox1.Text);
    }

    private int y()
    {
      return ToInt32(textBox2.Text);
    }

    ICalc c = new Calc();

    private void button1_Click(object sender, EventArgs e)
    {      
      int r = c.Somar(x(), y());
      textBox3.Text = r.ToString();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int r = c.Multiplicar(x(), y());
      textBox3.Text = r.ToString();
    }
  }
}
