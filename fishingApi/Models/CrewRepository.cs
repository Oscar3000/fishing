using fishingApi.Data;
using System.Linq;
using System.Threading.Tasks;

namespace fishingApi.Models {
    public class CrewRepository: ICrewRepository {
        private ApplicationDbContext context;
        public CrewRepository(ApplicationDbContext ctx) => context = ctx;
        public IQueryable<CrewMember> CrewMembers => context.CrewMembers;
        public async Task<CrewMember> GetCrewMember(int crewMemberId) {
            return await context.CrewMembers.FindAsync(crewMemberId);
        }

        public async Task<CrewMember> DeleteCrewMember(int crewMemberId) {
            var CrewMember = context.CrewMembers.FirstOrDefault(x => x.CrewMemberId == crewMemberId);

            if(CrewMember != null){
                context.CrewMembers.Remove(CrewMember);
                await context.SaveChangesAsync();
            }
            return CrewMember;
        }

        public async Task SaveCrewMember(CrewMember CrewMember) {
            context.CrewMembers.Add(CrewMember);
            await context.SaveChangesAsync();
        }
        
        private bool CrewMemberExists(int id)
        {
            return context.CrewMembers.Any(e => e.CrewMemberId == id);
        }
    }
}