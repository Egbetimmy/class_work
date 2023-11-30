using System;
using System.Collections.Generic;
using Wema.BIT.IRepository;
using Wema.BIT.Repository;
using Wema.BIT.Models;

namespace Wema.BIT.User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUser userRepository = new UserRepository();

            // UserList object instantiation is corrected here
            UserList user = new UserList(); // Assuming you might want to perform operations on a single user

            List<UserList> users = new List<UserList>();

            Console.WriteLine("Enter User Details or 'exit' to stop:");

            while (true)
            {
                Console.Write("User ID: ");
                string userIdInput = Console.ReadLine();

                if (userIdInput.ToLower() == "exit")
                    break;

                if (!int.TryParse(userIdInput, out int userId))
                {
                    Console.WriteLine("Invalid User ID. Please enter a valid integer or 'exit' to stop.");
                    continue;
                }

                Console.Write("User Name: ");
                string userName = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                UserList newUser = new UserList(userId, userName, email);
                users.Add(newUser);
            }

            foreach (var userItem in users)
            {
                string result = userRepository.AddUser(userItem);
                Console.WriteLine(result);
            }

            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("Enter 1 to view user by ID");
                Console.WriteLine("Enter 2 to delete user by ID");
                Console.WriteLine("Enter 3 to edit user by ID");
                Console.WriteLine("Enter 'exit' to exit");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break; // Exit the loop when 'exit' is entered
                }

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter User ID to view: ");
                        if (int.TryParse(Console.ReadLine(), out int idToView))
                        {
                            userRepository.ViewUser(idToView);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter User ID to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int idToDelete))
                        {
                            userRepository.DeleteUser(idToDelete);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter User ID to edit: ");
                        if (int.TryParse(Console.ReadLine(), out int idToEdit))
                        {
                            userRepository.EditUser(idToEdit);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;


                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option or 'exit'.");
                        break;
                }
            }
        }
    }
}








/*

    public static void Main(string[] args)
    {


      Transaction transaction = new Transaction();


       var sumofAB = transaction.addTransaction();
    var mn = transaction.myName;
    var c = Transaction.mystaticname;


    Console.WriteLine(sumofAB);
    Console.WriteLine(mn);  
    Console.WriteLine(c);   




    //    int a;
    //    int b;
    //    int c;

    //    a=10; b=10;   

    //    c= a+b;

    //Console.WriteLine($"the value of a + b ={c}");


    // x =-b+- sqr(b^2-4ac))/2a

  ////  double a;
  ////  double b;
  ////  double c;
  ////  double d;
  ////  double e;
  ////double root = 0;   

  ////  //a = 1;
  ////  //b = -5;
  ////  //c = 3;


  ////  Console.WriteLine("Input the value of a");
  ////  a = Convert.ToDouble(Console.ReadLine());

  ////  Console.WriteLine("Input the value of b");
  ////  b = Convert.ToDouble(Console.ReadLine());

  ////  Console.WriteLine("Input the value of c");
  ////  c = Convert.ToDouble(Console.ReadLine());


  ////  //d = (-b) - (Math.Sqrt(Math.Abs(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
  ////  //e = (-b) + (Math.Sqrt(Math.Abs(Math.Pow(b, 2) - (4  * a * c))) / (2 * a));

  ////  //Console.WriteLine("X1 " + d);

  ////  //Console.WriteLine("X2 " + e);

  ////  root = (Math.Pow(b, 2) - (4 * a * c));

  ////  d = (-b) - (Math.Sqrt(Math.Abs(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
  ////  e = (-b) + (Math.Sqrt(Math.Abs(Math.Pow(b, 2) - (4  * a * c))) / (2 * a));
  ////  if (root < 0)
  ////  {
  ////      Console.WriteLine("No real roots ="  + d);

  ////      Console.WriteLine("No real roots =" + e);
  ////  }
  ////  else
  ////  {
  ////      d = (-b + Math.Sqrt(root)) / (2 * a);
  ////      e = (-b - Math.Sqrt(root)) / (2 * a);
  ////      Console.WriteLine("Root1: " + d + ", Root2: " + e);
  ////  }




    List<Transaction> transactions = new List<Transaction>()
    {
        new Transaction() {Id = 1, UserId = 1, Amount = 1233},
        new Transaction() {Id = 2, UserId = 2, Amount = 1233},
        new Transaction() {Id = 3, UserId = 3, Amount = 1233},
        new Transaction() {Id = 4, UserId = 4, Amount = 1233},
        new Transaction() {Id = 5, UserId = 5, Amount = 1233}
    };



        List<Users> users = new List<Users>()
        {
            new Users() {Id =1, FirstName="Aluh", LastName="Johnson", Email="johnson@email.com", Transactions=null},

            new Users() {Id =2, FirstName="Jim", LastName="Johnson", Email="johnson@email.com", Transactions = transactions.Where(x => x.UserId == 2).ToList()},

            new Users() {Id =3, FirstName="Mike", LastName="Johnson", Email="johnson@email.com", Transactions = transactions.Where(x => x.UserId == 3).ToList()},

            new Users() {Id =4, FirstName="Jide", LastName="Johnson", Email="johnson@email.com", Transactions = transactions.Where(x => x.UserId == 4).ToList()},

            new Users() {Id =5, FirstName="Tomi", LastName="Johnson", Email="johnson@email.com", Transactions = transactions.Where(x => x.UserId == 5).ToList()},

        };

        var userPaymnets = users.Where(x => x.Id == 1);
        var u = new List<User>();



        var json = JsonConvert.SerializeObject(userPaymnets, Formatting.Indented);

        foreach (var user in userPaymnets)
        {
            if(user.FirstName=="Tomi" || user.LastName == "Johnson")Console.WriteLine("First Name : " + user.FirstName +" Last Name : " + user.LastName);

        }


    }

}

public class Users
{

    public int Id { set; get; } 
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string Email { set; get; }
    public List<Transaction> Transactions { set; get; }
}

public class Transaction
{

public string myName = "John";

public static String mystaticname = "Static John";



public int addTransaction() 
{
    int a = 20;
    int b = 30;
    int c = a + b;

    return c;
}

    public int Id { set; get; }
    public int UserId { set; get; }
    public decimal Amount { set; get; }
    public User User { set; get; }
}

public class Account
{
    public int Id { set; get; }
    public string AccountNumber { set; get; }
    public string BVN { set; get; }
    public string AccountName { set; get; }
    public string PhoneNumber { set; get; }
}



*/

