using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount bk1 = new BankAccount(1, 100);
        bk1.Deposit();
        bk1.Withdraw();
        bk1.ShowBallance();
    }
    
    public class BankAccount
    {
        private int num {get;set;} 
        private double ballance { get;set;} 

        public BankAccount(int num, int baallance)
        {
            this.num = num;
            this.ballance = baallance;
        }

        public void Deposit()
        {
            int deposit = int.Parse(Console.ReadLine());
            ballance = ballance + deposit;
            Console.WriteLine($"You have just deposited {deposit} \n your current balance is ${ballance}");
        }
        public void Withdraw()
        {
            int withdraw = int.Parse(Console.ReadLine()); 
            if (withdraw > ballance) 
            { 
                Console.WriteLine($"Not enough money for this withdrawing \n your current balance is ${ballance}");
            }
            else
            {
                ballance = ballance - withdraw;
                Console.WriteLine($"You withdrawed ${withdraw} \n your current balance is ${ballance}");
            }
        }
        public void ShowBallance()
        {
            Console.WriteLine($"your current balance is ${ballance}");
        }
    }
}