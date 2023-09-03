using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain
{
    internal class Tbtimetable
    {
        public Guid
            Tbtimetable_id { get; set; }

        public DateTime
            Tbtimetable_daytime { get;set; }

        public virtual 
            DateTime Tbtimetable_employee { get;set; }

        public virtual 
            string Tbtimetable_duty { get;set; }

        public string 
            Tbtimetable_category { get;set; }
    }
}
