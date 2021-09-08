using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaDuda = new ContaCorrente();

           contaDaDuda.titular = "Duda";
           contaDaDuda.agencia = 1234;
           contaDaDuda.conta = 789;
           contaDaDuda.saldo = 100.50;

           ContaCorrente contaDoLucas = new ContaCorrente();
           contaDoLucas.titular = "Lucas";
           contaDoLucas.agencia = 4321;
           contaDoLucas.conta = 987;
           contaDoLucas.saldo = 100.50;

           Console.WriteLine("O titular da conta é:" + contaDaDuda.titular);
           Console.WriteLine("O titular da conta é:" + contaDoLucas.titular);
        }
    }
}
