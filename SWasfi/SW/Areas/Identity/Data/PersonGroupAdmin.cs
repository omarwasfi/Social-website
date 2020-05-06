using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.Areas.Identity.Data
{
    public class PersonGroupAdmin
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }

        public string GroupId { get; set; }
        public Group Group { get; set; }
    }
}
