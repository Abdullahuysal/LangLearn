using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Admin:IEntity
    {
        public int AdminId { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminSecondName { get; set; }
        public string AdminPassword { get; set; }

    }
}
