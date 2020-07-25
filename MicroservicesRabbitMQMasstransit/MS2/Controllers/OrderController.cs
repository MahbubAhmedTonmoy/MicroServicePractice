using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MS2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IBusControl _bus;
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, IBusControl bus)
        {
            _logger = logger;
            _bus = bus;
        }

      
    }
}
