namespace Ge2Co.Models
{
    public class Entreprise
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adresse { get; set; }
        public  int? ContactId { get; set; }
        public Contact? ContactName { get; set; }
    }
}