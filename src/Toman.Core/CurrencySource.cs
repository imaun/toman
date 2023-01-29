using System.Collections.Generic;

namespace Toman;

/// <summary>
/// Provides all the standard Currencies listed in ISO 4217 based on wikipedia.
/// Not including none-standard or historical currencies.
/// </summary>
/// <remarks>See: https://en.wikipedia.org/wiki/ISO_4217</remarks>
internal static class CurrencySource
{
    
    
    private static IDictionary<string, Currency> _currencies = new Dictionary<string, Currency>
    {
        ["AED"] = Currency.Create("AED", "784", "United Arab Emirates dirham", "د.إ", 2, "درهم", new[]
        {
            "United Arab Emirates"
        }, "https://en.wikipedia.org/wiki/United_Arab_Emirates_dirham"),

        ["AFN"] = Currency.Create("AFN", "971", "Afghan afghani", "؋", 2, "افغانی", new[]
        {
            "Afghanistan"
        }, "https://en.wikipedia.org/wiki/Afghan_afghani"),

        ["ALL"] = Currency.Create("ALL", "008", "Albanian lek", "L", 2, "آلبانیا", new[]
        {
            "Albania"
        }, "https://en.wikipedia.org/wiki/Albanian_lek"),

        ["AMD"] = Currency.Create("AMD", "051", "Armenian dram", "֏", 2, "درام", new[]
        {
            "Armenia"
        }, "https://en.wikipedia.org/wiki/Armenian_dram"),

        ["ANG"] = Currency.Create("ANG", "532", "Netherlands Antillean guilder", "ƒ", 2, "", new[]
        {
            "Curaçao (CW)", "Sint Maarten (SX)"
        }, "https://en.wikipedia.org/wiki/Netherlands_Antillean_guilder"),

        ["AOA"] = Currency.Create("AOA", "973", "Angolan kwanza", "Kz", 2, "", new[]
        {
            "Angola"
        }, "https://en.wikipedia.org/wiki/Angolan_kwanza"),

        ["ARS"] = Currency.Create("ARS", "032", "Argentine peso", "$", 2, "پسو", new[]
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
        }, "Canadian dollar"),

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

        ["EUR"] = Currency.Create("EUR", "978", "Euro", "€", 2, "یورو", new[]
        {
            "Åland Islands", "European Union", "Andorra", "Austria", "Belgium", "Croatia", "Cyprus",
            "Estonia", "Finland", "France", "French Southern and Antarctic Lands", "Germany", "Greece",
            "Guadeloupe", "Ireland", "Italy", "Kosovo", "Latvia", "Lithuania", "Luxembourg", "Malta",
            "French Guiana", "Martinique", "Mayotte", "Monaco", "Montenegro", "Netherlands", "Portugal",
            "Réunion", "Saint Barthélemy", "Saint Martin", "Saint Pierre and Miquelon", "San Marino",
            "Slovakia", "Slovenia", "Spain", "Vatican City"
        }, "https://en.wikipedia.org/wiki/Euro"),

        ["FJD"] = Currency.Create("FJD", "242", "Fiji dollar", "$", 2, "دلار فیجی", new[]
        {
            "Fiji"
        }, "https://en.wikipedia.org/wiki/Fijian_dollar"),

        ["FKP"] = Currency.Create("FPK", "238", "Falkland Islands pound", "£", 2, "پوند جزایر فالکلند", new[]
        {
            "Falkland Islands"
        }, "https://en.wikipedia.org/wiki/Falkland_Islands_pound"),

        ["GBP"] = Currency.Create("GBP", "826", "Pound sterling", "£", 2, "پوند استرلینگ", new[]
        {
            "United Kingdom", "Isle of Man", "Jersey", "Guernsey", "Tristan da Cunha"
        }, "https://en.wikipedia.org/wiki/Pound_sterling"),

        ["GEL"] = Currency.Create("GEL", "981", "Georgian lari", "ლ.", 2, "لاری", new[]
        {
            "Georgia"
        }, "https://en.wikipedia.org/wiki/Georgian_lari"),

        ["GHS"] = Currency.Create("GHS", "936", "Ghanaian cedi", "GH¢", 2, "سدی غنا", new[]
        {
            "Ghana"
        }, "https://en.wikipedia.org/wiki/Ghanaian_cedi"),

