using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Persistance
{
    public class DbInitializer
    {
        public static void Initialize(ChurchDbContext context)
        {
            context.Database.EnsureCreated();
        } 
    }
}
