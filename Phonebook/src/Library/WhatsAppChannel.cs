using WhatsAppApiUCU;

namespace Library
{
        public class WhatsAppChannel : IMessageChannel
        {//El canal se encarga de crear el message segun sus requerimientos
         //En este claso las clases de mensajes son iguales (WhatsappMessage y MailMessage). 
         //Pero de querer implementar otro medio se podria hacer
         //una clase sucesora de message en base a lo que requiera el channel.
                WhatsAppApi sender = new WhatsAppApi("ACfbd57f50e199a28eac49de4cc4acfb8a","81795970808380267013bf04070a5936");
                public void Send(Message message)
                {
                        sender.Send(message.To,message.Text);                                   
                }
                public Message Mensajear(Contact owner, Contact to, string content)
                {
                        WhatsAppMessage mensaje = new WhatsAppMessage(owner.Phone, to.Phone, content);
                        return mensaje;
                }
        }
}