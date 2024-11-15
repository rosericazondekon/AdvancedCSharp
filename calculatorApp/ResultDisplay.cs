using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// namespace calculatorApp;
public class ResultDisplay
{
    public void AdditionPerformedHandler(double x, double y, double res){
        Console.WriteLine($"Addition result: {x} + {y} = {res}");
    }
    public void SubstractionPerformedHandler(double x, double y, double res){
        Console.WriteLine($"Substraction result: {x} - {y} = {res}");
    }
    public void MultiplicationPerformedHandler(double x, double y, double res){
        Console.WriteLine($"Multiplication result: {x} * {y} = {res}");
    }
    public void DivisionPerformedHandler(double x, double y, double res){
        Console.WriteLine($"Division result: {x} / {y} = {res}");
    }
}