using System.Linq;
using System.Threading.Tasks;

namespace fishingApi.Models {
    public interface IBoatRepository
    {
        IQueryable<Boat> Boats {get;}
        Task<Boat> GetBoat(int BoatId);
        Task SaveBoat(Boat boat);
        Task<Boat> DeleteBoat(int boatId);
    }
}