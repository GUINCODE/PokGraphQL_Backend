using Ge2Co.Models.ManyToMany;

namespace Ge2Co.Models
{
    public class Personnel
    {
        public int Id { get; set; } 
        public string  Name { get; set; }
     public ICollection<CommandePersonnel>? CommandePersonnels { get; set; }
    }
}