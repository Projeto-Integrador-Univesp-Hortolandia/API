using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeRepository _homeRepository;

        public HomeController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        [HttpGet]
        
        public async Task<IEnumerable<Feed>> GetAll()
        {
            return await _homeRepository.GetAll();
        }

        [HttpGet("{id}")]
        
        public async Task<Feed> Get(int id)
        {
            return await _homeRepository.GetById(id);
        }

        [HttpPost]

        public async Task<Feed> Post(int funcionarioId, Feed feed)
        {
            return await _homeRepository.Create(funcionarioId, feed);
        }

        [HttpPut]

        public async Task<Feed> Update(int id, Feed feed)
        {
            return await _homeRepository.Update(feed, id);
        }

        [HttpDelete]
        
        public async Task<Feed> Delete(int id, int funcionarioId)
        {
            return await _homeRepository.Delete(id, funcionarioId);
        }


    }
}
