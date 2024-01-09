//Create the custom class
public class Response<T>
{
    public string Message { set; get; }
    public string Code { set; get; }
    public T Data { set; get; }
}



//Generic intro

public class User
{
    public static void Main(string[] args)
    {
        Console.WriteLine(UserName<string>("This is generic type taking string as the type"));

        Console.WriteLine("This is generic type taking int as the type = " + UserName<int>(120));

    }
    public static string UserName<T>(T t)
    {
        return $"{t}";
    }
}
