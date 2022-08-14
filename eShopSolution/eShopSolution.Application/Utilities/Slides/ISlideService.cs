using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Utilities.Slides;

namespace eShopSolution.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}
