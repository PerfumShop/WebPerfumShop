﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Train.Domain
{
   public class ProductImage:EntityBase
    {
        public string ImagePath { get; set; }
        public virtual ProductVariation ProductVariation { get; set; }
    }
}
