using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAVito.Domain.Order.Api
{
    public class CreateOrderRequest
    {
        public Guid AddId { get; set; }

        public string CustomerEmail { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
