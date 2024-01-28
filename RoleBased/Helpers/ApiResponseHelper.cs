//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json; // Make sure to include the correct using statement

//public static class ApiResponseHelper
//{
//    public static IActionResult CreateSuccessResponse(string message = "Operation successful")
//    {
//        var customResponse = new CustomApiResponse(true, message);
//        return new ObjectResult(customResponse)
//        {
//            StatusCode = 200 // You can customize the status code for success
//        };
//    }

//    public static string GetSuccessResponseAsString(string message = "Operation successful")
//    {
//        var customResponse = new CustomApiResponse(true, message);
//        return JsonConvert.SerializeObject(customResponse);
//    }

//    public static IActionResult CreateErrorResponse(string message = "An error occurred")
//    {
//        var customErrorResponse = new CustomApiResponse(false, message);
//        return new ObjectResult(customErrorResponse)
//        {
//            StatusCode = 500 // You can customize the status code for errors
//        };
//    }

//    public static string GetErrorResponseAsString(string message = "An error occurred")
//    {
//        var customErrorResponse = new CustomApiResponse(false, message);
//        return JsonConvert.SerializeObject(customErrorResponse);
//    }
//}
