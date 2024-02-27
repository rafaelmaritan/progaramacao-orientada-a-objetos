using System;

class Pessoa
{
    private readonly string nome;

    // Constructor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
        this.nome = nome;
        Console.WriteLine(this.nome);

    }
}