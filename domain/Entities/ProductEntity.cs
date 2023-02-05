using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Price { get; set; }

        public string? Stock { get; set; }
    }
}
