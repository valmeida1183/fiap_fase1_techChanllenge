using Core.Entity.Base;

namespace Core.Entity;
public class DirectDistanceDialing : EntityBase
{
    public required string Region { get; set; }

    public virtual ICollection<Contact>? Contacts { get; set; }
}
