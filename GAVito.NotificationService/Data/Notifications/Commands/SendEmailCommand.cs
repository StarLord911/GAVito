using MediatR;

namespace GAVito.NotificationService.Data.Notifications.Commands
{
    public record SendEmailCommand : IRequest<bool>
    {
        public string ToEmail { get; init; } = string.Empty;
        public string Subject { get; init; } = string.Empty;
        public string Body { get; init; } = string.Empty;
    }
}
