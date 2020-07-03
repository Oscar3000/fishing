using System;
using System.ComponentModel.DataAnnotations;

namespace fishingApi.Models
{
    public class CrewMember {
        [Key]
        public int CrewMemberId { get; set; }
        public string Name { get; set; }
        public byte Picture { get; set; }
        public int Age { get; set; }
        public string Email { get; set; } 
        public string Role { get; set; }
        public DateTime CertifiedUntil { get; set; }
        public virtual Boat Boat { get; set; }
        public int BoatId {get; set; }
    }
}