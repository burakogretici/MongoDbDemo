using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDbDemo.Entities;

namespace MongoDbDemo.Services
{
    public interface IPersonelService
    {
        Task<Personel> Create(Personel model);
        Task<Personel> GetById(string id);
        Task<IEnumerable<Personel>> GetPersonels();
        Task Delete(string id);
        Task Update(string id,Personel personel);
    }
}
