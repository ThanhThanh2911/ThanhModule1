﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopShoes.Domain.Request.Category
{
    public class SaveCategoryReq
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}
