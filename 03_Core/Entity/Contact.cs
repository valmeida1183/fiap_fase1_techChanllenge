using Core.Entity.Base;

namespace Core.Entity;
public class Contact : EntityBase
{
    public required string Name { get; set; }
    public required string Phone { get; set; }
    public required string Email { get; set; }

    public virtual required Ddd Ddd { get; set; }
}
