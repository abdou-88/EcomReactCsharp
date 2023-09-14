using EcomReactCsharp.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;


namespace EcomReactCsharp.Controllers
{


    [ApiController]
    [Route("api/[controller]")]

    public class MedicinesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MedicinesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("addToCart")]

        public Response addToCart(Cart cart)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EComCS").ToString());
            response = dal.addToCart(cart, connection);
            return response;
        }

        [HttpPost]
        [Route("placeOrder")]
        public Response placeOrder(Users users)
        {
            Response response = new Response();
            DAL dal = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EComCS").ToString());
            response = dal.placeOrder(users, connection);
            return response;
        }




    }

}
