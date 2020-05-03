using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SW.UI.Areas.Identity.Data
{
    public class Group
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<PersonGroup> PersonGroups { get; set; }

        public List<PersonGroupAdmin> PersonGroupAdmins { get; set; }

        public List<Message> Messages { get; set; }
    }
}
