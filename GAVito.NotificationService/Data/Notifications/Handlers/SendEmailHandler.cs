using GAVito.NotificationService.Data.Notifications.Commands;
using MediatR;

namespace GAVito.NotificationService.Data.Notifications.Handlers
{
    public class SendEmailHandler : IRequestHandler<SendEmailCommand, bool>
    {
        public SendEmailHandler()
        {
        }

        public async Task<bool> Handle(SendEmailCommand request, CancellationToken cancellationToken)
        {
            // Эмулируем отправку email
            await Task.Delay(1000, cancellationToken);

            return true;
        }
    }
}
