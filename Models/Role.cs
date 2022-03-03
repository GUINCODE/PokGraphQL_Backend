using Ge2Co.Models.ManyToMany;

namespace Ge2Co.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string? Labelle { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<CommandePersonnel>? CommandePersonnels { get; set; }
    }
}