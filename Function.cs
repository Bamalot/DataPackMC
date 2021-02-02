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
        void OutputLine(string line)
        {
            file.WriteLine(line);
        }
        public void EndFunction()
        {
            file.Close();
        }
    }

}