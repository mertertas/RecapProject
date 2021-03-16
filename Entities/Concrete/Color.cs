using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Color : IEntities
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
