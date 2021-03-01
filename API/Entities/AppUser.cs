namespace API.Entities
{
    public class AppUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
    }
}