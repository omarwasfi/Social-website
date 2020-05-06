using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace SW.Areas.Identity.Data
{
    public class TextPost
    {
        [Required]
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public List<PersonTextPost> PersonTextPosts { get; set; }

    }
}
