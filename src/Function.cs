using System.IO;

namespace DataPackMC
{
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
        public void GiveItems(TargetSelector selector, Item item, int count=1)
        {
            RunCommand($"give {selector} {item} {count}");
        }
        public void RunCommand(string command)
        {
            file.WriteLine(command);
        }
        public void EndFunction()
        {
            file.Close();
        }
    }

}