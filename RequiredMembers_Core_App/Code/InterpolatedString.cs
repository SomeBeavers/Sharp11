// The handler that will actually "build" the interpolated string"

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

[InterpolatedStringHandler]
public ref struct TraceLoggerParamsInterpolatedStringHandler
{
    // Storage for the built-up string

    public required string Name { get; set; }
    private bool _logLevelEnabled;

    [SetsRequiredMembers]
    public TraceLoggerParamsInterpolatedStringHandler(int literalLength, int formattedCount, Logger logger, string name,
        out bool handlerIsValid)
    {
        handlerIsValid = false;
        _logLevelEnabled = false;
        Name = name;
    }

    public void AppendLiteral(string s)
    {
    }

    public void AppendFormatted<T>(T t)
    {
    }
}


public class Logger
{

    //public void LogTrace(Logger logger, string s) {}
    public void LogTrace(Logger logger, string name, [InterpolatedStringHandlerArgument("logger", "name")]TraceLoggerParamsInterpolatedStringHandler handler)
    {

    }
}

class MyClass11111
{
    public void Test()
    {
        
        Logger logger = new Logger();

        var b = "b";

        logger.LogTrace(logger, "", $"{b} a");

    }
}