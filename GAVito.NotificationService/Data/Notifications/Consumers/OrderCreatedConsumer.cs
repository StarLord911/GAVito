using GAVito.Domain.Order.Events;
using GAVito.NotificationService.Data.Notifications.Commands;
using MassTransit;
using MediatR;

namespace GAVito.NotificationService.Data.Notifications.Consumers
{
    public class OrderCreatedConsumer : IConsumer<OrderCreatedEvent>
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrderCreatedConsumer> _logger;

        public OrderCreatedConsumer(IMediator mediator, ILogger<OrderCreatedConsumer> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<OrderCreatedEvent> context)
        {
            var message = context.Message;

            var command = new SendEmailCommand
            {
                ToEmail = message.CustomerEmail,
                Subject = $"Ваш заказ #{message.OrderId} создан",
                Body = $"Спасибо за заказ."
            };

            await _mediator.Send(command);

        }
    }
}
