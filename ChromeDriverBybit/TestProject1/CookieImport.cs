using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

class CookieImport
{
    private static CookieImport instance;

    List<Cookie> CookieList;

    private CookieImport()
    {}

    public static CookieImport getInstance()
    {
        if (instance == null)
        {
            instance = new CookieImport();
            instance.CookieList = new List<Cookie>();
        }
        return instance;
    }

    public async void LoadCookies(string filepath)
    {
        using(FileStream fs = new FileStream("Cookie.json", FileMode.Open))
        {
            CookieList = await JsonSerializer.DeserializeAsync<List<Cookie>>(fs);
        }
    }
}