using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SW.Areas.Identity.Data
{
  
        public class Message
        {
            [Required]
            public string Id { get; set; }
            public Person Person { get; set; }

            public string Content { get; set; }

            public DateTime Date { get; set; }
        
    }
}
