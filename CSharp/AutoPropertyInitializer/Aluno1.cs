using System;

public class Aluno1
{
    private int _matricula;
    private string _nome;

    public Aluno1(int matricula, string nome)
    {
        this._matricula = matricula;
        this._nome = nome;
    }

    public Aluno1()
    {
        this._matricula = 0;
        this._nome = "sem nome";
    }

    public int Matricula
    {
        get { return this._matricula; }
        set { this._matricula = value; }
    }
    public string Nome
    {
        get { return this._nome; }
        set { this._nome = value; }
    }
  

}
