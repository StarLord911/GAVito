using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAVito.Domain.Order.Events
{
    public class OrderCreatedEvent
    {
        public Guid OrderId { get; set; }

        public string CustomerEmail { get; set; }

        public Guid AdId { get; set; }
    }
}
