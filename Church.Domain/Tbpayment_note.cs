using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain
{
    internal class Tbpayment_note
    {
        public virtual 
            Guid Tbpayment_note_id { get; set; }

        public virtual
            int Payment_note_type_id { get;set; }

        public virtual
            int Tbpayment_note_name_id { get; set; }

        public virtual 
            string Author { get; set; }

        public virtual 
            string Phone_number { get; set; }

        public virtual 
            string To_name { get; set; }
    }
}
