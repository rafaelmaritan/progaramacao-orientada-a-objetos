using System;

class Exemplo
{

    // Atributo estatico
    public static string nome = "Rafa";
    // Voce pode ter acesso sem instanciar o objeto
    public static void soma(int n1, int n2)
    {
        Console.WriteLine(n1 + n2);
    }
}