using GAVito.Domain.Order.Data;
using GAVito.Domain.Order.Events;
using MassTransit;
using MediatR;

namespace GAVito.AdService.Data.Commands
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public CreateOrderHandler(
            IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async Task Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                AdId = command.AddId,
                CustomerEmail = command.CustomerEmail,
                Amount = 0,// TODO take from db
                CreatedAt = command.CreatedAt
            };

            await _publishEndpoint.Publish(new OrderCreatedEvent
            {
                OrderId = order.Id,
                CustomerEmail = order.CustomerEmail,
                AdId = order.AdId,
            }, cancellationToken);
        }
    }
}
