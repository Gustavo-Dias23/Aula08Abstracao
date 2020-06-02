using System;

namespace Aula08Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 1200;
            visa.AumentarLimite (visa.limite , 300);
            

            System.Console.WriteLine("Digite a data do pagamento");
            visa.data = DateTime.Parse( Console.ReadLine() );
            System.Console.WriteLine("Data digitada: "+visa.data);
            System.Console.WriteLine(visa.Pagar(900));
        }
    }
}
