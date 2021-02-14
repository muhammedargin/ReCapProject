using Entities.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class Color : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
