namespace Ge2Co.Models
{
    public class Telephone
    {
        public int Id { get; set; }
        public string TelephoneNumber {get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}