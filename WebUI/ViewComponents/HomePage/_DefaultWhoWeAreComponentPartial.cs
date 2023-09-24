using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.DTOs.WhoWeAreDetail;

namespace WebUI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial : ViewComponent
    {
        IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:13838/api/WhoWeAreDetail/getalldetails");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData);
                ViewBag.Title = values.Select(x => x.Title).FirstOrDefault();
                ViewBag.Subtitle = values.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.Description1 = values.Select(x => x.Description1).FirstOrDefault();
                ViewBag.Description2 = values.Select(x => x.Description2).FirstOrDefault();
                return View(values);
            }
            return View();
        }
    }
}
