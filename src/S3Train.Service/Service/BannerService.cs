﻿using S3Train.Contract;
using S3Train.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3Train.Service
{
    public class BannerService : GenenicServiceBase<Banner>, IBannerService
    {
        public BannerService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
