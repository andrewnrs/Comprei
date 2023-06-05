using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comprei.Model.Entities.DefaultEntity
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }        
        public DateTime CreationTime { get; set; }
        public DateTime? ModificationTime { get; set; }        
        public bool Deleted { get; set; } = false;
        public DateTime? DeletionTime { get; set; }
    }
}
