using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDbDemo.Core.Database.Abstract;
using MongoDbDemo.Entities;

namespace MongoDbDemo.Services
{
    public class PersonelService : IPersonelService
    {

        private readonly IMongoCollection<Personel> _collection;

        public PersonelService(IMongoDBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<Personel>(settings.CollectionName);
        }

        public async Task<Personel> Create(Personel model)
        {
            await _collection.InsertOneAsync(model);
            return model;
        }

        public async Task<IEnumerable<Personel>> GetPersonels()
        {
            var personels = await _collection.FindAsync(x => true).Result.ToListAsync();
            return personels;
        }

        public async Task<Personel> GetById(string id) => await _collection.FindAsync<Personel>(x => x.Id == id).Result.FirstOrDefaultAsync();

        public async Task Delete(string id) => await _collection.DeleteOneAsync(m => m.Id == id);

        public async Task Update(string id, Personel personel) => await _collection.ReplaceOneAsync(m => m.Id == id, personel);

    }
}
