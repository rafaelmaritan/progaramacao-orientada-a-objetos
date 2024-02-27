public class Programador(int id, string nome, string sobrenome, int idade,
double altura, double salario, string tecnologia)
: Funcionario(id, nome, sobrenome, idade, altura, salario)
{

    public string Tecnologia { get; private set; } = tecnologia;

    public override string Andar()
    {
        return $"{this.Nome} esta andando rápido...";
    }
}