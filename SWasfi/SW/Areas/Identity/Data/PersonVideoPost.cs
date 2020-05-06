using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace SW.Areas.Identity.Data
{
    public class PersonVideoPost
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }

        public string VideoPostId { get; set; }
        public VideoPost VideoPost { get; set; }
    }
}
