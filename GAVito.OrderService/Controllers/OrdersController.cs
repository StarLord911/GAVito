using GAVito.AdService.Data.Commands;
using GAVito.Domain.Order.Api;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GAVito.OrderService.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task CreateOrder(CreateOrderRequest createOrderRequest)
        {
            var command = new CreateOrderCommand()
            {
                AddId = createOrderRequest.AddId,
                CustomerEmail = createOrderRequest.CustomerEmail,
                CreatedAt = DateTime.Now 
            };

            await _mediator.Send(command);
        }
    }
}
