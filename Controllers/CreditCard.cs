using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ImmoPortalApi.Controllers
{
    [Route("api/[controller]")]
    public class CreditCard : Controller
    {
        [HttpGet()]
        public IActionResult Get(CreditCardCheckRequest request)
        {
            var result = new CreditCardCheckResponse
            {
                CardNumber = request.CardNumber,
                IsValid = true
            };
            return new JsonResult(result);
        }
    }

    public class CreditCardCheckRequest
    {
        public string Name { get; set; }

        [CreditCard] public string CardNumber { get; set; }

        public string Csv { get; set; }

        public string ValidThrough { get; set; }
    }

    public class CreditCardCheckResponse
    {
        public bool IsValid { get; set; }

        public string CardNumber { get; set; }
    }
}