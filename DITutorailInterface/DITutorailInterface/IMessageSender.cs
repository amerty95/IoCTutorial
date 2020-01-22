namespace DITutorialInterface
{
    public interface IMessageSender
    {
        void SendMessage(IEmployee employee, string text);
    }
}