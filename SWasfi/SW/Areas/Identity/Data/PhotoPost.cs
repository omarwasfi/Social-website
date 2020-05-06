using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;

namespace SW.Areas.Identity.Data
{
    public class PhotoPost
    {
        [Required]
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public string PhotoLocation { get; set; }
        public List<PersonPhotoPost> PersonPhotoPosts { get; set; }
    }
}
