namespace Fortnite.Net.Model.Fortnite
{
    public class VariantUpdate
    {
        
        public string Channel { get; set; }
        public string Active { get; set; }
        public string[] Owned { get; set; }

        public static VariantUpdate Create(string channel, string active, params string[] owned) => new VariantUpdate
        {
            Channel = channel,
            Active = active,
            Owned = owned
        };

    }
}