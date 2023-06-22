using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public enum Status
    {

        Active=1,
        Delete=2,
        Update=3


    }



    public class BaseEntity
    {

        public int Id { get; set; }


        public DateTime CreateDate { get; set; } = DateTime.Now;

        public Status Status{ get; set; }



    }
}
