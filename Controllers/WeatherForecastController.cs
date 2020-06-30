using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetowy_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendplusController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SendplusController> _logger;

        public SendplusController(ILogger<SendplusController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Redirect("sendplus:downloadrequest?sourceId=5ecf73b29ef0015a28064223&jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6IkdpbGVzLkdhc2NvaWduZS1QZWVzQGRlbnRzdWFlZ2lzLmNvbSIsImZpcnN0bmFtZSI6IiIsImlhdCI6MTU5MzUxNzYyOH0.2cbD5pXao1A_EWooJLaptBzKzUXWwXawfKmNiw_Zy9g");
        }
    }
}
