using patt;

namespace ClassLibrary2;

public class Class2 : IPlugin
{
    public string Name { get; set; }

    public void Start()
    {
        Console.WriteLine("Plugin2 Started");
    }

    public void Execute()
    {
        Console.WriteLine("Plugin2 Executed");
    }

    public void Stop()
    {
        Console.WriteLine("Plugin2 Stopped");
    }
    
}