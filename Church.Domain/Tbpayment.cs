using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain
{
    internal class Tbpayment
    {
        public Guid 
            Payment_id { get; set; }

        public int 
            Payment_typeId { get;set; }
        
        public int 
            Payment_id_fk { get; set; }

        public bool
            Payment_accept { get; set; }
    }
}
