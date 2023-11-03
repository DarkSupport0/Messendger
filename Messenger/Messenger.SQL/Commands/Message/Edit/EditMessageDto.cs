namespace Messenger.SQL.Commands.Message.Edit
{
    public sealed class EditMessageDto
    {
        public EditMessageDto(int messageId, string newText)
        {
            MessageId = messageId;
            NewText = newText;
        }

        public int MessageId { get; set; }
        public string NewText { get; set; }
    }
}
