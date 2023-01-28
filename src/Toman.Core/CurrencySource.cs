using System.Collections.Generic;

namespace Toman;

internal static class CurrencySource
{



    private static IDictionary<string, Currency> _currencies = new Dictionary<string, Currency>
    {
        ["AED"] = Currency.Create("AED", "784", "United Arab Emirates dirham", "د.إ",2, "درهم", new []
        {
            "United Arab Emirates"
        }, "https://en.wikipedia.org/wiki/United_Arab_Emirates_dirham"),
        
        ["AFN"] = Currency.Create("AFN", "971", "Afghan afghani", "؋", 2, "افغانی", new []
        {
            "Afghanistan"
        }, "https://en.wikipedia.org/wiki/Afghan_afghani"),
        
        ["ALL"] = Currency.Create("ALL", "008", "Albanian lek", "L", 2, "آلبانیا", new []
        {
            "Albania"
        }, "https://en.wikipedia.org/wiki/Albanian_lek"),
        
        ["AMD"] = Currency.Create("AMD", "051", "Armenian dram", "֏", 2, "درام", new []
        {
            "Armenia"
        }, "https://en.wikipedia.org/wiki/Armenian_dram"),
        
        ["ANG"] = Currency.Create("ANG", "532", "Netherlands Antillean guilder", "ƒ", 2, "", new []
        {
            "Curaçao (CW)", "Sint Maarten (SX)"
        }, "https://en.wikipedia.org/wiki/Netherlands_Antillean_guilder"),
        
        ["AOA"] = Currency.Create("AOA", "973", "Angolan kwanza", "Kz", 2, "", new[]
        {
            "Angola"
        }, "https://en.wikipedia.org/wiki/Angolan_kwanza"),
        
        ["ARS"] = Currency.Create("ARS", "032", "Argentine peso", "$", 2, "پسو", new []
        {
            "Argentina"
        }, "https://en.wikipedia.org/wiki/Argentine_peso"),
        
        ["AUD"] = Currency.Create("AUD", "036", "Australian dollar", "$", 2, "دلار استرالیا", new[]
        {
            "Australia", "Christmas Island", "Cocos (Keeling) Islands",
            "Heard Island and McDonald Islands", "Kiribati",
            "Nauru", "Norfolk Island", "Tuvalu"
        }, "https://en.wikipedia.org/wiki/Australian_dollar"),
        
        ["AWG"] = Currency.Create("AWG", "533", "Aruban florin", "ƒ", 2, null, new[]
        {
            "Aruba"
        }, "https://en.wikipedia.org/wiki/Aruban_florin"),
        
        ["AZN"] = Currency.Create("AZN", "944", "Azerbaijani manat", "ман", 2, "مانات", new[]
        {
            "Azerbaijan"   
        }, "https://en.wikipedia.org/wiki/Azerbaijani_manat"),
        
        ["BAM"] = Currency.Create("BAM", "977", "Bosnia and Herzegovina convertible mark", "KM", 2, 
            "مارک تبدیل‌پذیر بوسنی و هرزگوین", new[]
        {
            "Bosnia and Herzegovina"
        }, "https://en.wikipedia.org/wiki/Bosnia_and_Herzegovina_convertible_mark"),
        
        ["BBD"] = Currency.Create("BBD", "052", "Barbados dollar", "$", 2, "دلار باربادوس", new[]
        {
            "Barbados"
        }, "https://en.wikipedia.org/wiki/Barbados_dollar"),
        
        ["BDT"] = Currency.Create("BDT", "050", "Bangladeshi taka", "৳", 2, "تاکا", new[]
        {
            "Bangladesh"
        }, "https://en.wikipedia.org/wiki/Bangladeshi_taka"),
        
        ["BGN"] = Currency.Create("BGN", "975", "Bulgarian lev", "лв.", 2, "لو بلغارستان", new[]
        {
            "Bulgaria"
        }, "https://en.wikipedia.org/wiki/Bulgarian_lev"),
        
        ["BHD"] = Currency.Create("BHD", "048", "Bahraini dinar", "BD", 3, "دینار بحرین", new[]
        {
            "Bahrain"
        }, "https://en.wikipedia.org/wiki/Bahraini_dinar"),
        
        ["BIF"] = Currency.Create("BIF", "108", "Burundian franc", "FBu", 0, "فرانک بوروندی", new[]
        {
            "Burundi"
        }, "https://en.wikipedia.org/wiki/Burundian_franc"),
        
        ["BMD"] = Currency.Create("BMD", "060", "Bermudian dollar", "$", 2, "دلار برمودا", new[]
        {
            "Bermuda"
        }, "https://en.wikipedia.org/wiki/Bermudian_dollar"),
        
        ["BND"] = Currency.Create("BND", "096", "Brunei dollar", "$", 2, "دلار برونئی", new[]
        {
            "Brunei"
        }, "https://en.wikipedia.org/wiki/Brunei_dollar"),
        
        ["BOB"] = Currency.Create("BOB", "068", "Boliviano", "Bs.", 2, "بولیویانو بولیوی", new[]
        {
            "Bolivia"
        }, "https://en.wikipedia.org/wiki/Boliviano"),
        
        ["DRL"] = Currency.Create("DRL", "986", "Brazilian real", "R$", 2, "رآل برزیلی", new[]
        {
            "Brazil"
        }, "https://en.wikipedia.org/wiki/Brazilian_real"),
        
        ["BSD"] = Currency.Create("BSD", "044", "Bahamian dollar", "$", 2, "دلار باهاما", new[]
        {
            "Bahamas"
        }, "https://en.wikipedia.org/wiki/Bahamian_dollar"),
        
        ["BTN"] = Currency.Create("BTN", "064", "Bhutanese ngultrum", "Nu.", 2, "نگولتروم بوتان", new[]
        {
            "Bhutan"
        }, "https://en.wikipedia.org/wiki/Bhutanese_ngultrum"),
        
        ["BWP"] = Currency.Create("BWP", "072", "Botswana pula", "P", 2, "پولای بوتسوانا", new[]
        {
            "Botswana"
        }, "https://en.wikipedia.org/wiki/Botswana_pula"),
        
        ["BYN"] = Currency.Create("BYN", "933", "Belarusian ruble", "Br", 2, "روبل", new[]
        {
            "Belarus"
        }, "https://en.wikipedia.org/wiki/Belarusian_rubel"),
        
        ["BZD"] = Currency.Create("BZD", "084", "Belize dollar", "BZ$", 2, "دلار بلیز", new[]
        {
            "Belize"
        }, "https://en.wikipedia.org/wiki/Belize_dollar"),
        
        ["CAD"] = Currency.Create("CAD", "124", "Canadian dollar", "$", 2, "دلار کانادا", new[]
        {
           "Canada" 
        },"Canadian dollar"),
        
        ["CDF"] = Currency.Create("CDF", "976", "Congolese franc", "FC", 2, "فرانک کنگو", new[]
        {
            "Democratic Republic of the Congo"
        }, "https://en.wikipedia.org/wiki/Congolese_franc"),
        
        ["CHE"] = Currency.Create("CHE", "947", "WIR Euro (complementary currency)", "CHE", 2, "بانک ویر", new[]
        {
            "Switzerland"
        }, "https://en.wikipedia.org/wiki/WIR_Bank"),
        
        ["CHF"] = Currency.Create("CHF", "756", "Swiss franc", "fr.", 2, "فرانک سوئیس", new[]
        {
            "Switzerland", "Liechtenstein"
        }, "https://en.wikipedia.org/wiki/Swiss_franc"),
      
        ["CLF"] = Currency.Create("CLF", "990", "Unidad de Fomento (funds code)", "CLF", 4, null, new[]
        {
            "Chile"
        }, "https://en.wikipedia.org/wiki/Unidad_de_Fomento"),
        
        ["CLP"] = Currency.Create("CLP", "152", "Chilean peso", "$", 0, "پزو", new[]
        {
            "Chile"
        }, "https://en.wikipedia.org/wiki/Chilean_peso"),
        
        ["COP"] = Currency.Create("COP", "170", "Colombian peso", "$", 2, "پزوی کلمبیا", new[]
        {
            "Colombia"
        }, "https://en.wikipedia.org/wiki/Colombian_peso"),
        
        ["COU"] = Currency.Create("COU", "970", "Unidad de Valor Real (UVR) (funds code)", Currency.UnknownCurrencySign,
            2, null, new[]
            {
                "Colombia"
            }),
        
        ["CRC"] = Currency.Create("CRC", "188", "Costa Rican colon", "₡", 2, "کولون کاستاریکا", new[]
        {
            "Costa Rica"
        }, "https://en.wikipedia.org/wiki/Costa_Rican_colon"),
        
        
        ["CUS"] = Currency.Create("CUS", "931", "Cuban convertible peso", "CUC$", 2, "پزوی تبدیل‌پذیر کوبا", new[]
        {
            "Cuba"
        }, "https://en.wikipedia.org/wiki/Cuban_convertible_peso"),
 
        ["CUP"] = Currency.Create("CUP", "192", "Cuban peso", "$", 2, "پزوی کوبا", new[]
        {
            "Cuba"
        }, "https://en.wikipedia.org/wiki/Cuban_peso"),
        
        ["CVE"] = Currency.Create("CVE", "132", "Cape Verdean escudo", "$", 2, "اسکودوی کیپ ورد", new[]
        {
            "Cabo Verde"
        }, "https://en.wikipedia.org/wiki/Cape_Verdean_escudo"),
        
        ["CZK"] = Currency.Create("CZK", "203", "Czech koruna", "Kč", 2, "کرونای چک", new[]
        {
            "Czechia"
        }, "https://en.wikipedia.org/wiki/Czech_koruna"),
      
        ["DJF"] = Currency.Create("DJF", "262", "Djiboutian franc", "Fdj", 0, "فرانک جیبوتی", new[]
        {
            "Djibouti"
        }, "https://en.wikipedia.org/wiki/Djiboutian_franc"),
        
        ["DKK"] = Currency.Create("DKK", "208", "Danish krone", "kr.", 2, "کرون دانمارک", new[]
        {
            "Denmark", "Faroe Islands", "Greenland"
        }, "https://en.wikipedia.org/wiki/Danish_krone"),
        
        ["DOP"] = Currency.Create("DOP", "214", "Dominican peso", "RD$", 2, "پزو دومینیکن", new[]
        {
            "Dominican Republic"
        }, "https://en.wikipedia.org/wiki/Dominican_peso"),
        
        ["DZD"] = Currency.Create("DZD", "012", "Algerian dinar", "DA", 2, "دینار الجزایر", new[]
        {
            "Algeria"
        }, "https://en.wikipedia.org/wiki/Algerian_dinar"),
        
        ["EGP"] = Currency.Create("EGP", "818", "Egyptian pound", "LE", 2, "پوند مصر", new[]
        {
            "Egypt"
        }, "https://en.wikipedia.org/wiki/Egyptian_pound"),
        
        ["ERN"] = Currency.Create("ERN", "232", "Eritrean nakfa", "ERN", 2, "ناکفای اریتره", new[]
        {
            "Eritrea"
        }, "https://en.wikipedia.org/wiki/Eritrean_nakfa"),
        
        ["ETP"] = Currency.Create("ETP", "230", "Ethiopian birr", "Br", 2, "بیر اتیوپی", new[]
        {
            "Ethiopia"
        }, "https://en.wikipedia.org/wiki/Ethiopian_birr"),
        
        ["EUR"] = Currency.Create("EUR", "978", "Euro", "€", 2, "", new[]
        {
            "Åland Islands", "European Union", "Andorra", "Austria", "Belgium", "Croatia", "Cyprus", 
            "Estonia", "Finland", "France", "French Southern and Antarctic Lands", "Germany", "Greece",
            "Guadeloupe", "Ireland", "Italy", "Kosovo", "Latvia", "Lithuania", "Luxembourg", "Malta",
            "French Guiana", "Martinique", "Mayotte", "Monaco", "Montenegro", "Netherlands", "Portugal",
            "Réunion", "Saint Barthélemy", "Saint Martin", "Saint Pierre and Miquelon", "San Marino",
            "Slovakia", "Slovenia", "Spain", "Vatican City"
        }, "https://en.wikipedia.org/wiki/Euro"),
        
        
    };
}