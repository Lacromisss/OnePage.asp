using System.Collections.Generic;

namespace WebApplication4.Models
{
    
    public class Skill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public List<Icons> icon { get; set; }
        public List<WorkFlow> workFlow { get; set; }
    }
}
