using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GuestBookTest.MessagesControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private const string SqlConnection = "server=.; database=GuestBook; Integrated Security=true";

    }
}
