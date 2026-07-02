using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController(ILogger<TestController> logger) : ControllerBase
{
    
    [HttpGet("ping50")]
    public async Task<IActionResult> GetPing50()
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
    public async Task<IActionResult> GetPing300()
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
    public async Task<IActionResult> GetPing1000()
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
    
    [HttpGet("ping2000")]
    public async Task<IActionResult> GetPing2000()
    {
        var requestReceived = DateTime.Now;
        await Task.Delay(2000);
        var result = new
        {
            ReceivedAt = requestReceived,
            ProcessedAfter = (DateTime.Now - requestReceived).TotalSeconds
        };
        return Ok(result);
    }
}