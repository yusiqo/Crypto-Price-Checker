using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Kripto Fiyat Bilgisi Almak İçin Bir Kripto Para Birimi Girin (örnek: bitcoin):");
        string cryptoId = Console.ReadLine();

        try
        {
            string price = await GetCryptoPrice(cryptoId);
            if (price != null)
            {
                Console.WriteLine($"{cryptoId} için anlık fiyat: {price} USD");
            }
            else
            {
                Console.WriteLine("Kripto para bulunamadı veya bir hata oluştu.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }

    static async Task<string> GetCryptoPrice(string cryptoId)
    {
        string apiUrl = $"https://api.coingecko.com/api/v3/simple/price?ids={cryptoId}&vs_currencies=usd";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(jsonResult);

                // yusufun imzasiyla.....
                return data[cryptoId]?["usd"]?.ToString();
            }
        }

        return null;
    }
}
