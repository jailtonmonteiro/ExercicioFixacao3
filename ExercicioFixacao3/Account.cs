using System.Globalization;

namespace ExercicioFixacao3
{
    internal class Account
    {
        string _name;
        int Number { get; set; }
        double Balance { get; set; }
        
        public Account(string name, int number) 
        {
            this._name = name;
            this.Number = number;
        }

        public void Deposit()
        {
            Console.Write("\nVALOR DEPÓSITO: ");
            double value = double.Parse(Console.ReadLine());
            Balance = Balance + value;
            printData();
        }
        public void Withdraw()
        {
            Console.Write("\nVALOR SAQUE: ");
            double value = double.Parse(Console.ReadLine());
            Balance = Balance - 5 - value;
            printData();
        }
        public void printData()
        {
            Console.WriteLine($"\nCONTA: {Number}\nTitular: {Nome}\nSaldo: {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }


        public string Nome
        {
            get { return this._name; }
            set
            {
                if(value != null)
                {
                    this._name = value;
                }
            }
        }
    }
}
