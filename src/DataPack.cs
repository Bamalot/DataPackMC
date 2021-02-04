using System;
using System.Collections.Generic;
using System.IO;

namespace DataPackMC
{
    public class DataPack
    {
        public string Name => name;
        public string Path => path;
        public string DataPath => dataPath;

        string name;
        string path;
        string dataPath;
        public DataPack(string name, string description, string destFolder)
        {
            this.name = name;
            this.path = destFolder + $"\\{name}";
            this.dataPath = path + "\\data";
            Directory.CreateDirectory(path);
            File.WriteAllText(path + "\\pack.mcmeta", $"{{'pack': {{'pack_format': 6, 'description': '{description}'}} }}".Replace("'", "\""));
        }

        public DataNamespace AddNamespace(string name)
        {
            string namespacePath = dataPath + $"\\{name}";
            return new DataNamespace(name, namespacePath);
        }
    }
}
