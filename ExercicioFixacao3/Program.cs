using System;

namespace ExercicioFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, opt;
            string name;
            double value;

            Console.Write("Numero da conta: ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular: ");
            name = Console.ReadLine();

            Console.Write("Deposito inicial (s/n): ");
            string op = Console.ReadLine();

            Account account = new Account(name, number);
            
            if(op == "s")
            {
                account.Deposit();
                account.printData();
            }
            else if(op == "n")
            {
                account.printData();
            }
            else
            {
                Console.WriteLine("Opção incorreta digitada!");
            }
            do
            {
                Console.Write("\n1 - DEPOSITAR\n2 - SACAR\n3 - SAIR\n\nSelecione uma opção: ");
                opt = int.Parse(Console.ReadLine());

                switch(opt)
                {
                    case 1:
                        account.Deposit();
                        break;
                    case 2:
                        account.Withdraw();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("OPÇÃO SELECIONADA INVÁLIDA");
                        break;
                }
            }while(opt != 3);

        }
    }
}