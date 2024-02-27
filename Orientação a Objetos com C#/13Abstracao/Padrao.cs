using System;

abstract class Padrao
{

    // Obrigatorio
    public abstract void TaxaEmprestimo(double valor);

    // Opcional
    public void CalculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança: " + taxa * valor);
    }
}