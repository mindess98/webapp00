using PersonApplicationDll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplicationDll.Managers
{
    class PersonListManager : IManager<Person>
    {
        static PersonStatusListManager psm = new PersonStatusListManager();
        private static int PersonId = 1;
        static private readonly List<Person> Persons = new List<Person>();
        public Person Create(Person person)
        {
            var pStatus = psm.Read(person.Status.Id);
            person.Status = pStatus;
            person.Id = PersonId++;
            Persons.Add(person);
            return person;
        }

        public bool Delete(int id)
        {
            return 1 == Persons.RemoveAll(x => x.Id == id);
        }

        public List<Person> Read()
        {
            return Persons;
        }

        public Person Read(int id)
        {
            return Persons.FirstOrDefault(x => x.Id == id);
        }

        public Person Update(Person p)
        {
            var personToEdit = Persons.FirstOrDefault(X => X.Id == p.Id);
            if (personToEdit != null)
            {
                personToEdit.Name = p.Name;
                personToEdit.Status = psm.Read(p.Status.Id); ;
            }
            return personToEdit;
        }
    }
}
