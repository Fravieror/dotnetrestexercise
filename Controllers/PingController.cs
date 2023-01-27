using Microsoft.AspNetCore.Mvc;

namespace first.Controllers;

[ApiController]
[Route("[controller]")]
public class PingController : ControllerBase
{     
    [HttpGet]
    public String Get()
    {
       return "pong";
    }

    
}