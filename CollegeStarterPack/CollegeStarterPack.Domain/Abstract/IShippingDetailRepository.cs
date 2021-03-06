﻿using CollegeStarterPack.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeStarterPack.Domain.Abstract
{
   public interface IShippingDetailRepository
    {
        IEnumerable<ShippingDetail> ShippingDetails { get; }
    }
}
