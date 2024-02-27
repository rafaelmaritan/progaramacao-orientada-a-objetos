using System;

class Gerente : Imposto
{

    // Metodos
    public override void valeAlimentacao(double salario)
    {

        Console.WriteLine("Desconto gerente do vale alimentacao R$" + (salario * 0.15));
    }

}