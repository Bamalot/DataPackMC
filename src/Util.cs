
namespace DataPackMC
{
    public static class Util
    {
        public static string GetGameModeString(GameMode mode)
        {
            switch(mode)
            {
                case GameMode.Creative:
                    return "creative";
                case GameMode.Adventure:
                    return "adventure";
                case GameMode.Spectator:
                    return "spectator";
                default:
                    return "survival";
            }
        }
        public static string GetTargetSelectorString(SelectorType type)
        {
            switch(type)
            {
                case SelectorType.AllEntities:
                    return "@e";
                case SelectorType.NearestPlayer:
                    return "@p";
                case SelectorType.RandomPlayer:
                    return "@r";
                case SelectorType.Executor:
                    return "@s";
                default:
                    return "@a";
            }
        }
        public static string GetSelectorSortString(SelectorSortType sort)
        {
            switch(sort)
            {
                case SelectorSortType.Nearest:
                    return "nearest";
                case SelectorSortType.Furthest:
                    return "furthest";
                case SelectorSortType.Random:
                    return "random";
                default:
                    return "arbitrary";
            }
        }
        public static string GetSetBlockModeString(SetBlockMode mode)
        {
            switch(mode)
            {
                case SetBlockMode.Destroy:
                    return "destroy";
                case SetBlockMode.Keep:
                    return "keep";
                default:
                    return "replace";
            }
        }
    }
}