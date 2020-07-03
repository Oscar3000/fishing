using fishingApi.Data;
using System.Linq;
using System.Threading.Tasks;

namespace fishingApi.Models {
    public class BoatRepository: IBoatRepository {
        private ApplicationDbContext context;
        public BoatRepository(ApplicationDbContext ctx) => context = ctx;
        public IQueryable<Boat> Boats => context.Boats;
        public async Task<Boat> GetBoat(int boatId) {
            return await context.Boats.FindAsync(boatId);
        }

        public async Task<Boat> DeleteBoat(int boatId) {
            var boat = await context.Boats.FindAsync(boatId);

            if(boat != null){
                context.Boats.Remove(boat);
                await context.SaveChangesAsync();
            }
            return boat;
        }

        public async Task SaveBoat(Boat boat) {
            context.Boats.Add(boat);
            await context.SaveChangesAsync();
        }

        private bool BoatExists(int id)
        {
            return context.Boats.Any(e => e.BoatId == id);
        }
    }
}