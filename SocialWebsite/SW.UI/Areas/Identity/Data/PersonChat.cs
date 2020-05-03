using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Areas.Identity.Data
{
    public class PersonChat
    {
        public string PersonId { get; set; }
        public Person Person { get; set; }

        public string ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
