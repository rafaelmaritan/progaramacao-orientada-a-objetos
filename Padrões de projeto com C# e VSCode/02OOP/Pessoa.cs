public abstract class Pessoa(string nome, string sobrenome, int idade, double altura)
{
    public string Nome { get; private set; } = nome;
    public string Sobrenome { get; private set; } = sobrenome;
    public int Idade { get; private set; } = idade;
    public double Altura { get; private set; } = altura;

    public virtual string Andar()
    {
        return $"{this.Nome} esta andando...";
    }
}