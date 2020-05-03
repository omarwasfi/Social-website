using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Areas.Identity.Data
{
    public class PersonPhotoPost
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }

        public string PhotoPostId { get; set; }
        public PhotoPost PhotoPost { get; set; }
    }
}
