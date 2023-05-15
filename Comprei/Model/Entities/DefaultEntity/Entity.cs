namespace Comprei.Model.Entities.DefaultEntity
{
    public abstract class Entity
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime? CreationDate { get; } = DateTime.Now;
        public DateTime? ModificationTime { get; set; }
        public bool Deleted { get; set; } = false;
        public DateTime? DeletionTime { get; set; }
    }
}
