using System.Data;

try
{
    Console.Write("Enter a mathematical expression: ");
    string expression = Console.ReadLine();
    double result = EvaluateExpression(expression);
    Console.WriteLine($"Result: {result}");
}
catch (FormatException ex)
{
    Console.WriteLine($"Error: {ex.Message}. Invalid expression format.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}. Cannot divide by zero.");
}
catch (ArithmeticException ex)
{
    Console.WriteLine($"Error: {ex.Message}. Invalid arithmetic operation.");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}

static double EvaluateExpression(string expression)
{
    // Using DataTable.Compute for basic expression evaluation
    DataTable table = new DataTable();
    table.Columns.Add("expression", typeof(string), expression);
    DataRow row = table.NewRow();
    table.Rows.Add(row);
    
    // Evaluate the expression using the Compute method
    double result = double.Parse((string)row["expression"]);
    return result;
}