        ["GIP"] = Currency.Create("GIP", "292", "Gibraltar pound", "£", 2, "پوند جبل طارق", new[]
        {
            "Gibraltar"
        }, "https://en.wikipedia.org/wiki/Gibraltar_pound"),

        ["GMD"] = Currency.Create("GMD", "270", "Gambian dalasi", "D", 2, "دالاسی گامبیا", new[]
        {
            "Gambia"
        }, "https://en.wikipedia.org/wiki/Gambian_dalasi"),

        ["GNF"] = Currency.Create("GNF", "324", "Guinean Franc", "FG", 0, "فرانک گینه", new[]
        {
            "Guinea"
        }, "https://en.wikipedia.org/wiki/Guinean_franc"),

        ["GTQ"] = Currency.Create("GTQ", "320", "Guatemalan quetzal", "Q", 2, "کوئتزال گواتمالا", new[]
        {
            "Guatemala"
        }, "https://en.wikipedia.org/wiki/Guatemalan_quetzal"),

        ["CYD"] = Currency.Create("CYD", "328", "Guyanese dollar", "$", 2, "دلار گویان", new[]
        {
            "Guyana"
        }, "https://en.wikipedia.org/wiki/Guyanese_dollar"),

        ["HKD"] = Currency.Create("HKD", "344", "Hong Kong dollar", "HK$", 2, "دلار هنگ کنگ", new[]
        {
            "Hong Kong"
        }, "https://en.wikipedia.org/wiki/Hong_Kong_dollar"),

        ["HNL"] = Currency.Create("HNL", "340", "Honduran lempira", "L", 2, "لامپیرای هندوراس", new[]
        {
            "Honduras"
        }, "https://en.wikipedia.org/wiki/Honduran_lempira"),

        ["HTG"] = Currency.Create("HTG", "332", "Haitian gourde", "G", 2, "گورد هائیتی", new[]
        {
            "Haitian gourde"
        }, "https://en.wikipedia.org/wiki/Haitian_gourde"),

        ["HUF"] = Currency.Create("HUF", "348", "Hungarian forint", "Ft", 2, "فورینت مجارستان", new[]
        {
            "Hungary"
        }, "https://en.wikipedia.org/wiki/Hungarian_forint"),

        ["IDR"] = Currency.Create("IDR", "360", "Indonesian rupiah", "Rp", 2, "روپیه اندونزی", new[]
        {
            "Indonesia"
        }, "https://en.wikipedia.org/wiki/Indonesian_rupiah"),

        ["ILS"] = Currency.Create("ILS", "376", "Israeli new shekel", "₪", 2, "شِکِل جدید اسرائیل", new[]
        {
            "Israel"
        }, "https://en.wikipedia.org/wiki/Israeli_new_shekel"),

        ["INR"] = Currency.Create("INR", "356", "Indian rupee", "₹", 2, "روپیه", new[]
        {
            "India", "Bhutan"
        }, "https://en.wikipedia.org/wiki/Indian_rupee"),


        ["IQD"] = Currency.Create("IQD", "368", "Iraqi dinar", "د.ع", 3, "دینار عراق", new[]
        {
            "Iraq"
        }, "https://en.wikipedia.org/wiki/Iraqi_dinar"),

        ["IRR"] = Currency.Create("IRR", "364", "Iranian Rial", "ریال", 0, "ریال ایران", new[]
        {
            "Iran"
        }, "https://en.wikipedia.org/wiki/Iranian_rial"),

        ["ISK"] = Currency.Create("ISK", "352", "Icelandic króna", "kr", 0, "کرونا ایسلند", new[]
        {
            "Iceland"
        }, "https://en.wikipedia.org/wiki/Icelandic_kr%C3%B3na"),

        ["JMD"] = Currency.Create("JMD", "388", "Jamaican dollar", "J$", 2, "دلار جامائیکا", new[]
        {
            "Jamaica"
        }, "https://en.wikipedia.org/wiki/Jamaican_dollar"),

        ["JOD"] = Currency.Create("JOD", "400", "Jordanian dinar", "د.ا.‏", 3, "دینار اردن", new[]
        {
            "Jordan"
        }, "https://en.wikipedia.org/wiki/Jordanian_dinar"),

