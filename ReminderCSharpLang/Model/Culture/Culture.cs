using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderCSharpLang.Model.Culture
{
    class Culture
    {
        public Days days { get; set; }
        public void UsCulture()
        {
            //Note: inputNumber is string with '.' separator. It uses in US not in German or Poland so in that case Parser return wrong number.
            string inputNumber = "1.425";
            double usNumber = double.Parse(inputNumber, CultureInfo.GetCultureInfo("en-US"));
            double germanNumber = double.Parse(inputNumber, CultureInfo.GetCultureInfo("de-DE"));
            Console.WriteLine(usNumber.ToString() + " is not the same as " + germanNumber.ToString(new CultureInfo("de-DE")));

            //Note: It display Culture's name from system ex. en-GB or pl-PL
            Console.WriteLine("Current culture: " + CultureInfo.CurrentCulture.Name);

            float Number = 1.4256f;
            CultureInfo pl = new CultureInfo("pl");
            Console.WriteLine(Number.ToString() + " is not the same as " + Number.ToString(pl));


            CultureInfo enUs = new CultureInfo("en-US");
            Console.WriteLine("First day of the: " + enUs.DateTimeFormat.FirstDayOfWeek.ToString());
            Console.WriteLine("First calendar week starts with: " + enUs.DateTimeFormat.CalendarWeekRule.ToString());
            Console.WriteLine("First day of the PL: " + pl.DateTimeFormat.FirstDayOfWeek.ToString());
            Console.WriteLine("First calendar week starts with PL: " + pl.DateTimeFormat.CalendarWeekRule.ToString());


            //Note: It display all month by English an by Polish lang
            foreach (string monthName in enUs.DateTimeFormat.MonthNames)
                Console.WriteLine(monthName);
            Console.WriteLine("Current month: " + enUs.DateTimeFormat.GetMonthName(DateTime.Now.Month));

            foreach (string monthName in pl.DateTimeFormat.MonthNames)
                Console.WriteLine(monthName);
            Console.WriteLine("Current month: " + pl.DateTimeFormat.GetMonthName(DateTime.Now.Month));


            //Note: It display only separator uses to separate float number (12,12 or 12.12) and separate big number (10.000.000 or 10,000,000)
            //CultureInfo enUs = new CultureInfo("en-US");
            Console.WriteLine(enUs.DisplayName + ":");
            Console.WriteLine("NumberGroupSeparator: " + enUs.NumberFormat.NumberGroupSeparator);
            Console.WriteLine("NumberDecimalSeparator: " + enUs.NumberFormat.NumberDecimalSeparator);

            CultureInfo deDe = new CultureInfo("de-DE");
            Console.WriteLine(deDe.DisplayName + ":");
            Console.WriteLine("NumberGroupSeparator: " + deDe.NumberFormat.NumberGroupSeparator);
            Console.WriteLine("NumberDecimalSeparator: " + deDe.NumberFormat.NumberDecimalSeparator);


            Console.WriteLine(enUs.DisplayName + " - currency symbol: " + enUs.NumberFormat.CurrencySymbol);
            Console.WriteLine(deDe.DisplayName + " - currency symbol: " + deDe.NumberFormat.CurrencySymbol);
            CultureInfo ruRu = new CultureInfo("ru-RU");
            Console.WriteLine(ruRu.DisplayName + " - currency symbol: " + ruRu.NumberFormat.CurrencySymbol);

            Console.WriteLine("currency name: " + CultureInfo.CurrentCulture.Name);
            Console.WriteLine("currency symbol: " + CultureInfo.CurrentCulture.NumberFormat.CurrencyNegativePattern);

            //Note: display number with 4 decimal places and polish currency symbol
            Console.WriteLine("Currency Value: {0}", Number.ToString("C4", pl));

            string n = Number.ToString("C4", pl);



            Console.WriteLine(n);
        }

        static public void DisplayAllCurrencySymbolInTheWorld()
        {

            Console.WriteLine(CultureInfo.CurrentCulture.EnglishName);
            CultureInfo[] allCulture = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo c in allCulture)
            {
                Console.WriteLine(c.NumberFormat.CurrencySymbol);
            }
            Console.WriteLine(allCulture.Count());
        }

        static public void RegionInfoMethods(string region)
        {
            RegionInfo regionInfo = new RegionInfo(region);
            region = "ELO";
            Console.WriteLine("regionInfo.EnglishName: " + regionInfo.EnglishName);
            Console.WriteLine("regionInfo.TwoLetterISORegionName: " + regionInfo.TwoLetterISORegionName);
            Console.WriteLine("regionInfo.DisplayName: " + regionInfo.DisplayName);
            Console.WriteLine("regionInfo.Name: " + regionInfo.Name);
            Console.WriteLine("regionInfo.ISOCurrencySymbol: " + regionInfo.ISOCurrencySymbol);
            Console.WriteLine("regionInfo.CurrencySymbol: " + regionInfo.CurrencySymbol);
            Console.WriteLine("regionInfo.CurrencyEnglishName: " + regionInfo.CurrencyEnglishName);
            Console.WriteLine("regionInfo.CurrencyNativeName: " + regionInfo.CurrencyNativeName);
            Console.WriteLine("regionInfo.CurrencySymbol: " + regionInfo.CurrencySymbol);
            Console.WriteLine("regionInfo.GeoId: " + regionInfo.GeoId);
            Console.WriteLine("regionInfo.IsMetric: " + regionInfo.IsMetric);
            Console.WriteLine("regionInfo.ThreeLetterISORegionName: " + regionInfo.ThreeLetterISORegionName);
            Console.WriteLine("regionInfo.ThreeLetterWindowsRegionName: " + regionInfo.ThreeLetterWindowsRegionName);
            ListOfCountryWithRegioCountry();
        }

        static public void ListOfCountryWithRegioCountry()
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            List<RegionInfo> countries = new List<RegionInfo>();
            foreach (CultureInfo ci in cultures)
            {
                RegionInfo regionInfo = new RegionInfo(ci.Name);
                if (countries.Count(x => x.EnglishName == regionInfo.EnglishName) <= 0)
                    countries.Add(regionInfo);
            }
            foreach (RegionInfo regionInfo in countries.OrderBy(x => x.EnglishName))
                Console.WriteLine(regionInfo.EnglishName);

            Console.WriteLine($"Amount countries: {countries.Count()}");
        }
    }
}
