using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?units=metric&checkin_date=2023-07-15&dest_type=city&dest_id=-1456928&checkout_date=2023-07-16&order_by=popularity&filter_by_currency=AED&locale=en-gb&adults_number=2&room_number=1&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_number=2&children_ages=5%2C0&page_number=0"),
				Headers =
					{
						{ "X-RapidAPI-Key", "0d4d0571f1msh6a2a51492e02809p190a29jsndec45daf9de2" },
						{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
					},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
				return View(values.results);
			}
        }

		[HttpGet]
		public async Task<IActionResult> GetCityDestId(string p)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={p}"),
				Headers =
				{
					{ "X-RapidAPI-Key", "0d4d0571f1msh6a2a51492e02809p190a29jsndec45daf9de2" },
					{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
				},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				return View();
			}
		}
    }

}
