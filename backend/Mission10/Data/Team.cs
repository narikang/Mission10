using System.ComponentModel.DataAnnotations;

namespace Mission10.Data
{
    public class Team
    {
        [Key]
        public int teamID { get; set; }
        public string teamName { get; set; }

        public int captainID { get; set; }

        public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();
    }
}
