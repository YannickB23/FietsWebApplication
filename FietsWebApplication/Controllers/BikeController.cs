using FietsWebApplication.Interfaces;
using FietsWebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FietsWebApplication.Controllers
{
    public class BikeController : Controller
    {
        private readonly IBikeRepository _bikeRepository;
        private readonly ICategoryRepository _categoryRepository;
        public BikeController(IBikeRepository bikeRepository, ICategoryRepository categoryRepository)
        {
            _bikeRepository = bikeRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List()
        {
            BikesListViewModel bikesListViewModel = new BikesListViewModel();
            bikesListViewModel.Bikes = _bikeRepository.AllBikes;

            bikesListViewModel.CurrentCategory = "Race Fietsen";
            return View(bikesListViewModel);
        }
    }
}
