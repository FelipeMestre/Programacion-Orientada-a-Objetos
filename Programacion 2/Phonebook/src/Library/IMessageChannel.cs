namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message);
         Message Mensajear (Contact Owner, Contact To, string content);
    }
}