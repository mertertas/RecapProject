﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class Brand:IEntities
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
