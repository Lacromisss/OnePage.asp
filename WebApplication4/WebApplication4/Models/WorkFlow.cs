namespace WebApplication4.Models
{
    public class WorkFlow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SkillId { get; set; }
        public Skill Skill{ get; set; }
    }
}
