using Entertech_Bitirme_Projesi.Data;
using Entertech_Bitirme_Projesi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entertech_Bitirme_Projesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtkinlikController : ControllerBase
    {
        private List<User> _user = FakeData.GetUsers(5);
        private List<Etkinlikler> _etkinlikler = FakeData.GetEtkinliklers(5);

        [HttpGet]
        public List<Etkinlikler> Get()
        {
            return _etkinlikler;
        }
        [HttpGet("{id}")]
        public Etkinlikler Get(int id)
        {
            var etkinlikler = _etkinlikler.FirstOrDefault(x => x.OrganizationId == id);
            return etkinlikler;
        }
        [HttpPost]
        public Etkinlikler Post([FromBody]Etkinlikler etkinlikler)
        {
            _etkinlikler.Add(etkinlikler);
            return etkinlikler;
        }

        [HttpPut]
        public Etkinlikler Put([FromBody] Etkinlikler etkinlikler)
        {
            var editedOrganization = _etkinlikler.FirstOrDefault(x => x.OrganizationId == etkinlikler.OrganizationId);
            editedOrganization.OrganizationName = etkinlikler.OrganizationName;
            editedOrganization.OrganizationLocation = etkinlikler.OrganizationLocation;
            editedOrganization.OrganizationDate = etkinlikler.OrganizationDate;
            editedOrganization.The_Number_Of_Participants = etkinlikler.The_Number_Of_Participants;
            return etkinlikler;
        }
        [HttpDelete]
        public void Delete(int id)
        {
            var deletedOrganization = _etkinlikler.FirstOrDefault(x => x.OrganizationId == id);
            _etkinlikler.Remove(deletedOrganization);
        }
    }
}
