using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class cityList : InterfaceCityList
    {
        private static ConcurrentDictionary<string, City> _cities =
            new ConcurrentDictionary<string, City>();

        public cityList()
        {
            Add(new City { CityName = "New York" });
        }

        public IEnumerable<City> Get()
        {
            return _cities.Values;
        }

        public void Add(City item)
        {
            item.Key = Guid.NewGuid().ToString();
            _cities[item.Key] = item;
        }
    }
}
