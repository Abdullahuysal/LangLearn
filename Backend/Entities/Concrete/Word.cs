using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Word:IEntity
    {
        public int WordId { get; set; }
        public string WordName { get; set; }
        public string WordMean { get; set; }
    }
}
