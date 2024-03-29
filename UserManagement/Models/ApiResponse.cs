﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UserManagement.Models;
using Newtonsoft.Json;

namespace UserManagement
    {
        public class ApiResource
        {
            public ApiResource()
            {
            }


            public async Task<Products> ProductAsync(int id)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://dummyjson.com/products/{id}");



                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();


                if (response.Content != null)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (content != null)
                    {
                        var myDeserializedClass = JsonConvert.DeserializeObject<Products>(content);

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


            public async Task<AllRoot> AllProductAsync()
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, "https://dummyjson.com/products");



                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();


                if (response.Content != null)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (content != null)
                    {
                        var myDeserializedClass = JsonConvert.DeserializeObject<AllRoot>(content);

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
        public class Products
        {
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public int price { get; set; }
            public double discountPercentage { get; set; }
            public double rating { get; set; }
            public int stock { get; set; }
            public string brand { get; set; }
            public string category { get; set; }
            public string thumbnail { get; set; }
            public List<string> images { get; set; }
        }


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AllRoot
        {
            public List<Products> products { get; set; }
            public int total { get; set; }
            public int skip { get; set; }
            public int limit { get; set; }
        }
    }