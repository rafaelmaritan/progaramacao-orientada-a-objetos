using System;

class Pessoa
{
    public void Apresentar()
    {
        Console.WriteLine("Olá!");
    }
    // Metodo 02
    public void Apresentar(string nome)
    {
        Console.WriteLine("Olá " + nome + "!");
    }
    // Metodo 03
    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + "! Voce tem " + idade + " anos");
    }
}