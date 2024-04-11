using patt;

namespace ClassLibrary1;

public class Class1 : IPlugin
{
    public string Name { get; set; }

    public void Start()
    {
        Console.WriteLine("Plugin1 Started");
    }

    public void Execute()
    {
        Console.WriteLine("Plugin1 Executed");
    }

    public void Stop()
    {
       Console.WriteLine("Plugin1 Stopped");
    }
}