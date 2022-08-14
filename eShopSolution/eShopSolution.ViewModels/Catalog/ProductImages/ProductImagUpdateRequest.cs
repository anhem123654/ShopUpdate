﻿using System;
using Microsoft.AspNetCore.Http;

namespace eShopSolution.ViewModels.Catalog.ProductImages
{
    public class ProductImagUpdateRequest
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
