using PersonApplicationDll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplicationDll.Managers
{
    class PersonStatusListManager : IManager<PersonStatus>
    {
        private static readonly List<PersonStatus> Statuses = new List<PersonStatus> { new PersonStatus { Id = 1, Name = "Away" },
                                                                                    new PersonStatus { Id = 2, Name = "Available" },
                                                                                    new PersonStatus { Id = 3, Name = "Busy" }
        };

        public PersonStatus Create(PersonStatus t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonStatus> Read()
        {
            return Statuses;
        }

        public PersonStatus Read(int id)
        {
            return Statuses.FirstOrDefault(x => x.Id == id);
        }

        public PersonStatus Update(PersonStatus t)
        {
            throw new NotImplementedException();
        }
    }
}
