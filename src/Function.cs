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
        public void GiveItems(TargetSelector selector, Item item, int count=1)
        {
            RunCommand($"give {selector} {item} {count}");
        }
        public void SetBlock(Position position, string id, SetBlockMode mode=SetBlockMode.Replace)
        { 
            switch(mode)
            {
                case SetBlockMode.Destroy:
                    RunCommand($"setblock {position} {id} destroy");
                    break;
                case SetBlockMode.Keep:
                    RunCommand($"setblock {position} {id} keep");
                    break;
                case SetBlockMode.Replace:
                    RunCommand($"setblock {position} {id} replace");
                    break;
            }
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