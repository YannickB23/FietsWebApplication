using FietsWebApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FietsWebApplication.Models
{
    public class MockBikeRepository : IBikeRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Bike> AllBikes =>
            new List<Bike>
            {
                new Bike{BikeId = 012, Name = "BMC Roadmachine Four", Price = 5849.00M , Description = "De BMC Roadmachine Four is een fijne allround racefiets.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl = "https://www.mantel.com/be/bmc-roadmachine-four", InStock = true, VIPSale = false, ImageThumbnailUrl = @"C:\Users\beter\source\repos\FietsWebApplication\FietsWebApplication\Images\7227cf26-6d13-4335-9279-48fe9e37c829.gif" },
                new Bike{BikeId = 012, Name = "BMC Roadmachine Four", Price = 5849.00M , Description = "De BMC Roadmachine Four is een fijne allround racefiets.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl = "https://www.mantel.com/be/bmc-roadmachine-four", InStock = true, VIPSale = false, ImageThumbnailUrl = @"C:\Users\beter\source\repos\FietsWebApplication\FietsWebApplication\Images\7227cf26-6d13-4335-9279-48fe9e37c829.gif" },
                new Bike{BikeId = 012, Name = "BMC Roadmachine Four", Price = 5849.00M , Description = "De BMC Roadmachine Four is een fijne allround racefiets.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl = "https://www.mantel.com/be/bmc-roadmachine-four", InStock = true, VIPSale = false, ImageThumbnailUrl = @"C:\Users\beter\source\repos\FietsWebApplication\FietsWebApplication\Images\7227cf26-6d13-4335-9279-48fe9e37c829.gif" }
            };

        public IEnumerable<Bike> VIPSales { get; }

        public Bike GetBikeById(int bikeId)
        {
            return AllBikes.FirstOrDefault(b => b.BikeId == bikeId);
        }
    }
}