        ["JPY"] = Currency.Create("JPY", "392", "Japanese yen", "¥", 0, "یـِن", new[]
        {
            "Japan"
        }, "https://en.wikipedia.org/wiki/Japanese_yen"),

        ["KES"] = Currency.Create("KES", "404", "Kenyan shilling", "KSh", 2, "شیلینگ کنیا", new[]
        {
            "Kenya"
        }, "https://en.wikipedia.org/wiki/Kenyan_shilling"),

        ["KGS"] = Currency.Create("KGS", "417", "Kyrgyzstani som", "сом", 2, "سوم", new[]
        {
            "Kyrgyzstan"
        }, "https://en.wikipedia.org/wiki/Kyrgyzstani_som"),

        ["KHR"] = Currency.Create("KHR", "116", "Cambodian riel", "៛", 2, "ریل کامبوج", new[]
        {
            "Cambodia"
        }, "https://en.wikipedia.org/wiki/Cambodian_riel"),

        ["KMF"] = Currency.Create("KMF", "174", "Comorian Franc", "CF", 0, "فرانک کُمُر", new[]
        {
            "Comoros"
        }, "https://en.wikipedia.org/wiki/Comoro_franc"),

        ["KPW"] = Currency.Create("KPW", "408", "North Korean won", "₩", 2, "وون کره شمالی", new[]
        {
            "North Korea"
        }, "https://en.wikipedia.org/wiki/North_Korean_won"),

        ["KRW"] = Currency.Create("KRW", "410", "South Korean won", "₩", 0, "وون", new[]
        {
            "South Korea"
        }, "https://en.wikipedia.org/wiki/South_Korean_won"),

        ["KWD"] = Currency.Create("KWD", "414", "Kuwaiti dinar", "د.ك", 3, "دینار کویت", new[]
        {
            "Kuwait"
        }, "https://en.wikipedia.org/wiki/Kuwaiti_dinar"),

        ["KYD"] = Currency.Create("KYD", "136", "Cayman Islands dollar", "$", 2, "دلار جزایر کیمن", new[]
        {
            "Cayman Islands"
        }, "https://en.wikipedia.org/wiki/Cayman_Islands_dollar"),

        ["KZT"] = Currency.Create("KZT", "398", "Kazakhstani tenge", "₸", 2, "تنگه", new[]
        {
            "Kazakhstan"
        }, "https://en.wikipedia.org/wiki/Kazakhstani_tenge"),

        ["LAK"] = Currency.Create("LAK", "418", "Lao Kip", "₭", 2, "کیپ لائوس", new[]
        {
            "Laos"
        }, "https://en.wikipedia.org/wiki/Lao_kip"),

        ["LBP"] = Currency.Create("LBP", "422", "Lebanese pound", "ل.ل", 2, "لیره لبنان", new[]
        {
            "Lebanon"
        }, "https://en.wikipedia.org/wiki/Lebanese_pound"),

        ["LKR"] = Currency.Create("LKR", "144", "Sri Lankan rupee", "Rs", 2, "روپیه سری‌لانکا", new[]
        {
            "Sri Lanka"
        }, "https://en.wikipedia.org/wiki/Sri_Lankan_rupee"),

        ["LDR"] = Currency.Create("LRD", "430", "Liberian dollar", "$", 2, "دلار لیبریا", new[]
        {
            "Liberia"
        }, "https://en.wikipedia.org/wiki/Liberian_dollar"),

        ["LSL"] = Currency.Create("LSL", "426", "Lesotho loti", "L", 2, "لوتی لسوتو", new[]
        {
            "Lesotho"
        }, "https://en.wikipedia.org/wiki/Lesotho_loti"),

        ["LYD"] = Currency.Create("LYD", "434", "Libyan dinar", "ل.د", 3, "دینار لیبی", new[]
        {
            "Libya"
        }, "https://en.wikipedia.org/wiki/Libyan_dinar"),

        ["MAD"] = Currency.Create("MAD", "504", "Moroccan dirham", "د.م.", 2, "درهم مراکش", new[]
        {
            " Morocco", "Western Sahara"
        }, "https://en.wikipedia.org/wiki/Moroccan_dirham"),

