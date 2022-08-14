using System;
using System.Collections.Generic;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetMangeProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }

        public string LanguageId { get; set; }

        public int? CategoryId { get; set; }
    }
}
