using System;
namespace eShopSolution.ViewModels.Catalog.Categries
{
    public class CategoryVm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { get; set; }
    }
}