        ["MDL"] = Currency.Create("MDL", "498", "Moldovan leu", "L", 2, "لئوی مولداوی", new[]
        {
            "Moldova"
        }, "https://en.wikipedia.org/wiki/Moldovan_leu"),

        ["MGA"] = Currency.Create("MGA", "969", "Malagasy ariary", "Ar", 2, "آریاری ماداگاسکار", new[]
        {
            "Madagascar"
        }, "https://en.wikipedia.org/wiki/Malagasy_ariary"),

        ["MKD"] = Currency.Create("MKD", "807", "Macedonian denar", "ден", 2, "دینار مقدونیه", new[]
        {
            "North Macedonia"
        }, "https://en.wikipedia.org/wiki/Macedonian_denar"),

        ["MMK"] = Currency.Create("MMK", "104", "Myanma kyat", "K", 2, "کیات میانمار", new[]
        {
            "Myanmar"
        }, "https://en.wikipedia.org/wiki/Myanmar_kyat"),

        ["MNT"] = Currency.Create("MNT", "496", "Mongolian tugrik", "₮", 2, "توگروگ مغولستان", new[]
        {
            "Mongolia"
        }, "https://en.wikipedia.org/wiki/Mongolian_t%C3%B6gr%C3%B6g"),

        ["MOP"] = Currency.Create("MOP", "446", "Macanese pataca", "MOP$", 2, "پاتاکای ماکائو", new[]
        {
            "Macau"
        }, "https://en.wikipedia.org/wiki/Macanese_pataca"),

        ["MRU"] = Currency.Create("MRU", "929", "Mauritanian ouguiya", "UM", 2, "اوقیه موریتانی", new[]
        {
            "Mauritania"
        }, "https://en.wikipedia.org/wiki/Mauritanian_ouguiya"),

        ["MUR"] = Currency.Create("MUR", "480", "Mauritian rupee", "Rs", 2, "روپیه موریس", new[]
        {
            "Mauritius"
        }, "https://en.wikipedia.org/wiki/Mauritian_rupee"),

        ["MVR"] = Currency.Create("MVR", "462", "Maldivian rufiyaa", "Rf", 2, "روفیه مالدیو", new[]
        {
            "Maldives"
        }, "https://en.wikipedia.org/wiki/Maldivian_rufiyaa"),

        ["MWK"] = Currency.Create("MWK", "454", "Malawi kwacha", "MK", 2, "کواچا مالاویا", new[]
        {
            "Malawi"
        }, "https://en.wikipedia.org/wiki/Malawian_kwacha"),

        ["MXN"] = Currency.Create("MXN", "484", "Mexican peso", "$", 2, "پزو مکزیک", new[]
        {
            "Mexico"
        }, "https://en.wikipedia.org/wiki/Mexican_peso"),

        ["MXV"] = Currency.Create("MXV", "979", "Mexican Unidad de Inversion (UDI) (funds code)",
            Currency.UnknownCurrencySign, 2, null, new[]
            {
                "Mexico"
            }, "https://en.wikipedia.org/wiki/Mexican_Unidad_de_Inversion"),

        ["MYR"] = Currency.Create("MYR", "458", "Malaysian ringgit", "RM", 2, "رینگیت مالزی", new[]
        {
            "Malaysia"
        }, "https://en.wikipedia.org/wiki/Malaysian_ringgit"),

        ["MZN"] = Currency.Create("MZN", "943", "Mozambican metical", "MTn", 2, "متیکال موزامبیک", new[]
        {
            "Mozambique"
        }, "https://en.wikipedia.org/wiki/Mozambican_metical"),

        ["NAD"] = Currency.Create("NAD", "516", "Namibian dollar", "N$", 2, "دلار نامیبیا", new[]
        {
            "Namibia"
        }, "https://en.wikipedia.org/wiki/Namibian_dollar"),

        ["NGN"] = Currency.Create("NGN", "566", "Nigerian naira", "₦", 2, "نایرا نیجریه", new[]
        {
            "Nigeria"
        }, "https://en.wikipedia.org/wiki/Nigerian_naira"),

