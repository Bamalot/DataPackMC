using System.Collections.Generic;

namespace DataPackMC
{
    public class Item
    {
        public string ID => id;

        List<string> tagData = new List<string>();
        string id;

        public Item(string id)
        {
            this.id = id;
        }

        public void SetUnbreakable(bool unbreakable)
        {
            if(unbreakable)
            {
                tagData.Add("Unbreakable:1");
                return;
            }
            tagData.Add("Unbreakable:0");
        }
        public void SetDamage(int damage)
        {
            tagData.Add($"Damage:{damage}");
        }
        public override string ToString()
        {
            string str = id;
            if(tagData.Count > 0)
            {
                str += "{";
                for(int i = 0;i < tagData.Count;i++)
                {
                    str += tagData[i];
                    if(i != (tagData.Count - 1))
                    {
                        str += ",";
                    }
                }
                str += "}";
            }
            return str;
        }
    }
}