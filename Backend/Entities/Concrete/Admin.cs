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
        public int AdminFirstName { get; set; }
        public int AdminSecondName { get; set; }
        public int AdminPassword { get; set; }

    }
}
