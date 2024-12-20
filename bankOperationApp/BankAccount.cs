using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BankAccount
{
    private decimal _balance;
    public BankAccount()
    {
        _balance = 1000m;
        Console.WriteLine($"Standard Account created!\nInitial Balance: {GetBalance()}");
    }
    public BankAccount(decimal balance)
    {
        _balance = balance;
        Console.WriteLine($"Custom Account successfully created!\nInitial Balance: {GetBalance()}");
    }
    public decimal GetBalance()
    {
        return _balance;
    }
    public void Withdraw(decimal amount)
    {
        if(_balance - amount < 0)
        {
            throw new InsufficientFundsException($"Insufficient Fund, Balance: {GetBalance()}");
        }
        if(amount <= 0)
        {
            throw new TransactionFailedException($"Transaction Failed: Transaction amount must be positive!");
        }
        _balance -= amount;
        Console.WriteLine($"Withdrawal successful. New balance: {GetBalance()}");
    }
    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new TransactionFailedException($"Transaction Failed: Transaction amount must be positive!");
        }
        _balance += amount;
        Console.WriteLine($"Deposit successful. New balance: {GetBalance()}");
    }
}