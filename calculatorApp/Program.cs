MathOperations mathOp = new MathOperations();
ResultDisplay resultDisplay = new ResultDisplay();

mathOp.AdditionPerformed += resultDisplay.AdditionPerformedHandler;
mathOp.SubstractionPerformed += resultDisplay.SubstractionPerformedHandler;
mathOp.MultiplicationPerformed += resultDisplay.MultiplicationPerformedHandler;
mathOp.DivisionPerformed += resultDisplay.DivisionPerformedHandler;

while(true){
    Console.WriteLine("\nEnter a Math Operation (addition, substraction, multiplication, division) or 'exit' to end:");
    string action = Console.ReadLine().ToLower();

    if(action == "exit") break;
    double num1 = 0, num2 = 0;
    bool num1_valid = false, num2_valid = false;

    while(!num1_valid) {
        Console.WriteLine("Enter the first number: ");
        try
        {
            num1 = Double.Parse(Console.ReadLine());
            num1_valid = true;
        } 
        catch(FormatException)
        {
            Console.WriteLine("The string you enter is not a valid number!");
        }
    }
    
    while(!num2_valid){
        Console.WriteLine("Enter the second number: ");
        try{
            num2 = Double.Parse(Console.ReadLine());
            num2_valid = true;
        }
        catch(FormatException)
        {
            Console.WriteLine("The string you enter is not a valid number!");
        }
    }

    switch(action){
        case "addition":
            mathOp.add(num1, num2);
            break;
        case "substraction":
            mathOp.subtract(num1, num2);
            break;
        case "multiplication":
            mathOp.multiply(num1, num2);
            break;
        case "division":
            mathOp.divide(num1, num2);
            break;
        default:
            Console.WriteLine("Invalid action. Please enter addition, substraction, multiplication, division, or exit.");
            break;
    }
}