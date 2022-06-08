using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required ]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public List<SocialMedia>SocialMedias { get; set;}
    }
}
