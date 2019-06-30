using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReminderCSharpLang.Model.XMLDocuments
{
    class Currency
    {
        static public void GetCurrencyRateToPage()
        {
            CultureInfo usCulture = new CultureInfo("en-US");
            XDocument xDoc = XDocument.Load("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            //Node - wezel(element html na stronie np: Tag (selektor(p, button, br), tekst, komentarz) Cube nie jest tagiem HTML tylko wlasnym XML)
            //cubeNodes stores all element when attribute currency is not null
            var cubeNodes = xDoc.Descendants().Where(element => element.Name.LocalName == "Cube" && element.Attribute("currency") != null).ToList();
            var currencyRate = cubeNodes.Select(c => new
            {
                Currency = c.Attribute("currency").Value,
                Rate = double.Parse(c.Attribute("rate").Value, usCulture)
            });

            int pageSize = 5;
            int currentPage = 0;
            var currencyRateOnThePage = currencyRate.Take(pageSize).ToList();
            while (currencyRateOnThePage.Count() > 0)
            {
                foreach (var rate in currencyRateOnThePage)
                {
                    Console.WriteLine($"Currency: {rate.Currency} Rate: {rate.Rate}");
                }

                Console.WriteLine("Press some button to get next page");
                Console.ReadLine();
                currentPage++;
                currencyRateOnThePage = currencyRate.Skip(pageSize * currentPage).Take(pageSize).ToList();
            }

        }
    }
}
