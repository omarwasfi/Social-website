using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Areas.Identity.Data
{
    public class PersonTextPost
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }

        public string TextPostId { get; set; }
        public TextPost TextPost { get; set; }
    }
}
