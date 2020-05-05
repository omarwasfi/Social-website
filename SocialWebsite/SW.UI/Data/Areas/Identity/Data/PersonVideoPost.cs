using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Areas.Identity.Data
{
    public class PersonVideoPost
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }

        public string VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
