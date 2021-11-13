using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

class CookieImport
{
    private static CookieImport instance;

    public List<CustomCookie> CookieList;

    private CookieImport()
    {}

    public static CookieImport getInstance()
    {
        if (instance == null)
        {
            instance = new CookieImport();
            instance.CookieList = new List<CustomCookie>();
        }
        return instance;
    }

    public void LoadCookies(string filepath)
    {
        using(StreamReader fs = new StreamReader("D:\\3_course\\epam\\WebDriverBybit\\Cookie.json"))
        {
            var str = fs.ReadToEnd();
            CookieList = JsonSerializer.Deserialize<List<CustomCookie>>(str);

        }
    }
}

class CustomCookie
{
    public string Name { get; set; }
    public string Value { get; set; }
}