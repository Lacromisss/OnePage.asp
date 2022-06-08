using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Experience
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public DateTime time { get; set; }
    }
}
