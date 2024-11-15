using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// namespace calculatorApp;
public delegate void OperationEventHandler(double x, double y, double res);
public class MathOperations
{
    public event OperationEventHandler? AdditionPerformed;
    public event OperationEventHandler? SubstractionPerformed;
    public event OperationEventHandler? MultiplicationPerformed;
    public event OperationEventHandler? DivisionPerformed;
    public void add(double x, double y){
        double res = x + y;
        AdditionPerformed?.Invoke(x, y, res);
    }
    public void subtract(double x, double y){
        double res = x - y;
        SubstractionPerformed?.Invoke(x, y, res);
    }
    public void multiply(double x, double y){
        double res = x * y;
        MultiplicationPerformed?.Invoke(x, y, res);
    }
    public void divide(double x, double y){
        double res = y != 0 ? x / y : double.NaN;
        DivisionPerformed?.Invoke(x, y, res);
    }
}
