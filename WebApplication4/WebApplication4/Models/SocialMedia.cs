namespace WebApplication4.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
