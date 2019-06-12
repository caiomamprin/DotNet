namespace ProjetoWeb.Models
{
    public class Familia
    {
        public GrauParentesco GrauParentesco;
        public string nome;
        public int idade;
        public Documentos Documentos { get; set; }
    }

    public enum GrauParentesco
    {
        Pai,
        Mae,
        Tio,
        Irmao
    }
}
