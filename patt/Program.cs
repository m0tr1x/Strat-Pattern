namespace patt;

class Program
{
    static void Main(string[] args)
    {
        
        // Получаем путь к директории, откуда было запущено приложение
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        
        PluginLoader pluginLoader = new PluginLoader();
        List<IPlugin> plugins = pluginLoader.LoadPlugins(currentDirectory);

        // Выполнение плагинов по запросу пользователя
        foreach (IPlugin plugin in plugins)
        {
            plugin.Execute();
        }

        foreach (IPlugin plugin in plugins)
        {
            plugin.Stop();
        }
    }
}