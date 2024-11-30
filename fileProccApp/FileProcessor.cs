public class FileProcessor
{
    public string ReadDataFromFile(string filePath)
    {
        try
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
            // Read data from the file
            string data = File.ReadAllText(filePath);
            return data;
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return null;
        }
    }
    public bool WriteDataToFile(string filePath, string data)
    {
        try
        {
            // Write data to the file
            File.WriteAllText(filePath, data);
            return true;
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Check file permissions.");
            return false;
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Check if the directory exists.");
            return false;
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            return false;
        }
    }
}