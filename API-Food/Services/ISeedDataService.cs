using API_Food.Repositories;
using System.Threading.Tasks;

namespace API_Food.Services
{
    public interface ISeedDataService
    {
        Task Initialize(FoodDbContext context);
    }
}
