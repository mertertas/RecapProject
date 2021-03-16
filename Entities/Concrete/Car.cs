﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class  Car:IEntities
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        
        public double DailyPrice { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }


    }
}
