using Microsoft.AspNetCore.Mvc;
using ECommerceAPI.Models;
using System;
using System.Collections.Generic;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            return Ok(new { Message = "Order placed successfully" });
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? CustomerName { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        // Add other properties as needed
    }
}
