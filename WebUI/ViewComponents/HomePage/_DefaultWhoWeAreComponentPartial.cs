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
            var clientService = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:13838/api/WhoWeAreDetail/getalldetails");
            var responseMessageService = await clientService.GetAsync("http://localhost:13838/api/Service");


            if (responseMessage.IsSuccessStatusCode && responseMessageService.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonDataService = await responseMessageService.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData);
                var valuesService = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonDataService);

                ViewBag.Title = values.Select(x => x.Title).FirstOrDefault();
                ViewBag.Subtitle = values.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.Description1 = values.Select(x => x.Description1).FirstOrDefault();
                ViewBag.Description2 = values.Select(x => x.Description2).FirstOrDefault();
                return View(valuesService);
            }
            return View();
        }
    }
}
