using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Motorcycle:IEntity
    {
        int _enginePower;
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }


    }
}
