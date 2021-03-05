using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.Api.Model;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var customers = new List<Customer>();
            for (int i = 0; i < 10; i++)
            {
                var customer = new Customer();
                customer.CustomerId = Guid.NewGuid();
                customer.FullName = $"hoang thi thu huong {i}";
                customers.Add(customer);
            }
            return Ok(customers);
        }

        [HttpGet("{customerId}")]
        public IActionResult GetCustomer(Guid customerId)
        {
            return Ok(new Customer());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            customer.FullName = "hoang thi thu huong";
            return Ok(customer);
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("huongdoll");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("huongdoll");
        }
    }
}
