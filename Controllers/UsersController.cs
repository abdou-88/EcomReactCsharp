using EcomReactCsharp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;


namespace EcomReactCsharp.Controllers
{


    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("registration")]

        public Response register(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EComCS").ToString());
            response = dal.register(users, connection);
            return response;
        }

        [HttpPost]
        [Route("login")]
        public Response login(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EComCS").ToString());
            response = dal.Login(users, connection);
            return response;
        }
    }

}
