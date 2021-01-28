using System.Collections.Generic;

namespace Fortnite.Net.Model.Fortnite
{
    public class ProfileItemStack
    {
        
        public string ItemType { get; set; }
        public string ItemGuid { get; set; }
        public string ItemProfile { get; set; }
        public Dictionary<string, string> Attributes { get; set; }
        public int Quantity { get; set; }
        
    }
}