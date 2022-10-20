using Entertech_Bitirme_Projesi.Data;
using Entertech_Bitirme_Projesi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entertech_Bitirme_Projesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private List<User> _users = FakeData.GetUsers(100);

        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }
        [HttpPost]
        public User Post([FromBody]User user)
        {
            _users.Add(user);
            return user;
        }
        [HttpPut]
        public User Put([FromBody]User user)
        {
            var editedUser = _users.FirstOrDefault(x => x.Id == user.Id);
            editedUser.Name = user.Name;
            editedUser.Surname = user.Surname;
            return user;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var deletedUser = _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deletedUser);
        }
    }
}
