using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSKara.Core;
using JSKaraWebsite.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace JSKaraWebsite.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        public Restaurant Restaurant { get; set; }

        public DetailsModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet(int restaurantID)
        {
            Restaurant = restaurantData.GetById(restaurantID).FirstOrDefault();
        }
    }
}