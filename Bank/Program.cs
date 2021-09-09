using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaDuda = new ContaCorrente("Duda", 1234, 789, 200);

            ContaCorrente contaDoGui = new ContaCorrente("Gui", 4321, 987, 100);

            ContaCorrente contaDoLucas = new ContaCorrente("Lucas", 1111, 222, 333);

           Console.WriteLine("O titular da conta é:" + contaDaDuda.titular);
           Console.WriteLine("O titular da conta é:" + contaDoGui.titular);
           Console.WriteLine("O titular da conta é:" + contaDoLucas.titular);
        }
    }
}