        ["NIO"] = Currency.Create("NIO", "558", "Nicaraguan córdoba", "C$", 2, "کوردوبای نیکاراگوئه", new[]
        {
            "Nicaragua"
        }, "https://en.wikipedia.org/wiki/Nicaraguan_c%C3%B3rdoba"),

        ["NOK"] = Currency.Create("NOK", "578", "Norwegian krone", "kr", 2, "کرون نروژ", new[]
        {
            "Norway", "Svalbard", "Jan Mayen", "Bouvet Island"
        }, "https://en.wikipedia.org/wiki/Norwegian_krone"),

        ["NPR"] = Currency.Create("NPR", "524", "Nepalese rupee", "Rs", 2, "روپیه نپال", new[]
        {
            "Nepal"
        }, "https://en.wikipedia.org/wiki/Nepalese_rupee", new[] { "₨", "रू" }),

        ["NZD"] = Currency.Create("NZD", "554", "New Zealand dollar", "$", 2, "دلار نیوزیلند", new[]
        {
            "New Zealand", "Cook Islands", "Niue", "Pitcairn Islands", "Tokelau"
        }, "https://en.wikipedia.org/wiki/New_Zealand_dollar"),

        ["OMR"] = Currency.Create("OMR", "512", "Omani rial", "ر.ع.", 3, "ریال عمان", new[]
        {
            "Oman"
        }, "https://en.wikipedia.org/wiki/Omani_rial"),

        ["PAB"] = Currency.Create("PAB", "590", "Panamanian balboa", "B/.", 2, "بالبوآ پاناما", new[]
        {
            "Panama"
        }, "https://en.wikipedia.org/wiki/Panamanian_balboa"),

        ["PEN"] = Currency.Create("PEN", "604", "Peruvian sol", "S/.", 2, "سول پرو", new[]
        {
            "Peru"
        }, "https://en.wikipedia.org/wiki/Peruvian_sol"),

        ["PGK"] = Currency.Create("PGK", "598", "Papua New Guinean kina", "K", 2, "کینای پاپوآ گینه نو", new[]
        {
            "Papua New Guinea"
        }, "https://en.wikipedia.org/wiki/Papua_New_Guinean_kina"),

        ["PHP"] = Currency.Create("PHP", "608", "Philippine Peso", "₱", 2, "پزو فیلیپین", new[]
        {
            "Philippines"
        }, "https://en.wikipedia.org/wiki/Philippine_peso", new[] { "PHP", "P", "PhP" }),

        ["PKR"] = Currency.Create("PKR", "586", "Pakistani rupee", "Rs", 2, "روپیه پاکستان", new[]
        {
            "Pakistan"
        }, "https://en.wikipedia.org/wiki/Pakistani_rupee"),

        ["PLN"] = Currency.Create("PLN", "985", "Polish złoty", "zł", 2, "زلوتی لهستان", new[]
        {
            "Poland"
        }, "https://en.wikipedia.org/wiki/Polish_z%C5%82oty"),

        ["PYG"] = Currency.Create("PYG", "600", "Paraguayan guaraní", "₲", 0, "گوارانی پاراگوئه", new[]
        {
            "Paraguay"
        }, "https://en.wikipedia.org/wiki/Paraguayan_guaran%C3%AD"),

        ["QAR"] = Currency.Create("QAR", "634", "Qatari riyal", "ر.ق", 2, "ریال قطر", new[]
        {
            "Qatar"
        }, "https://en.wikipedia.org/wiki/Qatari_riyal"),

        ["RON"] = Currency.Create("RON", "946", "Romanian new leu", "lei", 2, "لئوی رومانی", new[]
        {
            "Romania"
        }, "https://en.wikipedia.org/wiki/Romanian_leu"),

        ["RSD"] = Currency.Create("RSD", "941", "Serbian dinar", "РСД", 2, "دینار صربستان", new[]
        {
            "Serbia"
        }, "https://en.wikipedia.org/wiki/Serbian_dinar", new[] { "RSD", "дин", "d./д" }),

        ["RUB"] = Currency.Create("RUB", "643", "Russian rouble", "₽", 2, "روبل روسیه", new[]
        {
            "Russia"
        }, "https://en.wikipedia.org/wiki/Russian_ruble", new[] { "R", "py6" }),

