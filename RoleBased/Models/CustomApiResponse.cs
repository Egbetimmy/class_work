public class CustomApiResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }

    public CustomApiResponse(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    public string GetResponseAsString()
    {
        return $"Success: {Success}, Message: {Message}";
    }
}


//var customResponse = new CustomApiResponse(true, "Operation successful");
//Console.WriteLine(customResponse.GetResponseAsString());
