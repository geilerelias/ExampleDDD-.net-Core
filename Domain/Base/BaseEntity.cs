using System.ComponentModel.DataAnnotations;

namespace Domain.Base
{
    public class BaseEntity
    {
        
    }
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [Key]
        public virtual T Id { get; set; }
    }
}