using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SW.Areas.Identity.Data
{
    public class Chat
    {
        [Required]
        public string Id { get; set; }

        public List<Message> Messages { get; set; }

        public List<PersonChat> PersonChats { get; set; }
    }
}
