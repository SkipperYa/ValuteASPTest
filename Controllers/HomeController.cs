using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ValuteASPTest.Models;

namespace ValuteASPTest.Controllers
{
    public class HomeController : Controller
    {
        private string UrlPath = "https://www.cbr-xml-daily.ru/daily_json.js";
        private ValuteResponse valuteResponse;

        public HomeController()
        {
            string url = UrlPath;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            valuteResponse = JsonConvert.DeserializeObject<ValuteResponse>(response);
        }

        public ActionResult currencies(int page = 1)
        {
            int pageSize = 5;
            var count = valuteResponse.Valute.Count();
            var items = valuteResponse.Valute.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            PageInfo pageInfo = new PageInfo(count, page, pageSize);
            IndexViewModel ivm = new IndexViewModel 
            { 
                PageInfo = pageInfo, ValuteResp = items
            };

            return View(ivm);

        }

        [HttpGet]
        public ActionResult currency(string key, int page)
        {
            Valutes val = valuteResponse.Valute[key];
            ViewBag.CurrentPage = page;
            return View(val);
        }
    }
}
