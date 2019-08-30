using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
        
        public void Add( Contact contacto)
        {
            this.persons.Add(contacto);
        }
        public void Enviar (IMessageChannel canal, string content, string[] names )
        {
            foreach (Contact item in this.Search(names))
            {
                canal.Send(canal.Mensajear(Owner,item,content));
            }
        }
    }
}