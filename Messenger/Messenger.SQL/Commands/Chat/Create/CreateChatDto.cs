namespace Messenger.SQL.Commands.Chat.Create
{
    public sealed record CreateChatDto
    {
        public CreateChatDto(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; }
        public string Type { get; }
    }
}
