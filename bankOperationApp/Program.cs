
using System;

BankAccount account = new BankAccount();

while (true)
{
    Console.WriteLine("\nMenu (Choose a number)!");
    Console.WriteLine("1. Create Account\n2. Withdraw\n3. Deposit\n4.Exit\n");
    Console.Write("Menu> ");
    try{
        int userInput = int.Parse(Console.ReadLine());
        var choice = (Menus)(userInput - 1);
        if(choice == Menus.Exit) break;

        switch (choice){
            case Menus.Create:
                Console.Write("Specify new account balance: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                account = new BankAccount(amount);
                break;
            case Menus.Deposit:
                Console.Write("How much do you want to deposit? ");
                decimal d_amount = Convert.ToDecimal(Console.ReadLine());
                account.Deposit(d_amount);
                break;
            case Menus.Withdraw:
                Console.Write("How much do you want to withdraw? ");
                decimal w_amount = Convert.ToDecimal(Console.ReadLine());
                account.Withdraw(w_amount);
                break;
            default:
                Console.WriteLine("Please, enter a valid number");
                break;
        }
    }
    catch(Exception ex){
        Console.WriteLine(ex.ToString());
    }
    
    

}



