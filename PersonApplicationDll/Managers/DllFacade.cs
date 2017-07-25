using PersonApplicationDll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplicationDll.Managers
{
    public class DllFacade
    {
        public IManager<Person> GetPersonManager()
        {
            return new PersonListManager();
        }
        public IManager<PersonStatus> GetPersonStatusManager()
        {
            return new PersonStatusListManager();
        }
    }
}
