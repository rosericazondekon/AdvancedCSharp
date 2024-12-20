try 
{
    Console.Write("Input a string: ");
    string input = Console.ReadLine();
    string result = ConvertToUppercase(input);
    Console.WriteLine("Uppercase string: " + result);
} 
catch (NullReferenceException) 
{
    Console.WriteLine("Error: Input string is null.");
} 
catch (ArgumentException ex) 
{
    Console.WriteLine("Error: " + ex.Message);
} catch (Exception ex) 
{
    Console.WriteLine("An error occurred: " + ex.Message);
}


static string ConvertToUppercase(string input) {
    if (string.IsNullOrEmpty(input)) 
    {
        throw new ArgumentException("Input string is null or empty.");
    }
    return input.ToUpper();
}