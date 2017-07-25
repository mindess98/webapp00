using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonApplicationDll.Entities
{
    public class EditPersonViewModel
    {
        public Person Person;
        public List<PersonStatus> Statuses { get; set; }
    }
}