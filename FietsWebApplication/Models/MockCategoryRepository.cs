using FietsWebApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FietsWebApplication.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId = 001, CategoryName="Racefiets", Description="De fiets voor op de weg."},
                new Category{CategoryId = 002, CategoryName="Gravelbike", Description="De allround fiets voor op de weg en offroad."},
                new Category{CategoryId = 003, CategoryName="Mountainbike", Description="De fiets voor de offroaders."}
            };
    }
}
