namespace CRUD_PROJECT.Models
{
    public class AddContactRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public long phone { get; set; }
        public string Address { get; set; }
    }
}
