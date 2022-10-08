namespace RequiredMembers_Core_App.Code;

public record RecordWithBase
{
    public required string Name { get; set; }
}

record RecordWithBaseImpl(int Age) : RecordWithBase
{
}

public class UseRecordWithBase
{
    public void Test()
    {
        var recordWithBase = new RecordWithBaseImpl(1)
        {
            Name = "null"
        };

        var recordWithBaseImpl = recordWithBase with { Age =  2, Name = ""};
    }
}