        ["CYN"] = Currency.Create("CYN", "156", "Renminbi", "¥", 2, "رنمینبی", new[]
        {
            "China"
        }, "https://en.wikipedia.org/wiki/Renminbi"),

        ["RWF"] = Currency.Create("RWF", "646", "Rwandan franc", "RFw", 0, "فرانک رواندا", new[]
        {
            "Rwanda"
        }, "https://en.wikipedia.org/wiki/Rwandan_franc", new[] { "RF", "R₣" }),

        ["SAR"] = Currency.Create("SAR", "682", "Saudi riyal", "ر.س", 2, "ریال سعودی", new[]
        {
            "Saudi Arabia"
        }, "https://en.wikipedia.org/wiki/Saudi_riyal", new[] { "SR", "﷼" }),

        ["SBD"] = Currency.Create("SBD", "090", "Solomon Islands dollar", "SI$", 2, "دلار جزایر سلیمان", new[]
        {
            "Solomon Islands"
        }, "https://en.wikipedia.org/wiki/Solomon_Islands_dollar"),

        ["SCR"] = Currency.Create("SCR", "690", "Seychelles rupee", "SR", 2, "روپیه سیشل", new[]
        {
            "Seychelles"
        }, "https://en.wikipedia.org/wiki/Seychelles_rupee", new[] { "SRe" }),

        ["SDG"] = Currency.Create("SDG", "938", "Sudanese pound", "ج.س.", 2, "پوند سودان", new[]
        {
            "Sudan"
        }, "https://en.wikipedia.org/wiki/Sudanese_pound"),

        ["SEK"] = Currency.Create("SEK", "752", "Swedish krona/kronor", "kr", 2, "کرون سوئد", new[]
        {
            "Sweden"
        }, "https://en.wikipedia.org/wiki/Swedish_krona"),

        ["SGD"] = Currency.Create("SGD", "702", "Singapore dollar", "S$", 2, "دلار سنگاپور", new[]
        {
            "Singapore"
        }, "https://en.wikipedia.org/wiki/Singapore_dollar", new[] { "$" }),

        ["SHP"] = Currency.Create("SHP", "654", "Saint Helena pound", "£", 2, "پوند سنت هلن", new[]
        {
            "Saint Helena", "Ascension Island"
        }, "https://en.wikipedia.org/wiki/Saint_Helena_pound"),

        ["SLL"] = Currency.Create("SLL", "694", "Sierra Leonean leone", "Le", 2, "لئون سیرالئون", new[]
        {
            "Sierra Leone"
        }, "https://en.wikipedia.org/wiki/Sierra_Leonean_leone"),

        ["SOS"] = Currency.Create("SOS", "706", "Somali shilling", "S", 2, "شیلینگ سومالی", new[]
        {
            "Somalia"
        }, "https://en.wikipedia.org/wiki/Somali_shilling"),

        ["SRD"] = Currency.Create("SRD", "968", "Surinamese dollar", "$", 2, "دلار سورینام", new[]
        {
            "Suriname"
        }, "https://en.wikipedia.org/wiki/Surinamese_dollar"),

        ["SSP"] = Currency.Create("SSP", "728", "South Sudanese pound", "£", 2, "پوند سودان جنوبی", new[]
        {
            "South Sudan"
        }, "https://en.wikipedia.org/wiki/South_Sudanese_pound"),

        ["SVC"] = Currency.Create("SVC", "222", "El Salvador Colon", "₡", 2, "کولون السالوادور", new[]
        {
            "El Salvador"
        }, "https://en.wikipedia.org/wiki/Salvadoran_col%C3%B3n"),

        ["SYP"] = Currency.Create("SYP", "760", "Syrian pound", "ܠ.ܣ.‏", 2, "لیره سوریه", new[]
        {
            "Syria"
        }, "https://en.wikipedia.org/wiki/Syrian_pound", new[] { "LS", "£S", "£" }),

        ["SZL"] = Currency.Create("SZL", "748", "Swazi lilangeni", "L", 2, "لیلانگنی سوازی", new[]
        {
            "Eswatini"
        }, "https://en.wikipedia.org/wiki/Swazi_lilangeni", new[] { "E" }),

