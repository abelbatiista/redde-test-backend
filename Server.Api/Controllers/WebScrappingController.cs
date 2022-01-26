using HtmlAgilityPack;
using ScrapySharp.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PuppeteerSharp;

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebScrappingController : ControllerBase
    {
        // private readonly IEnterpriseService _enterpriseService;

        public WebScrappingController()
        {
            //_enterpriseService = enterpriseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<string> list = new List<string>();

            var _browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true,
                ExecutablePath = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"
            });
            var _page = await _browser.NewPageAsync();
            await _page.GoToAsync("https://www.dgii.gov.do/app/WebApps/ConsultasWeb/consultas/rnc.aspx");
            await _page.ClickAsync("#ctl00_cphMain_txtRNCCedula");
            await _page.Keyboard.SendCharacterAsync("101530723");
            await _page.ClickAsync("#ctl00_cphMain_btnBuscarPorRNC");

            var table = await _page.QuerySelectorAsync("table");
            var tbody = await table.QuerySelectorAsync("tbody");
            var tr = await table.QuerySelectorAllAsync("td");

            return Ok();
        }
    }
}
