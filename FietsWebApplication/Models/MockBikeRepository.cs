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
                new Bike{BikeId = 012, Name = "BMC Roadmachine Four", Price = 2699.00M , Description = "De BMC Roadmachine Four is een fijne allround racefiets.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl = "https://cdn.mantel.com/images/product.php?image_id=150754&w=760&h=570", InStock = true, VIPSale = false, ImageThumbnailUrl = @"https://cdn.mantel.com/images/product.php?image_id=150754&w=760&h=570" },
                new Bike{BikeId = 012, Name = "Cube Agree C:62 SLT", Price = 4049.00M , Description = "Fraai, lichtgewicht carbon frame met aerodynamische eigenschappen.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl = "https://cdn.mantel.com/images/product.php?image_id=158245&w=760&h=570", InStock = true, VIPSale = false, ImageThumbnailUrl = @"https://cdn.mantel.com/images/product.php?image_id=158245&w=760&h=570" },
                new Bike{BikeId = 012, Name = "Bianchi Specialisma Red ETAP", Price = 7150.90M , Description = "De unieke Bianchi CV technologie is om trillingen te voorkomen.", Category = _categoryRepository.AllCategories.ToList()[0], ImageUrl = "https://www.vaneycksport.com/pub/media/catalog/product/cache/160ad2628a8662eefaec3e119a629bf2/f/6/f65394ae-00b9-4cfd-80ed-96ae12792b83.jpg", InStock = true, VIPSale = false, ImageThumbnailUrl = @"https://www.vaneycksport.com/pub/media/catalog/product/cache/160ad2628a8662eefaec3e119a629bf2/f/6/f65394ae-00b9-4cfd-80ed-96ae12792b83.jpg" }
            };

        public IEnumerable<Bike> VIPSales { get; }

        public Bike GetBikeById(int bikeId)
        {
            return AllBikes.FirstOrDefault(b => b.BikeId == bikeId);
        }
    }
}