        ["THB"] = Currency.Create("THB", "764", "Thai baht", "฿", 2, "بات تایلند", new[]
        {
            "Thailand"
        }, "https://en.wikipedia.org/wiki/Thai_baht"),

        ["TJS"] = Currency.Create("TJS", "972", "Tajikistani somoni", "смн", 2, "سامانی", new[]
        {
            "Tajikistan"
        }, "https://en.wikipedia.org/wiki/Tajikistani_somoni"),

        ["TMT"] = Currency.Create("TMT", "934", "Turkmenistani manat", "m", 2, "منات ترکمنستان", new[]
        {
            ""
        }, "https://en.wikipedia.org/wiki/Turkmenistani_manat", new[] { "T?" }),

        ["TND"] = Currency.Create("TND", "788", "Tunisian dinar", "د.ت", 3, "دینار تونس", new[]
        {
            "Tunisia"
        }, "https://en.wikipedia.org/wiki/Tunisian_dinar", new[] { "DT" }),

        ["TOP"] = Currency.Create("TOP", "776", "Tongan paʻanga", "T$", 2, "پاآنگای تونگا", new[]
        {
            "Tonga"
        }, "https://en.wikipedia.org/wiki/Tongan_pa%CA%BBanga", new[] { "PT" }),

        ["TRY"] = Currency.Create("TRY", "949", "Turkish lira", "₺", 2, "لیره ترک", new[]
        {
            "Turkey"
        }, "https://en.wikipedia.org/wiki/Turkish_lira"),

        ["TTD"] = Currency.Create("TTD", "780", "Trinidad and Tobago dollar", "$", 2, "دلار ترینیداد و توباگو", new[]
        {
            "Trinidad and Tobago"
        }, "https://en.wikipedia.org/wiki/Trinidad_and_Tobago_dollar", new[] { "TT$" }),

        ["TWD"] = Currency.Create("TWD", "901", "New Taiwan dollar", "NT$", 2, "دلار جدید تایوان", new[]
        {
            "Taiwan"
        }, "https://en.wikipedia.org/wiki/New_Taiwan_dollar", new[] { "$" }),

        ["TZS"] = Currency.Create("TZS", "834", "Tanzanian shilling", "x/y", 2, "شیلینگ تانزانیا", new[]
        {
            "Tanzania"
        }, "https://en.wikipedia.org/wiki/Tanzanian_shilling", new[] { "TSh" }),

        ["UAH"] = Currency.Create("UAH", "980", "Ukrainian hryvnia", "₴", 2, "گریونا اوکراین", new[]
        {
            "Ukraine"
        }, "https://en.wikipedia.org/wiki/Ukrainian_hryvnia"),

        ["UGX"] = Currency.Create("UGX", "800", "Ugandan shilling", "USh", 0, "شیلینگ اوگاندا", new[]
        {
            "Uganda"
        }, "https://en.wikipedia.org/wiki/Ugandan_shilling"),

        ["USD"] = Currency.Create("USD", "840", "United States dollar", "$", 2, "دلار آمریکا", new[]
        {
            "United States", "American Samoa", "British Indian Ocean Territory", "British Virgin Islands",
            "Caribbean Netherlands", "Ecuador", "El Salvador", "Guam", "Marshall Islands",
            "Federated States of Micronesia", "Northern Mariana Islands", "Palau", "Panama",
            "Puerto Rico", "Timor-Leste", "Turks and Caicos Islands", "U.S. Virgin Islands",
            "United States Minor Outlying Islands"
        }, "https://en.wikipedia.org/wiki/United_States_dollar", new[] { "US$" }),

        ["USN"] = Currency.Create("USN", "997", "United States dollar (next day) (funds code)", "$", 2, null, new[]
        {
            "https://en.wikipedia.org/wiki/United_States"
        }),

        ["UYU"] = Currency.Create("UYU", "858", "Uruguayan peso", "$", 2, "پزوی اروگوئه", new[]
        {
            "Uruguay"
        }, "https://en.wikipedia.org/wiki/Uruguayan_peso", new[] { "$U" }),

        ["UZS"] = Currency.Create("UZS", "860", "Uzbekistan som", "лв", 2, "سوم ازبکستان", new[]
        {
            "Uzbekistan"
        }, "https://en.wikipedia.org/wiki/Uzbekistani_soum", new[] { "сўм" }),

