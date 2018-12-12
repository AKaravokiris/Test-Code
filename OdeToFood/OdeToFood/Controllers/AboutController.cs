using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {

        public string Phone()
        {
            return "2106545570";
        }


        public string Address()
        {
            return "GREECE";
        }
    }
}
