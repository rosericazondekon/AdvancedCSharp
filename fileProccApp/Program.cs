FileProcessor fileProcessor = new FileProcessor();

// Example usage with error handling
string inputFilePath = "test.txt";
string outputFilePath = "output.txt";
// Read data from file
string inputData = fileProcessor.ReadDataFromFile(inputFilePath);
if (inputData != null)
{
    bool writeSuccess = fileProcessor.WriteDataToFile(outputFilePath, inputData);
    if (writeSuccess)
    {
        Console.WriteLine("Data written to the output file successfully.");
    }
    else
    {
        Console.WriteLine("Failed to write data to the output file.");
    }
}
else
{
    Console.WriteLine("Failed to read data from the input file.");
}