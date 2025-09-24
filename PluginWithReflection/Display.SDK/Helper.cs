using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    public static class Helper
    {
        public static List<Plug> GetPlugs(string selectedPath)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(nameof(selectedPath));

            if (!Directory.Exists(selectedPath))
            {
                throw new FileNotFoundException();
            }

            List<Plug> plugs = getPluginsInPath(selectedPath);
            return plugs;
        }

        private static List<Plug> getPluginsInPath(string selectedPath)
        {
            //Belirtilen klasördeki dll dosyalarını referans ekle:
            var dllFiles = Directory.GetFiles(selectedPath, "*.dll");

            var plugs = new List<Plug>();

            dllFiles?.ToList().ForEach(file => addReference(file,plugs));

            return plugs;
        }

        private static  void addReference(string file, List<Plug> plugs)
        {
            var assembly = Assembly.LoadFile(file);
            var types = assembly.GetTypes();

        
            types?.ToList().ForEach(type =>
            {
                Plug plug = handShakeForApp(type, file);
                if (plug != null)
                {
                    plugs.Add(plug);

                }
            });

        
        }

        private static Plug handShakeForApp(Type type, string file)
        {
            Plug plug = null;
            if (type.GetInterface("IPlug") != null)
            {
                plug = new Plug();
                plug.Path = file;
                plug.FullName = type.FullName;

                var instance = Activator.CreateInstance(type);
               //  instance.Name;
                //plug.Name = instance.GetType().GetProperty("Name").GetValue(instance).ToString();

                dynamic dynamicInstance = Activator.CreateInstance(type);
                plug.Name = dynamicInstance.Name;

             
                
            }

            return plug;
        }

        public static IPlug CreateInstance(Plug plug)
        {
            Assembly assembly = Assembly.LoadFile(plug.Path);
            var instance = assembly.CreateInstance(plug.FullName);
            return (IPlug)instance;
        }
    }
}
