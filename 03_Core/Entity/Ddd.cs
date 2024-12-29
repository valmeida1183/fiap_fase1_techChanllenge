using Core.Entity.Base;

namespace Core.Entity;
public class Ddd : EntityBase
{
    public short Code { get; set; }
    public required string Region { get; set; }
}
