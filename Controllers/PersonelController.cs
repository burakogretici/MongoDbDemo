using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDbDemo.Entities;
using MongoDbDemo.Services;

namespace MongoDbDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {

        private readonly IPersonelService _personelService;

        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Personel personel)
        {
            await _personelService.Create(personel);
            return Ok("Created");
        }
        [HttpGet]
        public async Task<IActionResult> GetPersonels()
        {
            var personels = await _personelService.GetPersonels();
            return Ok(personels);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _personelService.GetById(id));
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Personel personel)
        {
            await _personelService.Update(personel.Id, personel);
            return Ok("Updated");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _personelService.Delete(id);
            return Ok("Deleted");
        }
    }
}

