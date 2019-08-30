namespace Program
{
        class Cliente : Persona 
///La clase Cliente hereda la clase persona, cree un metodo enviar mail para esta clase basandome en el srp, la clase cliente tiene los datos del cliente, el resto es parametro
        {
                public Cliente(string nombre, string apellido, string domicilio, string email) : base(nombre, apellido)
                {
                        this.Domicilio = domicilio;
                        this.Email = email;
                }

                public string Domicilio { get; }
                public string Email { get; }
                public void EnviarMailCorporativo( string Asunto, string Contenido, string Mailremitente, string contraseña, string nombreDeRemitente)
                {
                        MailSender mail = new MailSender(Mailremitente, contraseña);
                        mail.EnviarMail(Mailremitente, nombreDeRemitente, this.Email, Asunto, "Estimado " + this.nombre + " /n" + Contenido);
                }
        }
}