using System;

namespace _01Conceitos
{

    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa obj = new()
            {
                nome = "Ralf",
                idade = 30
            };
            obj.Mensagem();
        }
    }
}