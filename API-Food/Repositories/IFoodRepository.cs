using API_Food.Entities;
using API_Food.Models;
using System.Collections.Generic;
using System.Linq;

namespace API_Food.Repositories
{
    public interface IFoodRepository
    {
        FoodEntity GetSingle(int id);
        void Add(FoodEntity item);
        void Delete(int id);
        FoodEntity Update(int id, FoodEntity item);
        IQueryable<FoodEntity> GetAll(QueryParameters queryParameters);

        ICollection<FoodEntity> GetRandomMeal();
        int Count();

        bool Save();
    }
}
