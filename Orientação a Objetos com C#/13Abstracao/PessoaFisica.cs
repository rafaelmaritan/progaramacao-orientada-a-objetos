using System;

class PessoaFisica : Padrao
{
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para PF é R$" + valor * 0.1);
    }
}