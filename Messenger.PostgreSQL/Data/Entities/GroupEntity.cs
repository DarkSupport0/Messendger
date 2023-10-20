namespace Messenger.PostgreSQL.Data.Entities;

public sealed class GroupEntity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    
    public List<UserEntity> Users { get; set; }
}