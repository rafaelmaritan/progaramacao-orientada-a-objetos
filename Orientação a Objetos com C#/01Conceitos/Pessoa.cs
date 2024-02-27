using System;

// Molde
class Pessoa
{
    // Atributos
    // public - qualquer arquivo tem acesso
    public required string nome;
    public int idade;

    // Métodos
    public void Mensagem()
    {
        Console.WriteLine("Ola " + nome + " voce tem " + idade + " anos");
    }
}