using Dapper;
using GuestBookTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GuestBookTest.Controllers
{
  
    [Route("api/[controller]/[action]")]
    [ApiController]
  
public class UsersController : ControllerBase
    {
        private const string SqlConnection = "server=.; database=GuestBook; Integrated Security=true";

     
    }
}
