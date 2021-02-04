using System.Collections.Generic;

namespace DataPackMC
{
    public enum SelectorType
    {
        AllPlayers,
        AllEntities,
        NearestPlayer,
        RandomPlayer,
        Executor
    }
    public enum SelectorSortType
    {
        Nearest,
        Furthest,
        Random,
        Arbitrary
    }
    public class TargetSelector
    {
        SelectorType type;
        List<string> requirements = new List<string>();
        public TargetSelector(SelectorType type)
        {
            this.type = type;
        }

        public void SetPosition(double x, double y, double z)
        {
            requirements.Add($"x={x},y={y},z={z}");
        }
        public void SetVolume(double x, double y, double z)
        {
            requirements.Add($"dx={x},dy={y},dz={z}");
        }
        public void SetDistance(int dist)
        {
            requirements.Add($"distance={dist}");
        }
        public void SetDistanceRange(int min, int max=-1)
        {
            if(max == -1)
            {
                requirements.Add($"distance={min}..");
                return;
            }
            requirements.Add($"distance={min}..{max}");
        }
        public void SetLimit(int limit, SelectorSortType sort)
        {
            string sortString = "";
            switch(sort)
            {
                case SelectorSortType.Nearest:
                    sortString = "nearest";
                    break;
                case SelectorSortType.Furthest:
                    sortString = "furthest";
                    break;
                case SelectorSortType.Random:
                    sortString = "random";
                    break;
                case SelectorSortType.Arbitrary:
                    sortString = "arbitrary";
                    break;
            }
            requirements.Add($"limit={limit},sort={sortString}");
        }
        public void AddTag(string tag)
        {
            requirements.Add($"tag={tag}");
        }
        public override string ToString()
        {
            string str = "";
            switch(type)
            {
                case SelectorType.AllPlayers:
                    str = "@a";
                    break;
                case SelectorType.AllEntities:
                    str = "@e";
                    break;
                case SelectorType.NearestPlayer:
                    str = "@p";
                    break;
                case SelectorType.RandomPlayer:
                    str = "@r";
                    break;
                case SelectorType.Executor:
                    str = "@s";
                    break;
            }
            if(requirements.Count > 0)
            {
                str += "[";
                for(int i = 0;i < requirements.Count;i++)
                {
                    str += requirements[i];
                    if(i != (requirements.Count - 1))
                    {
                        str += ",";
                    }
                }
                str += "]";
            }
            return str;
        }
    }
}