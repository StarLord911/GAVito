using MediatR;

namespace GAVito.AdService.Data.Commands
{
    public record CreateOrderCommand : IRequest
    {
        public Guid AddId { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
