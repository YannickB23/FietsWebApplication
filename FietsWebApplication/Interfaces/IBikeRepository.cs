using FietsWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FietsWebApplication.Interfaces
{
    public interface IBikeRepository
    {
        IEnumerable<Bike> AllBikes { get; }
        IEnumerable<Bike> VIPSales { get; }
        Bike GetBikeById(int bikeId);
    }
}
