using System;


class Aluno
{
    // Atributos
    private double nota1, nota2;
    // média
    private double media()
    {
        return (nota1 + nota2) / 2;
    }

    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A médias é " + media());
    }
}