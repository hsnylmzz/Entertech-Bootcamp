namespace Entertech_Bitirme_Projesi.Models
{
    public class Etkinlikler
    {
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationLocation { get; set; }
        public DateTime OrganizationDate { get; set; }
        public int The_Number_Of_Participants { get; set; }
        public List<User> User { get; set; }
    }
}
