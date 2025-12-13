using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAVito.Domain.Order.Data
{
    public class Order
    {
        public Guid Id { get; set; }

        public string CustomerEmail { get; set; }

        public Guid AdId { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
