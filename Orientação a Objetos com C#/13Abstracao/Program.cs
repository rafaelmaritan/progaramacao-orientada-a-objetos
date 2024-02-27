// See https://aka.ms/new-console-template for more information
using System.Drawing;

Console.WriteLine("Hello, World!");

PessoaFisica pf = new();
pf.CalculoPoupanca(1000, 0.1);
pf.TaxaEmprestimo(1000);


PessoaJuridica pj = new();
pj.CalculoPoupanca(1000, 0.1);
pj.TaxaEmprestimo(1000);
