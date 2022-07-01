using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaAnyJsonInput;


public class Function
{

    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public object FunctionHandler(ReqBody input, ILambdaContext context)
    {
        if (input.Body != null)
            return input.Body;
        else
            return new object();
    }
}

public class ReqBody
{
    public object? Body { get; set; }
}
