using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain
{
    public class Tbemployee
    {
        public Guid 
            Employee_id { get; set; }

        public string 
            Employee_name { get; set; }

        public string
            Employee_surname { get; set; }

        public string 
            Employee_patronymic { get; set; }

        public string
            Employee_email { get; set;}

        public string
            Employee_phone { get; set;}

        public string 
            Employee_description_about { get; set; }

        public Guid 
            Employee_role_Id { get; set; }
    }
}
