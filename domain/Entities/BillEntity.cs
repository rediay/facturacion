using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class BillEntity
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime Date { get; set; }

        public int? FullSale { get; set; }

        public ICollection<BillDetailEntity> BillDetails { get; set; }
    }
}
