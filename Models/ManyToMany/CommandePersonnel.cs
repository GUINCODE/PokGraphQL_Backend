using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ge2Co.Models.ManyToMany
{
    public class CommandePersonnel
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        public int PersonnelId { get; set; }
        public Personnel Personnel { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}