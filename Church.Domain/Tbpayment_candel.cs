using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain
{
    internal class Tbpayment_candel
    {
        public Guid 
            Tbpayment_candel_id { get; set; }

        public Guid
            Tbpayment_candel_type_id { get; set; }

        public Guid
            Tbpayment_candel_icon { get; set; }

        public Guid 
            Tbpayment_candel_prayer { get; set; }

        public decimal 
            Cost { get; set; }

        public string?
            Day {  get; set; }

        public string ?
            To_name {  get; set; }

        public string?
            Author { get; set; }

        public string? 
            Phone_number { get; set; }
    }
}
