using EcomReactCsharp.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;


namespace EcomReactCsharp.Controllers
{


    [ApiController]
    [Route("api/[controller]")]

    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("addUpdateMedicine")]
        public Response AddUpdateMedicine(Medicines medicines)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EComCS").ToString());
            response = dal.AddUpdateMedicine(medicines, connection);
            return response;
        }

        [HttpGet]
        [Route("userList")]
        public Response UserList()
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EComCS").ToString());
            response = dal.UserList( connection);
            return response;
        }



    }

}
