namespace DIP_Solution
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}