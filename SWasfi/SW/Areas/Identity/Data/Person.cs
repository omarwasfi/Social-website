using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SW.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Perosn class
    public class Person : IdentityUser
    {

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public string ProfilePictureLocation { get; set; }

        [MaxLength(250)]
        public string Bio { get; set; }

        [MaxLength(50)]
        public string Gender { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public List<PersonGroup> PersonGroups { get; set; }

        public List<PersonGroupAdmin> PersonGroupAdmins { get; set; }

        public List<PersonChat> PersonChats { get; set; }

        public List<PersonTextPost> PersonTextPosts { get; set; }

        public List<PersonVideoPost> PersonVideoPosts { get; set; }

        public List<PersonPhotoPost> PersonPhotoPosts { get; set; }
    }
}
