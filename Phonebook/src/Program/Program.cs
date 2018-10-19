using System;
using Library;
using System.Collections.Generic;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact owner = new Contact("Felipe");
            owner.Email = "feli13mestre@gmail.com";
            owner.Phone = "+59899123456";

            Contact nachito = new Contact("Nachito");
            nachito.Email = "ptcnachlord996@outlook.com";
            nachito.Phone = "+59899512326";

            string [] nombres = new string[] {nachito.Name, owner.Name};   //uso mi contacto para hacer las pruebas.
                                                                            // el owner no estaría en agenda.  

            List<Contact> contactos = new List<Contact>() {owner,nachito};
            
            Phonebook agenda = new Phonebook(owner);

            WhatsAppChannel WhatsApp = new WhatsAppChannel();

            agenda.Enviar(WhatsApp,"hola", nombres);

            MailChannel Mail = new MailChannel();
            //la contraseña, el asunto y el remitente del mail estan hardcodeadados en la clase mailchannel.
            //Creo que no es pertinente al ejercicio parametrizarlos.
            agenda.Enviar(Mail,"prueba", nombres);
        }
    }
}
