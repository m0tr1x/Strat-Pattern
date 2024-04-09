using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace patt
{
    public class PluginLoader
    {
        public List<IPlugin> Plugins { get; set; } = new List<IPlugin>(); // Инициализация списка плагинов

        public List<IPlugin> LoadPlugins(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.dll"); // Принимает файлы с расширением dll
                foreach (var file in files)
                {
                    try
                    {
                        var assembly = Assembly.LoadFile(file); // Загрузка сборки
                        var types = assembly.GetTypes().Where(t =>
                            typeof(IPlugin).IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface); // Получение типов, реализующих интерфейс IPlugin
                        foreach (var type in types)
                        {
                            var plugin = Activator.CreateInstance(type) as IPlugin; // Создание экземпляра плагина
                            if (plugin is not null)
                            {
                                plugin.Start();
                                Plugins.Add(plugin);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка загрузка плагина {ex.Message}");
                    }
                }
            }
            else throw new Exception("Директории по такому пути не существует");

            return Plugins;
        }
    }
}