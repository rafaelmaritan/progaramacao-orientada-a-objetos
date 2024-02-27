using System;

class Aluno
{
    public required string nome;
    public double nota1, nota2;

    // Média
    public double media()
    {
        return (nota1 + nota2) / 2;
    }
    // Situação
    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }
    // Mensagem
    public void mensagem()
    {
        double obterMedia = media();
        string obterSituacao = situacao(obterMedia);
        Console.WriteLine(nome + " esta " + obterSituacao + " com média " + obterMedia);
    }
}