using System.Net;
using System.Collections.Generic;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
        var request = (HttpWebRequest) WebRequest.Create(url);
        request.Method= "GET";
        request.ContentType= "aplication/json";
        request.Accept= "aplication/json";
        try
        {
            using(WebResponse response= request.GetResponse())
            {
                using(Stream strReader= response.GetResponseStream())
                {
                    if (strReader == null) return;
                    using(StreamReader objReader= new StreamReader(strReader))
                    {
                        string responseBody= objReader.ReadToEnd();
                        proviciasArg provArgentina= JsonSerializer.Deserialize<proviciasArg>(responseBody);
                        foreach (var prov in provArgentina.provincias)
                        {
                            Console.WriteLine("Provincia: {0}\nId: {1}\n------------------", prov.nombre, prov.id);
                        }
                    }
                }
            }
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
           
        }
    }
}