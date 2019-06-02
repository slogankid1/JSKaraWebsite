using JSKara.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JSKaraWebsite.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetByName(string name);
        IEnumerable<Restaurant> GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> restaurants;
        private List<Restaurant> emptyRestaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 0, Name = "Luigi's", cuisineType = CuisineType.Italian, Location = "NY"},
                new Restaurant {Id = 1, Name = "Panda Express", cuisineType = CuisineType.Chinese, Location = "NY"},
                new Restaurant {Id = 2, Name = "El Burro Loco", cuisineType = CuisineType.Mexican, Location = "TX"}
            };

            emptyRestaurants = new List<Restaurant>();
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }

        public IEnumerable<Restaurant> GetById(int id)
        {
            return from r in restaurants
                   where r.Id.Equals(id)
                   orderby r.Name
                   select r;
        }

        public IEnumerable<Restaurant> GetByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name, StringComparison.InvariantCultureIgnoreCase)
                   orderby r.Name
                   select r;
        }

    }
}
