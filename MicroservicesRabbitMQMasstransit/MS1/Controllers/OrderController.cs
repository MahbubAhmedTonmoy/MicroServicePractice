using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MS1.Model;

namespace MS1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IBus _bus;
        public OrderController(IBus bus)
        {
            _bus = bus;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            if (order != null)
            {
                Uri uri = new Uri("rabbitmq://localhost/OrderQueue");
                var endPoint = await _bus.GetSendEndpoint(uri);
                await endPoint.Send(order);
                return Ok();
            }
            return BadRequest();
        }

        
    }
}
