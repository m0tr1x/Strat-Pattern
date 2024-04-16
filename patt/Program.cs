namespace patt;

class Program
{
    static void Main(string[] args)
    {
        
        // Получаем путь к директории, откуда было запущено приложение
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        
        PluginLoader pluginLoader = new PluginLoader();
        List<IPlugin> plugins = pluginLoader.LoadPlugins(currentDirectory);
        
        //Вывод всех доступных плагинов
        Console.WriteLine("\nList of avaliable plugins:");
        foreach (IPlugin plugin in plugins)
        {
            Console.WriteLine(plugin.Name);
        }
        Console.WriteLine("\n Choose your plugin:");
        var currentPlugin = plugins.Find(x => x.Name == Console.ReadLine());
        
        if(currentPlugin != null) currentPlugin.Start();
        else Console.WriteLine("Plugin not found");
        
        foreach (IPlugin plugin in plugins)
        {
            plugin.Stop();
        }
    }
}