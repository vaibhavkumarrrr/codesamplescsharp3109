using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace WebAPIProject.Controllers
{
    public class MyMessage
    {
        public string Text { get; set; } = String.Empty;
    }
    [ApiController]
    [Route("[controller]")]
    public class TestController(ILogger<WeatherForecastController> logger, IConfiguration configuration, SQLServerContext context) : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        private readonly ILogger<WeatherForecastController> _logger = logger;
        private readonly IConfiguration _configuration = configuration;
        private readonly SQLServerContext _context = context;  
        [HttpGet(Name = "GetTestMessage")]
        [Produces("application/json")]
        //public IOptions<MySettings> Get()
        public async Task<OkObjectResult> Get()
        {

            //MyMessage p = new MyMessage(); 
            //p.Text= "Hello, this is a test message.";
            //return p; 
            //dynamic json = JsonConvert.DeserializeObject(str);
            //return json;
            //return "{\"objects\":[{\"id\":1,\"title\":\"Book\",\"position_x\":0,\"position_y\":0,\"position_z\":0,\"rotation_x\":0,\"rotation_y\":0,\"rotation_z\":0,\"created\":\"2016-09-21T14:22:22.817Z\"},{\"id\":2,\"title\":\"Apple\",\"position_x\":0,\"position_y\":0,\"position_z\":0,\"rotation_x\":0,\"rotation_y\":0,\"rotation_z\":0,\"created\":\"2016-09-21T14:22:52.368Z\"}]}"; 
            //return _settings;  
            //return _context.Blogs.
            var items = await _context.Blogs.ToListAsync();
            //var items = _context.ContextId.ToString() + "--" + _context.ConnectionString; 
            return Ok(items);
        }
    }
}
