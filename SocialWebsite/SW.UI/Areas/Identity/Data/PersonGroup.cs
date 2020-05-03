using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Areas.Identity.Data
{
    public class PersonGroup
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }

        public string GroupId { get; set; }
        public Group Group { get; set; }
    }
}
