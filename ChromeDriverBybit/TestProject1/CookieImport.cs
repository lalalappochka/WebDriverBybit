using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

public static class CookieImport
{

    private static List<Cookie> cookieList = new List<Cookie>();

    public static List<Cookie> CookieList
    {
        get { return cookieList; }
    }

    public static void LoadCookies(string filepath)
    {
        FileStream fs = new FileStream(filepath, FileMode.Open);
        using (StreamReader sr = new StreamReader(fs))
        {
            cookieList = JsonConvert.DeserializeObject<List<Cookie>>(sr.ReadToEnd());
        }
    }
}