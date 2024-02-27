using System;
using System.Linq.Expressions;

class Pessoa
{
    public required string nome;
    public double peso;
    public double altura;

    public double CalcularImc(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    public string VerificaImc(double imc)
    {
        string verificacao;
        if (imc < 18.5)
        {
            verificacao = "IMC Abaixo do peso";
        }
        else
        if (imc < 25)
        {
            verificacao = "Peso Normal";
        }
        else
        if (imc < 30)
        {
            verificacao = "Acima do peso";
        }
        else
        if (imc < 35)
        {
            verificacao = "Obesidade I";
        }
        else
        if (imc < 40)
        {
            verificacao = "Obesidade II";
        }
        else
        if (imc >= 40)
        {
            verificacao = "Obesidade III";
        }
        else
        {
            verificacao = "";
        }
        return verificacao;
    }

    public void Mensagem()
    {
        var imc = CalcularImc(peso, altura);
        Console.WriteLine(VerificaImc(imc));

    }
}