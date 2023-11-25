namespace Messenger.RestModels
{
    public sealed record CreateChatByTypeRequest
    {
        public CreateChatByTypeRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
