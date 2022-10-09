namespace CRUD_PROJECT.Models
{
    public class UpdateContactRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public long phone { get; set; }
        public string Address { get; set; }
    }
}
