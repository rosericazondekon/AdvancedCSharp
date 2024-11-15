using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class CustomLogger : ILogger
{
    public IDisposable BeginScope<TState>(TState state)
    {
        // This method allows for the creation of scopes, which can be useful for structured logging.
        // If you don't need scopes, you can return `null`, or an empty `IDisposable` object.
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        // This method determines whether logging is enabled at a particular level.
        // Adjust it as needed. Here, it is set to always return true.
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    {
        // This is the core logging function for `ILogger`, which must be implemented.
        // It will log based on the provided log level, state, and optional exception.
        if (formatter == null)
        {
            throw new ArgumentNullException(nameof(formatter));
        }

        var message = formatter(state, exception);

        if (!string.IsNullOrEmpty(message))
        {
            Console.WriteLine($"[{logLevel}] {DateTime.Now}: {message}");
            if (exception != null)
            {
                Console.WriteLine(exception);
            }
        }
    }
    public void LogInformation(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
    }
    public void LogError(Exception ex, string message)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now}: {message}\n{ex}");
    }
}