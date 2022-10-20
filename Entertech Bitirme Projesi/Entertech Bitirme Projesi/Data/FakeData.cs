using Bogus;
using Entertech_Bitirme_Projesi.Models;

namespace Entertech_Bitirme_Projesi.Data
{
    public static class FakeData
    {
        private static List<User> _users;
        private static List<Etkinlikler> _etkinlikler;

        public static List<User> GetUsers(int number)
        {
           if(_users == null)
           {
                _users = new Faker<User>()
               .RuleFor(u => u.Id, f => f.IndexFaker)
               .RuleFor(u => u.Name, f => f.Name.FirstName())
               .RuleFor(u => u.Surname, f => f.Name.LastName())
               .Generate(number);
           }
            return _users;
        }
        public static List<Etkinlikler> GetEtkinliklers(int number)
        {
            if(_etkinlikler == null)
            {
                _etkinlikler = new Faker<Etkinlikler>()
                .RuleFor(e => e.OrganizationId, f => f.IndexFaker)
                .RuleFor(e => e.OrganizationName, f => f.Name.ToString())
                .RuleFor(e => e.OrganizationLocation, f => f.Name.ToString())
                .RuleFor(e => e.OrganizationDate, f => f.Date.Future(10, DateTime.Now.AddYears(1)))
                .RuleFor(e => e.The_Number_Of_Participants, f => f.IndexFaker)
                .Generate(number);
            }

            return _etkinlikler;
        }
    }
}