        ["VES"] = Currency.Create("VES", "928", "Venezuelan Bolívar Soberano", "Bs.", 2, "بولیوار ونزوئلا", new[]
        {
            "Venezuela"
        }, "https://en.wikipedia.org/wiki/Venezuelan_bol%C3%ADvar#Sovereign_bol%C3%ADvar", new[] { "Bs.F" }),

        ["VND"] = Currency.Create("VND", "704", "Vietnamese dong", "₫", 0, "دانگ ویتنام", new[]
        {
            "Vietnam"
        }, "https://en.wikipedia.org/wiki/Vietnamese_%C4%91%E1%BB%93ng"),

        ["VUV"] = Currency.Create("VUV", "548", "Vanuatu vatu", "VT", 0, "واتوی وانواتو", new[]
        {
            "Vanuatu"
        }, "https://en.wikipedia.org/wiki/Vanuatu_vatu"),

        ["WST"] = Currency.Create("WST", "882", "Samoan tala", "WS$", 2, "تالای ساموآ", new[]
        {
            "Samoa"
        }, "https://en.wikipedia.org/wiki/Samoan_tala", new[] { "SAT", "ST", "T" }),

        ["XAF"] = Currency.Create("XAF", "950", "CFA franc BEAC", "FCFA", 0, "فرانک سی‌اف‌ای آفریقای میانه", new[]
        {
            "Cameroon", "Central African Republic", "Republic of the Congo", "Chad",
            "Equatorial Guinea", "Gabon"
        }, "https://en.wikipedia.org/wiki/Central_African_CFA_franc"),

        ["XAG"] = Currency.Create("XAG", "961", "Silver (one troy ounce)", Currency.UnknownCurrencySign, 0, "نقره"),

        ["XAU"] = Currency.Create("XAU", "959", "Gold (one troy ounce)", Currency.UnknownCurrencySign, 0, "طلا"),

        ["XCD"] = Currency.Create("XCD", "951", "East Caribbean dollar", "$", 2, "دلار کارائیب شرقی", new[]
        {
            "Anguilla", "Antigua and Barbuda", "Dominica", "Grenada", "Montserrat", "Saint Kitts and Nevis",
            "Saint Lucia", "Saint Vincent and the Grenadines"
        }, "https://en.wikipedia.org/wiki/East_Caribbean_dollar", new[] { "EC$" }),

        ["XOF"] = Currency.Create("XOF", "952", "CFA franc BCEAO", "CFA", 0, "فرانک سی‌اف‌ای آفریقای غربی", new[]
        {
            "Benin", "Burkina Faso", "Côte d'Ivoire", "Guinea-Bissau", "Mali", "Niger", "Senegal", "Togo"
        }, "https://en.wikipedia.org/wiki/West_African_CFA_franc"),

        ["XPF"] = Currency.Create("XPF", "953", "CFP franc", "F", 0, "فرانک اقیانوسیه", new[]
        {
            "French Polynesia", "New Caledonia", "Wallis and Futuna"
        }, "https://en.wikipedia.org/wiki/CFP_franc"),

        ["YER"] = Currency.Create("YER", "886", "Yemeni rial", "﷼", 2, "ریال یمن", new[]
        {
            "Yemen"
        }, "https://en.wikipedia.org/wiki/Yemeni_rial"),

        ["ZAR"] = Currency.Create("ZAR", "710", "South African rand", "R", 2, "رند آفریقای جنوبی", new[]
        {
            "Eswatini", "Lesotho", "Namibia", "South Africa"
        }, "https://en.wikipedia.org/wiki/South_African_rand"),

        ["ZMW"] = Currency.Create("ZMW", "967", "Zambian kwacha", "ZK", 2, "کواچای زامبیا", new[]
        {
            "Zambia"
        }, "https://en.wikipedia.org/wiki/Zambian_kwacha", new[] { "ZMW" }),

        ["ZWL"] = Currency.Create("ZWL", "932", "Zimbabwean dollar", "$", 2, "دلار زیمبابوه", new[]
        {
            "Zimbabwe"
        }, "https://en.wikipedia.org/wiki/Zimbabwean_dollar_(2019%E2%80%93present)"),
        
        
    };
}