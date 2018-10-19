namespace Library
{
        public class MailMessage : Message
        {
                public MailMessage(string from, string to, string text) : base(from, to)
                {
                        this.Text = text;
                }
        }

}