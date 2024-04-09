using patt;

namespace ClassLibrary1;

public class Class1 : IPlugin
{
    public void Start()
    {
        Console.WriteLine("Class1 Started");
    }

    public void Execute()
    {
        Console.WriteLine("Class1 Executed");
    }

    public void Stop()
    {
       Console.WriteLine("Class1 Stopped");
    }
}