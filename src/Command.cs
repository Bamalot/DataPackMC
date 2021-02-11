
namespace DataPackMC
{
    public class Command
    {
        protected string str;

        public override string ToString()
        {
            return str;
        }
    }

    public class SetBlockCommand : Command
    {
        public SetBlockCommand(Position position, string id, SetBlockMode mode=SetBlockMode.Replace)
        {
            this.str = $"setblock {position} {id} {Util.GetSetBlockModeString(mode)}";
        }
    }
    public class GiveCommand : Command
    {
        public GiveCommand(TargetSelector selector, Item item, int count=1)
        {
            this.str = $"give {selector} {item} {count}";
        }
    }
}