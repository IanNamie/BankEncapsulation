namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            double deposite = 0;
            //Allow the user of the application to Deposit money and retrieve their balance through the console.
            
                Console.WriteLine("Welcome to Namie banks of America, how much would you like to deposite today?");
                deposite = double.Parse(Console.ReadLine());
                bankAccount.Deposite(deposite);
            

            Console.WriteLine($"Great you deposited ${deposite} into your account.");
            Console.WriteLine($"That makes your balence $ {bankAccount.GetBalance()}. Thanks for coming to Namie Banking!");


        }
    }
}
