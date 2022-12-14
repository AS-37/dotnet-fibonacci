using Leonardo;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase
{
    

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly Fibonacci _fibonacci;

    public FibonacciController(ILogger<WeatherForecastController> logger, Fibonacci fibonacci)
    {
        _logger = logger;
        _fibonacci = fibonacci;
    }


    [HttpPost(Name = "PostFibonacci")]
    public async Task<IList<long>> Run(string[] args)
    {
        return await _fibonacci.RunAsync(args);
    }
    
}










