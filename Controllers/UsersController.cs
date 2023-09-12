using EcomReactCsharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EcomReactCsharp.Controllers{


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

        public Response register(Users users){
            Response response = new Response();
            SQLConnection
            return response;
        }
    }

}
