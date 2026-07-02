using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController(ILogger<TestController> logger) : ControllerBase
{
    
    [HttpGet("ping50")]
    public async Task<IActionResult> GetPing1()
    {
        var requestReceived = DateTime.Now;
        await Task.Delay(50);
        var result = new
        {
            ReceivedAt = requestReceived,
            ProcessedAfter = (DateTime.Now - requestReceived).TotalSeconds
        };
        return Ok(result);
    }

    [HttpGet("ping300")]
    public async Task<IActionResult> GetPing2()
    {
        var requestReceived = DateTime.Now;
        await Task.Delay(300);
        var result = new
        {
            ReceivedAt = requestReceived,
            ProcessedAfter = (DateTime.Now - requestReceived).TotalSeconds
        };
        return Ok(result);
    }

    [HttpGet("ping1000")]
    public async Task<IActionResult> GetPing3()
    {
        var requestReceived = DateTime.Now;
        await Task.Delay(1000);
        var result = new
        {
            ReceivedAt = requestReceived,
            ProcessedAfter = (DateTime.Now - requestReceived).TotalSeconds
        };
        return Ok(result);
    }
}