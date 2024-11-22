using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRApp.Hubs;
using SignalRApp.Models;
using System.Diagnostics;

namespace SignalRApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IHubContext<OrderHub> _orderHub;
        public OrderController(IHubContext<OrderHub> orderHub)
        {
            _orderHub = orderHub;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[Route("[Controller]")] /Order/Order 
        [HttpPost]
        public IActionResult Add([FromBody] Order order)
        {
            _orderHub.Clients.All.SendAsync("lastOrder", order);

            return Accepted();
        }

    }
}