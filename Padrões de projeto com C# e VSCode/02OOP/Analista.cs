public class Analista(int id, string nome, string sobrenome, int idade,
double altura, double salario)
: Funcionario(id, nome, sobrenome, idade, altura, salario)
{

    public override string Andar()
    {
        return $"{this.Nome} esta andando devagar...";
    }
}