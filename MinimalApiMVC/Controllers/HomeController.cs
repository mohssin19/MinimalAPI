using Microsoft.AspNetCore.Mvc;
using MinimalApiMVC.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace MinimalApiMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetBaseUrl()
        {
            return _configuration.GetSection("ApiUrls").GetSection("BaseApiUrl").Value;
        }

        public async Task<ActionResult> Users()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetBaseUrl());
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(GetBaseUrl());
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var table = JsonConvert.DeserializeObject<IEnumerable<UserViewModel>>(data);
                    return View(table);
                }
            }
            return View("Error");
        }

        public async Task<ActionResult> GetUser(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(GetBaseUrl());
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(GetBaseUrl() + $"{id}");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var table = JsonConvert.DeserializeObject<UserViewModel>(data);
                    return View(table);
                }
            }
            return View("Error");
        }
    }
}
