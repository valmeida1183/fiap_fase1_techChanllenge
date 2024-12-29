namespace Core.Entity.Base;
public abstract class EntityBase
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
}
