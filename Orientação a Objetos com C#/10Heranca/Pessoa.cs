using System;

class Pessoa
{
    // Atributos
    protected string? nome;
    protected int idade;

    // Método
    protected void messagePessoa()
    {
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Idade: " + this.idade);

    }

}