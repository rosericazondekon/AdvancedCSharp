
Console.Write("Enter your data: ");
string data = Console.ReadLine();

DataProcessingService dataProcessingService = new DataProcessingService(new UserInputProcessor());
dataProcessingService.ProcessInput(data);