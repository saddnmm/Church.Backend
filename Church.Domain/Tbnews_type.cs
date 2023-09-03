using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain
{
    internal class Tbnews_type
    {
        public Guid
            Id { get; set; }

        public string 
            News_type { get; set; }
    }
}
