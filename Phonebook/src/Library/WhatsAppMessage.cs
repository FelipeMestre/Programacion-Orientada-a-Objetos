namespace Library
{
        public class WhatsAppMessage : Message
        {
                public WhatsAppMessage(string from, string to, string text) : base(from, to)
                {
                        this.Text = text;
                }
        }
}