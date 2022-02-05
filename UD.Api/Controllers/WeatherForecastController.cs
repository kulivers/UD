using Contracts;
using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace UD.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chillies2", "Cool$$$", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILoggerManager _logger;
    private readonly IRepositoryManager _repositoryManager;

    public WeatherForecastController(ILoggerManager logger, IRepositoryManager repositoryManager)
    {
        _logger = logger;
        _repositoryManager = repositoryManager;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Here is info message from our values controller.");
        _logger.LogDebug("Here is debug message from our values controller.");
        _logger.LogWarn("Here is warn message from our values controller.");
        _logger.LogError("Here is an error message from our values controller.");

        return Summaries.ToArray();
    }
}