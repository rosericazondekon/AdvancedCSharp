using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class ExceptionService
{
    private readonly ILogger<ExceptionService> _logger;
    public ExceptionService(ILogger<ExceptionService> logger)
    {
        _logger = logger;
    }
    public void HandleException(Exception ex)
    {
        _logger.LogError(ex, "An exception occurred.");
    }
}