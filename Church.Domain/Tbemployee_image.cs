using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace Church.Domain
{
    internal class Tbemployee_image
    {
        public virtual Guid
            Id { get; set; }
                
        public virtual Guid 
            Idemployee { get;set; }

        public virtual byte[] 
            Image { get; set; }
    }
}
