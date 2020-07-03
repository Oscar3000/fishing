using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace fishingApi.Models
{
    public class Boat {
        [Key]
        public int BoatId { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int BuildNumber { get; set; }
        public decimal LOA { get; set; }
        public decimal B { get; set; }
        public byte Picture { get; set; }

        public virtual ICollection<CrewMember> CrewMembers { get; set; }
    }
}