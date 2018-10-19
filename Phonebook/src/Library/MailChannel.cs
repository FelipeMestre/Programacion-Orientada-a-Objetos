using MailSenderApiUCU;
namespace Library
{
        public class MailChannel : IMessageChannel
        {

                public void Send(Message message)
                {
                        MailSender sender = new MailSender(message.From,"contraseña");
                        sender.EnviarMail(message.From,"remitente",message.To,"asunto",message.Text);                       
                }
                public Message Mensajear (Contact owner, Contact to, string content) 
                {
                        MailMessage mensaje = new MailMessage(owner.Email, to.Email, content);
                        return mensaje;
                }
        }
}