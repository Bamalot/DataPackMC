using System.IO;

namespace DataPackMC
{
    public class DataNamespace
    {
        public string Name => name;

        string name;
        string path;

        public DataNamespace(string name, string path)
        {
            this.name = name;
            this.path = path;
        }

        public Function AddFunction(string name)
        {
            Directory.CreateDirectory(path + "\\functions");
            string functionPath = path + $"\\functions\\{name}.mcfunction";
            return new Function(name, functionPath);
        }
    }
}