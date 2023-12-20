using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Net.Mail;

namespace MyFirstAzureWebApp.Controllers
{
    public class TestController : Controller
    {
        [Route("api/test")]
        public IActionResult Index()
        {
            var result = new
            {
                comments = "Some string",
                attachments = "Som attachementes"
            };

            return this.Json(result);
        }
    }
}
