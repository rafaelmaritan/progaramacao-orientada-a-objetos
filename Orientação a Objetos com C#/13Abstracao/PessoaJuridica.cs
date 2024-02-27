using System;

class PessoaJuridica : Padrao
{
    public override void TaxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para PJ é R$" + valor * 0.2);
    }
}