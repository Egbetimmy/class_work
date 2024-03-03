using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UserManagement.Models
{
    public class ApiCart
    {
        /*var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Get, "https://dummyjson.com/carts");
        var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        Console.WriteLine(await response.Content.ReadAsStringAsync());
        */
        public async Task<Cart> CartAsync(int id)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://dummyjson.com/carts/{id}");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            if (response.Content != null)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (content != null)
                {
                    var myDeserializedClass = JsonConvert.DeserializeObject<Cart>(content);

                    return myDeserializedClass;
                }
            }
            return null;

            //var options = new RestClientOptions("https://dummyjson.com")
            //{
            //    MaxTimeout = -1,
            //};
            //var client = new RestClient(options);
            //var request = new RestRequest("/products/1", Method.Get);
            //RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
        }

        public async Task<Root> AllCartsAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://dummyjson.com/carts");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());


            if (response.Content != null)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (content != null)
                {
                    var myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);

                    return myDeserializedClass;
                }
            }

            return null;

            //var options = new RestClientOptions("https://dummyjson.com")
            //{
            //    MaxTimeout = -1,
            //};
            //var client = new RestClient(options);
            //var request = new RestRequest("/products/1", Method.Get);
            //RestResponse response = await client.ExecuteAsync(request);
            //Console.WriteLine(response.Content);
        }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Cart
    {
        public int id { get; set; }
        public List<Product> products { get; set; }
        public int total { get; set; }
        public int discountedTotal { get; set; }
        public int userId { get; set; }
        public int totalProducts { get; set; }
        public int totalQuantity { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public int total { get; set; }
        public double discountPercentage { get; set; }
        public int discountedPrice { get; set; }
        public string thumbnail { get; set; }
    }

    public class Root
    {
        public List<Cart> carts { get; set; }
        public int total { get; set; }
        public int skip { get; set; }
        public int limit { get; set; }
    }
}

