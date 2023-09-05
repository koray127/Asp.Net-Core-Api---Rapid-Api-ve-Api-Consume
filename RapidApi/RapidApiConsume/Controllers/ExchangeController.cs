using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
    public class ExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
			//using System.Net.Http.Headers;
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
				Headers =
	{
		{ "X-RapidAPI-Key", "561a744b9cmshe0f9cf83e6a9bd7p1e4a62jsn69d7aeca69e1" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ExchangeViewModel>(body);
				return View(values.exchange_rates.ToList());
			}
		}
    }
}
