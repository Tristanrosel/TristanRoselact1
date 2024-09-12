using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TristanRoselact1.Models;

namespace TristanRoselact1.Pages
{
    public class IndexModel(ILogger<IndexModel> logger) : PageModel
    {
        private static readonly List<Color> colors = [];

        // This will store the colors fetched from the API
        public List<Color> Colors { get; set; } = colors;

        public List<Color> GetColors()
        {
            return Colors;
        }

        public async Task OnGetAsync()
        {
            using var client = new HttpClient();

            try
            {
                
                client.BaseAddress = new Uri("https://www.colourlovers.com/");
                client.DefaultRequestHeaders.Add("User-Agent", "YourAppName/1.0");

                var response = await client.GetAsync("api/colors/new?format=json");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    
                    Colors = JsonConvert.DeserializeObject<List<Color>>(content) ?? colors;
                }
                else
                {
                    logger.LogError("Failed to fetch color data. Status code: {StatusCode}", response.StatusCode);
                }
            }
            catch (HttpRequestException e)
            {
                logger.LogError(e, "Error fetching color data.");
            }
        }
    }
}
