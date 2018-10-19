namespace Program
{
        class Empleado : Persona // La clase empleado hereda la clase persona, como es experto en los datos del empleado tiene el metodo para mandar mails a empleados
        {
                public Empleado(string nombre, string apellido, string ci, string email, int edad) : base(nombre, apellido)
                {
                        this.ci = ci;
                        this.email = email;
                        this.edad = edad;
                }

                public string ci { get; }
                public string email { get; }
                public int edad { get; }
                public void EnviarMailEmpleado(string Asunto, string Contenido, string remitente,string contraseña, string nombreDeRemitente)
                {
                        MailSender mail = new MailSender(remitente, contraseña);
                        mail.EnviarMail(remitente,nombreDeRemitente,this.email,Asunto,"Estimado " + this.nombre +" /n" + Contenido);
        
                }
        }
        
}