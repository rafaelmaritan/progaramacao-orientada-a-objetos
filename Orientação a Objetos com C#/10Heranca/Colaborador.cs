using System;

class Colaborador : Pessoa
{
    // Atributos
    private double salario;

    //  Construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
        this.messagePessoa();
        this.messageColaborador();
    }

    // Método
    protected void messageColaborador()
    {
        Console.WriteLine("Salário: " + this.salario);


    }

}