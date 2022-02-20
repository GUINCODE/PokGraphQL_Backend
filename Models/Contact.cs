namespace Ge2Co.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
       public string? Email { get; set;}
       public ICollection<Telephone>?  Telephones { get; set; }
    }
}