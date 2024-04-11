namespace patt;

public interface IPlugin
{
    string Name { get; set; }
    void Start();
    void Execute();
    void Stop();
}