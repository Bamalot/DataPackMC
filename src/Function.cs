using System.IO;

namespace DataPackMC
{
    public enum SetBlockMode
    {
        Destroy,
        Keep,
        Replace
    }
    public class Function
    {
        public string Name;
        public string Path;

        string name;
        string path;

        StreamWriter file;
        public Function(string name, string filePath)
        {
            this.name = name;
            this.path = filePath;
            this.file = new StreamWriter(new FileStream(filePath, FileMode.Create));
        }
        public void RunCommand(Command command)
        {
            file.WriteLine(command.ToString());
        }
        public void EndFunction()
        {
            file.Close();
        }
    }

}