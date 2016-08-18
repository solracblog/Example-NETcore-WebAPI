using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebAPI.Models;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        public CityController(InterfaceCityList CityList)
        {
            cityList = CityList;
        }
        public InterfaceCityList cityList { get; set; }
        
        [HttpGet]
        public IEnumerable<City> Get()
        {
            return cityList.Get();
        }
    }
}
