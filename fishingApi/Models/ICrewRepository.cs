using System.Linq;
using System.Threading.Tasks;

namespace fishingApi.Models {
    public interface ICrewRepository
    {
        IQueryable<CrewMember> CrewMembers {get;}
        Task<CrewMember> GetCrewMember(int crewMemberId);
        Task SaveCrewMember(CrewMember CrewMember);
        Task<CrewMember> DeleteCrewMember(int CrewMemberId);
    }
}