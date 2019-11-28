﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Drink Drink { get; set; }
        public int Amount { get; set; }

        public string TableId { get; set; }
        
    }
}