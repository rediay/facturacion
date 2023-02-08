using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class BillDetailEntity
    {
        public int Id { get; set; }

        public int? QuantityOrdered { get; set; }

        public ProductEntity Product { get; set; }

        public BillEntity Bills { get; set; }
    }
}
