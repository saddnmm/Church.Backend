using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain
{
    internal class Tbnews
    {

        public Guid
            News_id { get; set; }

        public int
            News_typeId { get; set; }

        public byte[]
            News_image {  get; set; }

        public string
            News_name { get; set; }

        public DateTime 
            News_date { get; set; }

        public string 
            News_description { get; set; }
    }
}
