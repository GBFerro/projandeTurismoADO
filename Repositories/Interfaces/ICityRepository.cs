using Models;

namespace Repositories.Interfaces
{
    public interface ICityRepository
    {
        bool Insert();

        List<City> FindAll();
    }
}