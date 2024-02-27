public abstract class Funcionario(int id, string nome, string sobrenome, int idade, double altura, double salario) : Pessoa(nome, sobrenome, idade, altura), IContrato
{
    public double Salario { get; private set; } = salario;
    public int Id { get; private set; } = id;
    public void Almocar()
    {
        throw new NotImplementedException();
    }

    public void BaterPonto()
    {
        throw new NotImplementedException();
    }

    public string Trabalhar()
    {
        return $"{Nome} esta trabalhando...";
    }
}