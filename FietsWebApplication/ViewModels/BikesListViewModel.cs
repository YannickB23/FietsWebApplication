using FietsWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FietsWebApplication.ViewModels
{
    public class BikesListViewModel
    {
        public IEnumerable<Bike> Bikes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
