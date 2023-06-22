using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class User:BaseEntity
    {

        public string Name{ get; set; }
        public int Age { get; set; }
        public string TcNo { get; set; }

    }
}
