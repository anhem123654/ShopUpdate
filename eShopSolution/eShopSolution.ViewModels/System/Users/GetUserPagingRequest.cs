﻿using System;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.System.Users
{ 
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }
    }
}
