using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using user_payment.model;

namespace Wema.BIT.User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Transaction> payment = new List<Transaction>()
            {
                new Transaction() {Id =1,UserId=1, Amount=1233},
                new Transaction() {Id =2,UserId=2, Amount=1233},
                new Transaction() {Id =3,UserId=3, Amount=1233}, 
                new Transaction() {Id =4,UserId=4, Amount=1233},
                new Transaction() {Id =5,UserId=5, Amount=1233}
            };


            List<user> users = new List<user>()
            {
                new user() {Id =1, FirstName="Aluh", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 1).ToList()},

                new user() {Id =2, FirstName="Jim", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 2).ToList()},

                new user() {Id =3, FirstName="Mike", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 3).ToList()},

                new user() {Id =4, FirstName="Jide", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 4).ToList()},

                new user() {Id =5, FirstName="Tomi", LastName="Johnson", Email="johnson@email.com", Payments=payment.Where(x => x.UserId == 5).ToList()},

            };

            var userPaymnets = users.Where(x => x.Id == 1);  
            var u = new List<user>();



            var json = JsonConvert.SerializeObject(userPaymnets, Formatting.Indented);

            foreach (var user in userPaymnets)
            {
                if (user.FirstName == "Tomi" || user.LastName == "Johnson") 
                { 
                    Console.WriteLine("First Name : " + user.FirstName + " Last Name : " + user.LastName);
                }
            }

        }
    }
}

