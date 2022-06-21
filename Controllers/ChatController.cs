using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatRepository chatRepository;

        public ChatController(IChatRepository _chatRepository)
        {
            _chatRepository = chatRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<Chat>> Get()
        {
            return await chatRepository.GetAll();
        }

        [HttpGet("{id}")]

        public async Task<Chat> Get(int id)
        {
            return await chatRepository.GetById(id);
        }

        [HttpPost]

        public async Task<Chat> Post(Chat chat)
        {
            return await chatRepository.Create(chat);
        }

        [HttpPut]

        public async Task<Chat> Put(int id, Chat chat)
        {
            return await chatRepository.Update(chat);
        }

        [HttpDelete("{id}")]

        public async Task<Chat> Delete(int id)
        {
            return await chatRepository.Delete(id);
        }
    }        
}
