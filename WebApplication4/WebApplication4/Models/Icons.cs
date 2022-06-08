namespace WebApplication4.Models
{
    public class Icons
    {
        public int Id { get; set; }
        public string Icoo { get; set; }
        public int? SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
